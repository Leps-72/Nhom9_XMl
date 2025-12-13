using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Helper
{
    class MenuStripFullBorderRenderer : ToolStripProfessionalRenderer
    {
        // Vẽ nền MenuStrip + border ngoài
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            base.OnRenderToolStripBackground(e);

            if (e.ToolStrip is MenuStrip menu)
            {
                Rectangle rect = new Rectangle(
                    0, 0,
                    menu.Width - 1,
                    menu.Height - 1
                );

                using (Pen pen = new Pen(Color.SaddleBrown, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        // Vẽ vạch chia giữa các item
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderMenuItemBackground(e);

            // Chỉ áp dụng cho menu cấp 1
            if (e.Item.Owner is MenuStrip)
            {
                Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);

                // ❌ không vẽ vạch cho item cuối
                

                using (Pen pen = new Pen(Color.SaddleBrown,2))
                {
                    e.Graphics.DrawLine(
                        pen,
                        rect.Right +1,
                        0,
                        rect.Right +1,
                        rect.Bottom  
                    );
                }
            }
        }
    }


}
