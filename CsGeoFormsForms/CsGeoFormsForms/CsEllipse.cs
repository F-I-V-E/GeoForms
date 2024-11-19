using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGeoFormsForms
{
    class CsEllipse(int positionX, int positionY, int width, int height, Color color) : CsGeoForm(positionX, positionY, width, height, color), IMovable
    {
        public override void Draw(Graphics aGraphics)
        {
            aGraphics.DrawEllipse(new Pen(color), new Rectangle(position, size));
        }
        public void MoveRelative(int aDistanceX, int aDistanceY)
        {
            position.X += aDistanceX;
            position.Y += aDistanceY;
        }

        public void MoveAbsolute(Point aPosition)
        {
            position = aPosition;
        }
    }
}
