using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Georgia", 34, FontStyle.Bold);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush purpleBrush = new SolidBrush(Color.Purple);
            


            // Thread.Sleep(1500);

            fg.DrawString("VALLADOLID", drawFont, blackBrush, 84, 210);
            fg.DrawString("VALLADOLID", drawFont, orangeBrush, 80, 208);
           
            //Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.plaza_zorrilla;
            Refresh();

            //Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.paseo;
            Refresh();
            //Thread.Sleep(2500);

            drawFont = new Font("Georgia", 20, FontStyle.Bold);
            fg.DrawString("La capital de Castilla y Leon...", drawFont, blackBrush, 53, 215);
            fg.DrawString("La capital de Castilla y Leon...", drawFont, whiteBrush, 50, 215);

            //Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.Black;
            Refresh();
            //Thread.Sleep(1700);

            fg.DrawString("...y la casa del...", drawFont, redBrush, 117, 215);
            fg.DrawString("...y la casa del...", drawFont, whiteBrush, 114, 215);

            //Thread.Sleep(1700);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.jose_zorrilla;
            Refresh();
            //Thread.Sleep(2500);

            drawFont = new Font("Georgia", 26, FontStyle.Bold);
            fg.DrawString("REAL VALLADOLID C.F.", drawFont, purpleBrush, 25, 215);
            fg.DrawString("REAL VALLADOLID C.F.", drawFont, whiteBrush, 22, 215);

            //Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.aficion;
            Refresh();
            //Thread.Sleep(2500);

           // Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.white;
            Refresh();
            fg.FillRectangle(purpleBrush, 30, 70, 50, 100);
            fg.TranslateTransform(200, 50);
            fg.RotateTransform(90);//
            fg.FillRectangle(purpleBrush, 30, 70, 50, 100);
            fg.ResetTransform();










        }

    }
}
