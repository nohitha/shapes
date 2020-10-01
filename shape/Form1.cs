using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shape
{
    public partial class Form1 : Form
    {
        Rectangle waterPump1Ind= new Rectangle(10, 10, 50, 50);
        Rectangle waterPump2Ind = new Rectangle(10, 10, 50, 50);
        public Form1()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, waterPump1Ind);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Black);
            e.Graphics.DrawEllipse(myPen, 10, 10, 50, 50);
            //e.Graphics.FillEllipse(Brushes.Green, waterPump2Ind);
        }
    }
}
