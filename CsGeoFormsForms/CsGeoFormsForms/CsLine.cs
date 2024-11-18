using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGeoFormsForms
{
    class CsLine(int positionX, int positionY, int width, int height, Color color) : CsGeoForm(positionX, positionY, width, height, color)
    {
        public override void Draw(Graphics aGraphics)
        {
            aGraphics.DrawLine(new Pen(color), position, Point.Add(position, size));
        }
    }
}
