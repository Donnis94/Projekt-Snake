using System;
using System.Collections.Generic;
using System.Drawing;
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
            drawArea = drawControll.CreateGraphics();

            if (drawControll.Size.Width > 1200)
            {
                float iX = coordConv.toViewX(9);
                float iY = coordConv.toViewY(9);
                float scale = coordConv.scale;
                Console.Write("");
            }
        }

        public void DrawAt(int x, int y, Brush b)
        {
            drawArea.FillRectangle(b, coordConv.toViewX(x), coordConv.toViewY(y), coordConv.scale, coordConv.scale);
        }

        public void DrawAt(int x, int y, int width, int heigth, Brush b)
        {
            drawArea.FillRectangle(b, coordConv.toViewX(x), coordConv.toViewY(y), width * coordConv.scale, heigth * coordConv.scale);
        }
    }
}
