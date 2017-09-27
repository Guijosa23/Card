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
            SolidBrush grayBrush = new SolidBrush(Color.LightGray);



            Thread.Sleep(1500);

            fg.DrawString("VALLADOLID", drawFont, blackBrush, 84, 210);
            fg.DrawString("VALLADOLID", drawFont, orangeBrush, 80, 208);
           
            Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.plaza_zorrilla;
            Refresh();

            Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.paseo;
            Refresh();
            Thread.Sleep(2500);

            drawFont = new Font("Georgia", 20, FontStyle.Bold);
            fg.DrawString("La capital de Castilla y Leon...", drawFont, blackBrush, 53, 215);
            fg.DrawString("La capital de Castilla y Leon...", drawFont, whiteBrush, 50, 215);

            Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.Black;
            Refresh();
            Thread.Sleep(1700);

            fg.DrawString("...y la casa del...", drawFont, redBrush, 117, 215);
            fg.DrawString("...y la casa del...", drawFont, whiteBrush, 114, 215);

            Thread.Sleep(1700);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.jose_zorrilla;
            Refresh();
            Thread.Sleep(2500);

            drawFont = new Font("Georgia", 26, FontStyle.Bold);
            fg.DrawString("REAL VALLADOLID C.F.", drawFont, purpleBrush, 25, 215);
            fg.DrawString("REAL VALLADOLID C.F.", drawFont, whiteBrush, 22, 215);

            Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.aficion;
            Refresh();
            Thread.Sleep(2500);

            Thread.Sleep(2500);
            BackgroundImage = null;
            BackgroundImage = Properties.Resources.grey;
            Refresh();
            fg.FillRectangle(purpleBrush, 170, 60, 125, 180);
            fg.FillRectangle(purpleBrush, 190, 60, 120, 180);

            //right sleeve
            fg.TranslateTransform(210, 105);
            fg.RotateTransform(140);
            fg.FillRectangle(purpleBrush, 0, 0, 90, 60);
            fg.ResetTransform();

            //left sleeve
            fg.TranslateTransform(330, 165);
            fg.RotateTransform(225);
            fg.FillRectangle(purpleBrush, 0, 0, 90, 60);
            fg.ResetTransform();

            fg.FillRectangle(whiteBrush, 187, 60, 20, 180);
            fg.FillRectangle(whiteBrush, 232, 60, 20, 180);
            fg.FillRectangle(whiteBrush, 277, 60, 20, 180);

            fg.FillEllipse(grayBrush, 202, 9, 83, 70);

            Thread.Sleep(1000);

            drawFont = new Font("Georgia", 13, FontStyle.Bold);
            Thread.Sleep(2500);
            fg.DrawString("[Fundado en 1928]", drawFont, blackBrush, 2, 180);
            Thread.Sleep(2500);
            fg.DrawString("[Ganador de 14", drawFont, blackBrush, 2, 200);
            fg.DrawString("trofeos nacionales]", drawFont, blackBrush, 0, 220);
            Thread.Sleep(2500);

            drawFont = new Font("Georgia", 18, FontStyle.Bold);
            fg.DrawString("EL MEJOR CLUB DEL MUNDO!!", drawFont, blackBrush, 50, 250);








        }

    }
}
