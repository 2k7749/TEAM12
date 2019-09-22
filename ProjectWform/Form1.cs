using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWform
{
 
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        public Form1()
        {
        InitializeComponent();
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.White;
            logintab1.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }
       

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Crimson;
            button1.ForeColor = Color.White;
            btnctv.BackColor = Color.White;
            btnctv.ForeColor = Color.Black;
            btnforget.BackColor = Color.White;
            btnforget.ForeColor = Color.Black;
            logintab1.BringToFront();
        }

        private void Btnctv_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            btnctv.BackColor = Color.Crimson;
            btnctv.ForeColor = Color.White;
            btnforget.BackColor = Color.White;
            btnforget.ForeColor = Color.Black;
            ctvtab1.BringToFront();
        }

       

        private void Btnforget_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            btnctv.BackColor = Color.White;
            btnctv.ForeColor = Color.Black;
            btnforget.BackColor = Color.Crimson;
            btnforget.ForeColor = Color.White;
            forgetpwdtab1.BringToFront();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
