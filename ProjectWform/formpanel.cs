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
    public partial class formpanel : Form
    {
        int mov;
        int movX;
        int movY;
        public formpanel(string gettinguser)
        {
            InitializeComponent();
            sslide1.Height = btndashboard.Height;
            sslide1.Top = btndashboard.Top;
            sslide2.Height = btndashboard.Height;
            sslide2.Top = btndashboard.Top;
            showusername.Text = "Hi, "+gettinguser;
            dashboardtab1.BringToFront();
        }
        private void Formpanel_Load(object sender, EventArgs e)
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
        private void Button1_Click(object sender, EventArgs e)
        {
            sslide1.Height = btndashboard.Height;
            sslide1.Top = btndashboard.Top;
            sslide2.Height = btndashboard.Height;
            sslide2.Top = btndashboard.Top;
            dashboardtab1.BringToFront();
        }

        private void Btnproducts_Click(object sender, EventArgs e)
        {
            sslide1.Height = btnproducts.Height;
            sslide1.Top = btnproducts.Top;
            sslide2.Height = btnproducts.Height;
            sslide2.Top = btnproducts.Top;
            productstab1.BringToFront();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnusersmana_Click(object sender, EventArgs e)
        {
            sslide1.Height = btnusersmana.Height;
            sslide1.Top = btnusersmana.Top;
            sslide2.Height = btnusersmana.Height;
            sslide2.Top = btnusersmana.Top;
            btnchooseimage.BringToFront();
        }

        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
