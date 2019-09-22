using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            showusername.Text = "Hi, " + gettinguser;
            dashboardtab1.BringToFront();
            checkaccess(gettinguser);
            levelvisible.Visible = false;
            if(levelvisible.Text == "1") // User
            {
                btnusersmana.Visible = false;
                btnproducts.Visible = false;
                btnmcus.Visible = false;
                btnmsalelog.Visible = false;
                btnpos.Visible = false;
            }
            else if(levelvisible.Text == "2") // Collaborators
            {
                btnusersmana.Visible = false;
                btnproducts.Visible = false; 
                btnmcus.Visible = false;
                btnmsalelog.Visible = false;
                btnpos.Visible = false;
            }
            else if (levelvisible.Text == "3") //Staff
            {
                btnusersmana.Visible = false;
                btnproducts.Visible = false;
                btnbuylogs.Visible = false;
                btnmcus.Visible = false;
                btnmsalelog.Visible = false;
            }
            else if (levelvisible.Text == "4") // Warechecker
            {

                btnusersmana.Visible = false;
                btnbuylogs.Visible = false;
                btnmcus.Visible = false;
                btnmsalelog.Visible = false;
                btnpos.Visible = false;
            }
            else if (levelvisible.Text == "5") // Admin
            {

            }
        }
      
        void checkaccess(string userhere)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select level from Users WHERE username = '"+ userhere + "'";
            int userdone = Convert.ToInt32(cmd.ExecuteScalar());
            levelvisible.Text = userdone.ToString();
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Select name FROM Config_levels WHERE level = "+userdone+"";
            string typeaccount = Convert.ToString(cmd1.ExecuteScalar());
            if(userdone == 1)
            {
                label3.Text = typeaccount;
                label3.ForeColor = Color.White;
            }
            else if (userdone == 2)
            {
                label3.Text = typeaccount;
                label3.ForeColor = Color.Yellow;
            }
            else if (userdone == 3)
            {
                label3.Text = typeaccount;
                label3.ForeColor = Color.Pink;
            }
            else if (userdone == 4)
            {
                label3.Text = typeaccount;
                label3.ForeColor = Color.LightGreen;
            }
            else if (userdone == 5)
            {
                label3.Text = typeaccount;
                label3.ForeColor = Color.Crimson;
            }

            conn.Close();
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

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 sistema = new Form1();
            sistema.ShowDialog();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btnmcus_Click(object sender, EventArgs e)
        {
            sslide1.Height = btnmcus.Height;
            sslide1.Top = btnmcus.Top;
            sslide2.Height = btnmcus.Height;
            sslide2.Top = btnmcus.Top;
            customerstab1.BringToFront();
        }
    }
}
