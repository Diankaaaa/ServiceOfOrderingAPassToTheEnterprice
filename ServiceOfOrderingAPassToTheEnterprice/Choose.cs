using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceOfOrderingAPassToTheEnterprice
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
            //using(Pen Pen = new Pen(Color.AntiqueWhite, 2.56f))
            //{
            //    Pen.Alignment = PenAlignment.Center;
            //    e.Graphics.DrawPath(Pen, GraphicsPath);
            //}
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            

            //this.Region = new Region(GraphicsPath);
        }
    }

    class But : Button
    {
        GraphicsPath Round(RectangleF Rect, int Raduis)
        {
            float Radius2 = Raduis / 2f;
            GraphicsPath GraphicsPath = new GraphicsPath();

            GraphicsPath.AddArc(Rect.X, Rect.Y, Raduis, Raduis, 180, 90);
            GraphicsPath.AddLine(Rect.X + Radius2, Rect.Y, Rect.Width - Radius2, Rect.Y);
            GraphicsPath.AddArc(Rect.X + Rect.Width - Raduis, Rect.Y, Raduis, Raduis, 270, 90);
            GraphicsPath.AddLine(Rect.Width, Rect.Y + Radius2, Rect.Width, Rect.Height - Radius2);

            GraphicsPath.AddArc(Rect.X + Rect.Width - Raduis, Rect.Y + Rect.Height - Raduis, Raduis, Raduis, 0, 90);
            GraphicsPath.AddLine(Rect.Width - Radius2, Rect.Height, Rect.X + Radius2, Rect.Height);
            GraphicsPath.AddArc(Rect.X, Rect.Y + Rect.Height - Raduis, Raduis, Raduis, 90, 90);
            GraphicsPath.AddLine(Rect.X, Rect.Height - Radius2, Rect.X, Rect.Y + Radius2);

            GraphicsPath.CloseFigure();
            return GraphicsPath;

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            RectangleF Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphicsPath = Round(Rect, 100);


            this.Region = new Region(GraphicsPath);
        }
    }
}
