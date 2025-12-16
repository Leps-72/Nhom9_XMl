<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<!-- Thiết kế chung -->
	<xsl:template name="header">
		<html>
			<head>
				<meta charset="UTF-8"/>
				<title>
					<xsl:value-of select="name(.)"/>
				</title>
				<style type="text/css">
					body { font-family: 'Segoe UI', Arial, sans-serif; margin: 40px; background: #f9f5eb; color: #333; }
					h1 { text-align: center; color: #6b4e31; margin-bottom: 10px; }
					h2 { color: #6b4e31; border-bottom: 2px solid #6b4e31; padding-bottom: 8px; margin-top: 40px; }
					table { width: 100%; border-collapse: collapse; margin: 20px 0; box-shadow: 0 2px 10px rgba(0,0,0,0.1); }
					th, td { padding: 12px 15px; border: 1px solid #ddd; text-align: left; }
					th { background: #6b4e31; color: white; font-weight: bold; }
					tr:nth-child(even) { background: #f2f2f2; }
					.print-btn { display: block; margin: 20px auto; padding: 12px 30px; background: #6b4e31; color: white; border: none; cursor: pointer; font-size: 16px; border-radius: 5px; }
					.print-btn:hover { background: #8b6f47; }
					.date { text-align: right; color: #666; font-style: italic; margin-bottom: 20px; }
				</style>
			</head>
			<body>
				<button class="print-btn" onclick="window.print()">In báo cáo</button>
				<p class="date" id="printDate"></p>
				<script type="text/javascript">
					function formatVietnameseDate(date) {
					const optionsDate = { day: '2-digit', month: '2-digit', year: 'numeric' };
					const optionsTime = { hour: '2-digit', minute: '2-digit', second: '2-digit', hour12: false };
					return date.toLocaleDateString('vi-VN', optionsDate) + ' ' + date.toLocaleTimeString('vi-VN', optionsTime);
					}
					document.getElementById('printDate').textContent = 'Ngày xuất: ' + formatVietnameseDate(new Date());
				</script>
				<h1>QUẢN LÝ QUÁN CÀ PHÊ</h1>
				<xsl:apply-templates/>
			</body>
		</html>
	</xsl:template>

	<!-- Danh mục (DanhMuc.xml) -->
	<xsl:template match="/DanhMucs">
		<xsl:call-template name="header"/>
		<h2>Danh sách Danh mục</h2>
		<table>
			<tr>
				<th>Mã DM</th>
				<th>Tên DM</th>
				<th>Mô tả</th>
			</tr>
			<xsl:for-each select="DanhMuc">
				<tr>
					<td>
						<xsl:value-of select="MaDM"/>
					</td>
					<td>
						<xsl:value-of select="TenDM"/>
					</td>
					<td>
						<xsl:value-of select="MoTa"/>
					</td>
				</tr>
			</xsl:for-each>
		</table>
	</xsl:template>

	<!-- Loại nhân viên (LoaiNhanVien.xml) -->
	<xsl:template match="/DanhSachLoaiNhanVien">
		<xsl:call-template name="header"/>
		<h2>Danh sách Loại nhân viên</h2>
		<table>
			<tr>
				<th>Mã loại</th>
				<th>Tên loại</th>
			</tr>
			<xsl:for-each select="Loai">
				<tr>
					<td>
						<xsl:value-of select="MaLoai"/>
					</td>
					<td>
						<xsl:value-of select="TenLoai"/>
					</td>
				</tr>
			</xsl:for-each>
		</table>
	</xsl:template>

	<!-- Chấm công (ChamCong.xml) -->
	<xsl:template match="/DanhSachChamCong">
		<xsl:call-template name="header"/>
		<h2>Bảng chấm công</h2>
		<table>
			<tr>
				<th>Mã NV</th>
				<th>Họ tên</th>
				<th>Loại NV</th>
				<th>Ngày làm</th>
				<th>Giờ vào</th>
				<th>Giờ ra</th>
				<th>Số giờ</th>
			</tr>
			<xsl:for-each select="ChamCong">
				<tr>
					<td>
						<xsl:value-of select="MaNV"/>
					</td>
					<td>
						<xsl:value-of select="HoTen"/>
					</td>
					<td>
						<xsl:value-of select="LoaiNhanVien"/>
					</td>
					<td>
						<xsl:value-of select="NgayLam"/>
					</td>
					<td>
						<xsl:value-of select="GioVao"/>
					</td>
					<td>
						<xsl:value-of select="GioRa"/>
					</td>
					<td>
						<xsl:value-of select="SoGio"/>
					</td>
				</tr>
			</xsl:for-each>
		</table>
	</xsl:template>

	<!-- Nhân viên (NhanVien.xml) -->
	<xsl:template match="/DanhSachNhanVien">
		<xsl:call-template name="header"/>
		<h2>Danh sách nhân viên</h2>
		<table>
			<tr>
				<th>Mã NV</th>
				<th>Họ tên</th>
				<th>Tên đăng nhập</th>
				<th>Quyền</th>
				<th>Ngày vào làm</th>
			</tr>
			<xsl:for-each select="NhanVien">
				<tr>
					<td>
						<xsl:value-of select="@MaNV"/>
					</td>
					<td>
						<xsl:value-of select="HoTen"/>
					</td>
					<td>
						<xsl:value-of select="TenDangNhap"/>
					</td>
					<td>
						<xsl:value-of select="QuyenTruyCap"/>
					</td>
					<td>
						<xsl:value-of select="NgayVaoLam"/>
					</td>
				</tr>
			</xsl:for-each>
		</table>
	</xsl:template>

	<!-- Món (Mon.xml) -->
	<xsl:template match="/Mons">
		<xsl:call-template name="header"/>
		<h2>Danh sách món</h2>
		<table>
			<tr>
				<th>Mã món</th>
				<th>Tên món</th>
				<th>Mã DM</th>
				<th>Đơn giá</th>
			</tr>
			<xsl:for-each select="Mon">
				<tr>
					<td>
						<xsl:value-of select="MaMon"/>
					</td>
					<td>
						<xsl:value-of select="TenMon"/>
					</td>
					<td>
						<xsl:value-of select="MaDM"/>
					</td>
					<td style="text-align:right;">
						<xsl:value-of select="format-number(DonGia, '#,##0')"/> VND
					</td>
				</tr>
			</xsl:for-each>
		</table>
	</xsl:template>

	<!-- Lương tháng (LuongThang.xml) -->
	<xsl:template match="/DanhSachLuong">
		<xsl:call-template name="header"/>
		<h2>Bảng lương nhân viên</h2>
		<table>
			<tr>
				<th>Mã NV</th>
				<th>Họ tên</th>
				<th>Tổng giờ</th>
				<th>Số ngày</th>
				<th>Lương/giờ</th>
				<th>Tổng lương</th>
				<th>Tháng</th>
				<th>Năm</th>
			</tr>
			<xsl:for-each select="Luong">
				<tr>
					<td>
						<xsl:value-of select="MaNV"/>
					</td>
					<td>
						<xsl:value-of select="HoTen"/>
					</td>
					<td>
						<xsl:value-of select="TongGio"/>
					</td>
					<td>
						<xsl:value-of select="SoNgay"/>
					</td>
					<td>
						<xsl:value-of select="LuongGio"/>
					</td>
					<td style="text-align:right;">
						<xsl:value-of select="format-number(TongLuong, '#,##0')"/> VND
					</td>
					<td>
						<xsl:value-of select="Thang"/>
					</td>
					<td>
						<xsl:value-of select="Nam"/>
					</td>
				</tr>
			</xsl:for-each>
		</table>
	</xsl:template>

	<!-- Chi tiết hóa đơn (ChiTietHoaDon.xml) -->
	<xsl:template match="/ChiTietHoaDons">
		<xsl:call-template name="header"/>
		<h2>Chi tiết hóa đơn</h2>
		<table>
			<tr>
				<th>Mã HD</th>
				<th>Mã món</th>
				<th>Tên món</th>
				<th>Số lượng</th>
				<th>Đơn giá</th>
				<th>Thành tiền</th>
			</tr>
			<xsl:for-each select="ChiTiet">
				<tr>
					<td>
						<xsl:value-of select="MaHD"/>
					</td>
					<td>
						<xsl:value-of select="MaMon"/>
					</td>
					<td>
						<xsl:value-of select="TenMon"/>
					</td>
					<td>
						<xsl:value-of select="SoLuong"/>
					</td>
					<td>
						<xsl:value-of select="format-number(DonGia, '#,##0')"/> VND
					</td>
					<td style="text-align:right;">
						<xsl:value-of select="format-number(ThanhTien, '#,##0')"/> VND
					</td>
				</tr>
			</xsl:for-each>
		</table>
	</xsl:template>

	<!-- Hóa đơn (HoaDon.xml) -->
	<xsl:template match="/HoaDons">
		<xsl:call-template name="header"/>
		<h2>Danh sách hóa đơn</h2>
		<table>
			<tr>
				<th>Mã HD</th>
				<th>Mã phiếu</th>
				<th>Mã bàn</th>
				<th>Ngày lập</th>
				<th>Mã NV</th>
				<th>Tổng tiền</th>
				<th>Giảm giá</th>
				<th>Thành tiền</th>
				<th>Hình thức</th>
			</tr>
			<xsl:for-each select="HoaDon">
				<tr>
					<td>
						<xsl:value-of select="@MaHD"/>
					</td>
					<td>
						<xsl:value-of select="MaPhieu"/>
					</td>
					<td>
						<xsl:value-of select="MaBan"/>
					</td>
					<td>
						<xsl:value-of select="NgayLap"/>
					</td>
					<td>
						<xsl:value-of select="MaNhanVien"/>
					</td>
					<td>
						<xsl:value-of select="format-number(TongTien, '#,##0')"/> VND
					</td>
					<td>
						<xsl:value-of select="GiamGia"/> VND
					</td>
					<td>
						<xsl:value-of select="format-number(ThanhTien, '#,##0')"/> VND
					</td>
					<td>
						<xsl:value-of select="HinhThucThanhToan"/>
					</td>
				</tr>
			</xsl:for-each>
		</table>
	</xsl:template>

</xsl:stylesheet>