namespace CsGeoFormsForms
{
    public partial class Form1 : Form
    {
        Point coordinates;
        List<CsGeoForm> forms = [];

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateCanvas()
        {
            using Graphics gfx = pbx_Canvas.CreateGraphics();
            gfx.Clear(Color.White);
            foreach (CsGeoForm f in forms)
                f.Draw(gfx);
        }

        private void Pbx_Canvas_Click(object sender, EventArgs e)
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
                                forms.Add(
                                    new CsRectangle(coordinates.X,
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
                                forms.Add(
                                    new CsEllipse(coordinates.X,
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
                                forms.Add(
                                    new CsLine(coordinates.X,
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
                UpdateCanvas();
            }
        }

        private void Pbx_Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            gfx.Clear(Color.White);
            foreach (CsGeoForm f in forms)
                f.Draw(gfx);
        }
    }
}
