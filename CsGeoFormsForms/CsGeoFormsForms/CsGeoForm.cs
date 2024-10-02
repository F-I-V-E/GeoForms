using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGeoFormsForms
{
    /*
    abstract class CsGeoForm(int positionX, int positionY, int width, int height, Color color)
    {
        protected Point Position = new(positionX, positionY);
        protected Size Size = new(width, height);
        protected Color color = color;

        public virtual void Draw(Graphics aGraphics) { }
    }
    */
    class CsGeoForm(int positionX, int positionY, int width, int height, Color color)
    {
        protected Point Position = new(positionX, positionY);
        protected Size Size = new(width, height);
        protected Color color = color;

        public void Draw() { }
    }
}
