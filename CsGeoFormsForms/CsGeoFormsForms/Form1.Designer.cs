namespace CsGeoFormsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbx_Canvas = new PictureBox();
            cmb_Shape = new ComboBox();
            cmb_Color = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbx_Canvas).BeginInit();
            SuspendLayout();
            // 
            // pbx_Canvas
            // 
            pbx_Canvas.Location = new Point(151, 0);
            pbx_Canvas.Name = "pbx_Canvas";
            pbx_Canvas.Size = new Size(649, 453);
            pbx_Canvas.TabIndex = 0;
            pbx_Canvas.TabStop = false;
            pbx_Canvas.Click += Pbx_Canvas_Click;
            pbx_Canvas.Paint += Pbx_Canvas_Paint;
            // 
            // cmb_Shape
            // 
            cmb_Shape.FormattingEnabled = true;
            cmb_Shape.Items.AddRange(new object[] { "Rechteck", "Ellipse", "Linie" });
            cmb_Shape.Location = new Point(0, 0);
            cmb_Shape.Name = "cmb_Shape";
            cmb_Shape.Size = new Size(145, 23);
            cmb_Shape.TabIndex = 1;
            // 
            // cmb_Color
            // 
            cmb_Color.FormattingEnabled = true;
            cmb_Color.Items.AddRange(new object[] { "Schwarz", "Rot", "Grün", "Blau", "Lila" });
            cmb_Color.Location = new Point(0, 29);
            cmb_Color.Name = "cmb_Color";
            cmb_Color.Size = new Size(145, 23);
            cmb_Color.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmb_Color);
            Controls.Add(cmb_Shape);
            Controls.Add(pbx_Canvas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbx_Canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbx_Canvas;
        private ComboBox cmb_Shape;
        private ComboBox cmb_Color;
    }
}
