using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    public class Renderer
    {
        Graphics drawArea;

        public Renderer(Graphics g)
        {
            drawArea = g;
        }

        public void DrawAt(int x, int y, Pen p)
        {
            int magicTileNumber = 32; //Make less magical in the future
            drawArea.DrawRectangle(p, x * magicTileNumber, y * magicTileNumber, magicTileNumber, magicTileNumber);
        }
    }
}
