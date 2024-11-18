using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGeoFormsForms
{
    class CsRectangle : CsGeoForm
    {
        public CsRectangle(int positionX, int positionY, int width, int height, Color color) : base(color)
        {
            if (width < 0)
            {
                positionX += width;
                width = -width;
            }
            if (height < 0)
            {
                positionY += height;
                height = -height;
            }
            size = new Size(width, height);
            position = new Point(positionX, positionY);
        }

        public override void Draw(Graphics aGraphics)
        {
            if (size.Width < 0)
            {
                position.X += size.Width;
                size.Width = Math.Abs(size.Width);
            }
            if (size.Height < 0)
            {
                position.Y += size.Height;
                size.Height = Math.Abs(size.Height);
            }
            aGraphics.DrawRectangle(new Pen(borderColor), new Rectangle(position, size));
        }
    }
}
