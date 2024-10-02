namespace CsGeoFormsForms
{
    public partial class Form1 : Form
    {
        Point coordinates;
        List<CsEllipse> csEllipses = [];
        List<CsRectangle> csRects = [];
        List<CsLine> csLines = [];
        bool firstLaunch = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void updateCanvas()
        {
            using (Graphics gfx = pbx_Canvas.CreateGraphics())
            {
                gfx.Clear(Color.White);
                foreach (CsLine line in csLines)
                { line.Draw(gfx); }
                foreach (CsEllipse c in csEllipses)
                { c.Draw(gfx); }
                foreach (CsRectangle r in csRects)
                { r.Draw(gfx); }
            }
        }

        private void pbx_Canvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
            {
                coordinates = me.Location;
            }
            else if (me.Button == MouseButtons.Right && coordinates != new Point())
            {
                Point coordinates2 = me.Location;
                Color[] colors = [Color.Black, Color.Red, Color.Green, Color.Blue, Color.Purple];
                if (cmb_Color.SelectedIndex != -1)
                {
                    switch (cmb_Shape.SelectedIndex)
                    {
                        case 0:
                            using (Graphics gfx = pbx_Canvas.CreateGraphics())
                            {
                                csRects.Add(
                                    new(coordinates.X,
                                    coordinates.Y,
                                    coordinates2.X - coordinates.X,
                                    coordinates2.Y - coordinates.Y,
                                    colors[cmb_Color.SelectedIndex])
                                    );
                            }
                            break;
                        case 1:
                            using (Graphics gfx = pbx_Canvas.CreateGraphics())
                            {
                                csEllipses.Add(
                                    new(coordinates.X,
                                    coordinates.Y,
                                    coordinates2.X - coordinates.X,
                                    coordinates2.Y - coordinates.Y,
                                    colors[cmb_Color.SelectedIndex])
                                    );
                            }
                            break;
                        case 2:
                            using (Graphics gfx = pbx_Canvas.CreateGraphics())
                            {
                                csLines.Add(
                                    new(coordinates.X,
                                    coordinates.Y,
                                    coordinates2.X - coordinates.X,
                                    coordinates2.Y - coordinates.Y,
                                    colors[cmb_Color.SelectedIndex])
                                    );
                            }
                            break;
                        default:
                            MessageBox.Show("No Shape selected");
                            break;
                    }
                    coordinates = new Point();
                }
                else
                {
                    MessageBox.Show("No Color selected");
                }
                updateCanvas();
            }
        }

        private void pbx_Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            gfx.Clear(Color.White);
            foreach (CsLine line in csLines)
                line.Draw(gfx);
            foreach (CsEllipse c in csEllipses)
                c.Draw(gfx);
            foreach (CsRectangle r in csRects)
                r.Draw(gfx);
        }
    }
}
