﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGeoFormsForms
{
    class CsRectangle(int positionX, int positionY, int width, int height, Color color) : CsGeoForm(positionX, positionY, width, height, color) 
    {
        /*
        public override void Draw(Graphics aGraphics)
        {

        }
        */
        public override void Draw(Graphics aGraphics)
        {
            if (Size.Width < 0)
            {
                Position.X += Size.Width;
                Size.Width = Math.Abs(Size.Width);
            }
            if (Size.Height < 0)
            {
                Position.Y += Size.Height;
                Size.Height = Math.Abs(Size.Height);
            }
            aGraphics.DrawRectangle(new Pen(color), new Rectangle(Position, Size));
        }
    }
}
