using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyLandscape {
	public partial class Form1 : Form {
		Graphics graphics;
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			Pen pen = new Pen(Brushes.BlueViolet, 8);
            // Упростите код с помощью цикла for
            for (int i= 20; i < 380;i=i+60)
                
            {
                
                graphics.DrawLine(pen, i, 40 , i+60, 80); // первая пара чисел - координаты начала отрезка, вторая - координаты конца
             
            }
			
		}
    }
}
