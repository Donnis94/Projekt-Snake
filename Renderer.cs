using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Projekt
{
    public class Renderer
    {
        private CoordinateConverter coordConv;
        private Control drawControll;
        private Graphics drawArea;

        public Renderer(Control _c, int tilesX, int tilesY)
        {
            drawControll = _c;
            drawArea = drawControll.CreateGraphics();
            coordConv = new CoordinateConverter(drawControll.Size.Width, drawControll.Size.Height, tilesX, tilesY);
        }

        public void updateAreaSize()
        {
            coordConv.setDimentions(drawControll.Size.Width, drawControll.Size.Height);
            
        }

        public void UpdateGraphic(Graphics g)
        {
            drawArea = g;
        }

        public void DrawAt(int x, int y, Brush b)
        {
            DrawAt(x, y, 1, 1, b);
        }

        public void DrawAt(int x, int y, int width, int heigth, Brush b)
        {
            drawArea.FillRectangle(b, coordConv.toViewX(x), coordConv.toViewY(y), width * coordConv.scale, heigth * coordConv.scale);
        }

        public void DrawImage(int x, int y, int width, int heigth, Image image, Color tint)
        {
            Rectangle rf = new Rectangle(0, 0, (int)(width * coordConv.scale), (int)(heigth * coordConv.scale));
            drawArea.DrawImage(image, rf, coordConv.toViewX(x), coordConv.toViewY(y), width * coordConv.scale, heigth * coordConv.scale, GraphicsUnit.Pixel, new ImageAttributes());
        }

        public void DrawImage(int x, int y, int width, int heigth, Image image)
        {
            drawArea.DrawImage(image,coordConv.toViewX(x), coordConv.toViewY(y), width * coordConv.scale, heigth * coordConv.scale);
        }
        public void DrawImage(int x, int y, Image image)
        {
            DrawImage(x, y, 1, 1, image);
        }
    }
}
