USE master;
GO

-- XÓA DATABASE NẾU ĐÃ TỒN TẠI
IF DB_ID('QuanLyQuanCaPhe') IS NOT NULL
BEGIN
    ALTER DATABASE QuanLyQuanCaPhe SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyQuanCaPhe;
END
GO

-- TẠO LẠI DATABASE MỚI
CREATE DATABASE QuanLyQuanCaPhe;
GO

USE QuanLyQuanCaPhe;
GO

-- =============================================
-- 1. BẢNG LOẠI NHÂN VIÊN
-- =============================================
IF OBJECT_ID('LoaiNhanVien', 'U') IS NOT NULL DROP TABLE LoaiNhanVien;
CREATE TABLE LoaiNhanVien (
    MaLoai NVARCHAR(50) PRIMARY KEY,
    TenLoai NVARCHAR(100) NOT NULL
);

-- =============================================
-- 2. BẢNG NHÂN VIÊN
-- =============================================
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien;
CREATE TABLE NhanVien (
    MaNV NVARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,
    MatKhau NVARCHAR(255) NOT NULL,           -- Nên lưu hash (bcrypt, SHA256...)
    QuyenTruyCap NVARCHAR(50) NOT NULL,        -- QuanLy, BanHang, PhucVu...
    NgayVaoLam DATE NOT NULL DEFAULT GETDATE()
);

-- =============================================
-- 3. BẢNG CHẤM CÔNG
-- =============================================
IF OBJECT_ID('ChamCong', 'U') IS NOT NULL DROP TABLE ChamCong;
CREATE TABLE ChamCong (
    MaNV NVARCHAR(50) NOT NULL,
    NgayLam DATE NOT NULL,
    GioVao TIME NOT NULL DEFAULT '08:00:00',
    GioRa TIME NOT NULL DEFAULT '17:00:00',
    SoGio FLOAT NOT NULL DEFAULT 0,
    HoTen NVARCHAR(100) NULL,           -- Denormalized cho tiện hiển thị
    LoaiNhanVien NVARCHAR(50) NULL,
    PRIMARY KEY (MaNV, NgayLam),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE CASCADE,
    FOREIGN KEY (LoaiNhanVien) REFERENCES LoaiNhanVien(MaLoai)
);

-- =============================================
-- 4. BẢNG MÓN
-- =============================================
IF OBJECT_ID('Mon', 'U') IS NOT NULL DROP TABLE Mon;
CREATE TABLE Mon (
    MaMon NVARCHAR(50) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    DanhMuc NVARCHAR(100) NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL DEFAULT 0
);

-- =============================================
-- 5. BẢNG HÓA ĐƠN
-- =============================================
IF OBJECT_ID('HoaDon', 'U') IS NOT NULL DROP TABLE HoaDon;
CREATE TABLE HoaDon (
    MaHD NVARCHAR(50) PRIMARY KEY,
    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(18, 2) NOT NULL DEFAULT 0,
    GiamGiaPercent DECIMAL(5, 2) NOT NULL DEFAULT 0 CHECK (GiamGiaPercent BETWEEN 0 AND 100),
    ThanhTien DECIMAL(18, 2) NOT NULL DEFAULT 0,
    HinhThucThanhToan NVARCHAR(50) NOT NULL DEFAULT 'TienMat'
);

-- =============================================
-- 6. BẢNG CHI TIẾT HÓA ĐƠN
-- =============================================
IF OBJECT_ID('ChiTietHoaDon', 'U') IS NOT NULL DROP TABLE ChiTietHoaDon;
CREATE TABLE ChiTietHoaDon (
    MaHD NVARCHAR(50) NOT NULL,
    MaMon NVARCHAR(50) NOT NULL,
    TenMon NVARCHAR(100) NULL,
    SoLuong INT NOT NULL DEFAULT 1 CHECK (SoLuong > 0),
    DonGia DECIMAL(18, 2) NOT NULL DEFAULT 0,
    ThanhTien AS (SoLuong * DonGia) PERSISTED,  -- Tự động tính, không cần trigger
    PRIMARY KEY (MaHD, MaMon),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
    FOREIGN KEY (MaMon) REFERENCES Mon(MaMon)
);

-- =============================================
-- 7. BẢNG ORDER ITEM TẠM (nếu cần lưu tạm trước khi lập hóa đơn)
-- =============================================
IF OBJECT_ID('OrderItem', 'U') IS NOT NULL DROP TABLE OrderItem;
CREATE TABLE OrderItem (
    SessionId NVARCHAR(100) NOT NULL,   -- Có thể là Guid hoặc mã bàn
    MaMon NVARCHAR(50) NOT NULL,
    TenMon NVARCHAR(100) NOT NULL,
    SoLuong INT NOT NULL DEFAULT 1,
    DonGia DECIMAL(18, 2) NOT NULL,
    ThanhTien AS (SoLuong * DonGia),
    FOREIGN KEY (MaMon) REFERENCES Mon(MaMon)
);
GO

-- =============================================
-- TRIGGER TỰ ĐỘNG TÍNH SỐ GIỜ CHẤM CÔNG (đã sửa lỗi Ambiguous)
-- =============================================
IF OBJECT_ID('TR_ChamCong_CalculateSoGio', 'TR') IS NOT NULL
    DROP TRIGGER TR_ChamCong_CalculateSoGio;
GO

CREATE TRIGGER TR_ChamCong_CalculateSoGio
ON ChamCong
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE c
    SET SoGio = CAST(DATEDIFF(MINUTE, c.GioVao, c.GioRa) AS FLOAT) / 60.0
    FROM ChamCong c
    INNER JOIN inserted i ON c.MaNV = i.MaNV AND c.NgayLam = i.NgayLam;

    -- Nếu giờ ra nhỏ hơn giờ vào (ví dụ qua đêm) thì +24h
    UPDATE c
    SET SoGio = CAST(DATEDIFF(MINUTE, c.GioVao, c.GioRa) AS FLOAT) / 60.0 + 24
    FROM ChamCong c
    INNER JOIN inserted i ON c.MaNV = i.MaNV AND c.NgayLam = i.NgayLam
    WHERE c.GioRa < c.GioVao;
END;
GO

-- =============================================
-- TRIGGER CẬP NHẬT TỔNG TIỀN HÓA ĐƠN KHI THAY ĐỔI CHI TIẾT
-- =============================================
IF OBJECT_ID('TR_HoaDon_UpdateTongTien', 'TR') IS NOT NULL
    DROP TRIGGER TR_HoaDon_UpdateTongTien;
GO

CREATE TRIGGER TR_HoaDon_UpdateTongTien
ON ChiTietHoaDon
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH AffectedHD AS (
        SELECT MaHD FROM inserted
        UNION
        SELECT MaHD FROM deleted
    )
    UPDATE hd
    SET 
        TongTien = ISNULL((
            SELECT SUM(ThanhTien) 
            FROM ChiTietHoaDon ct 
            WHERE ct.MaHD = hd.MaHD
        ), 0),
        ThanhTien = ISNULL((
            SELECT SUM(ThanhTien) 
            FROM ChiTietHoaDon ct 
            WHERE ct.MaHD = hd.MaHD
        ), 0) * (1 - hd.GiamGiaPercent / 100)
    FROM HoaDon hd
    INNER JOIN AffectedHD a ON hd.MaHD = a.MaHD;
END;
GO

-- Nếu bảng đã có thì xóa trước (để chạy lại nhiều lần không lỗi)
IF OBJECT_ID('Ban', 'U') IS NOT NULL
    DROP TABLE Ban
GO

-- Tạo lại bảng Ban
CREATE TABLE Ban (
    MaBan NVARCHAR(50) PRIMARY KEY,
    TenBan NVARCHAR(100) NOT NULL,
    KhuVuc NVARCHAR(100) NULL,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Trống',   -- Trống / Đang phục vụ / Đã đặt trước / Hỏng
    GhiChu NVARCHAR(255) NULL
)
GO

-- Thêm dữ liệu mẫu để test luôn
INSERT INTO Ban (MaBan, TenBan, KhuVuc, TrangThai, GhiChu) VALUES
('B001', N'Bàn 1', N'Tầng 1', N'Trống', NULL),
('B002', N'Bàn 2', N'Tầng 1', N'Trống', NULL),
('B003', N'Bàn 3', N'Tầng 1', N'Trống', NULL),
('B004', N'Bàn VIP 1', N'Phòng VIP', N'Trống', N'Bàn lớn 10 người'),
('B005', N'Bàn ngoài trời 1', N'Sân vườn', N'Trống', NULL)
GO

PRINT N'Đã tạo bảng Ban thành công!'

-- =============================================
-- DỮ LIỆU MẪU (TÙY CHỌN)
-- =============================================
INSERT INTO LoaiNhanVien (MaLoai, TenLoai) VALUES 
('LNV001', 'Quản lý'),
('LNV002', 'Nhân viên bán hàng'),
('LNV003', 'Pha chế');

INSERT INTO NhanVien (MaNV, HoTen, TenDangNhap, MatKhau, QuyenTruyCap, NgayVaoLam) VALUES
('NV001', N'Administrator', 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'QuanLy', '2024-01-01'),
('NV002', N'Nguyễn Văn A', 'nva', 'hashed_password_here', 'BanHang', '2025-01-01');

INSERT INTO Mon (MaMon, TenMon, DanhMuc, DonGia) VALUES
('M001', N'Cà phê đen', N'Đồ uống', 25000),
('M002', N'Trà sữa trân châu', N'Đồ uống', 35000),
('M003', N'Bánh mì pate', N'Ăn vặt', 20000);

PRINT N'Tạo database và các bảng thành công! Bạn có thể chạy lại script này bao nhiêu lần cũng được.';
GO