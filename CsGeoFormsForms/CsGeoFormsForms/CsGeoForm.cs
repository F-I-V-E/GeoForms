using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGeoFormsForms
{
    abstract class CsGeoForm
    {
        protected Point position;
        protected Size size;
        protected Color borderColor;
        public CsGeoForm(int positionX, int positionY, int width, int height, Color color)
        {
            position = new(positionX, positionY);
            size = new(width, height);
            borderColor = color;
        }

        public CsGeoForm(Color borderColor) => this.borderColor = borderColor;
        public abstract void Draw(Graphics agraphics);
    }
}
