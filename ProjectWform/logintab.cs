using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectWform
{
    public partial class logintab : UserControl
    {
        public logintab()
        {
            InitializeComponent();
        }
       
        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string user = "hipcute"; //txtuser.Text;
            string pass = "tdnlkd";//txtpwd.Text;
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlDataAdapter query = new MySqlDataAdapter("select count(*) from Users where username = '" +user+ "' and password = '" +pass+ "'", conn);
            DataTable filldata = new DataTable();
            formpanel panelh = new formpanel(txtuser.Text);
            query.Fill(filldata);
            if (filldata.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login success!!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((Form1)this.TopLevelControl).Hide();
                panelh.Show();
            }
            else
            {
                MessageBox.Show("Login Failed", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txtpwd_Enter(object sender, EventArgs e)
        {
            if (txtpwd.HintText == "Type your pass")
            {
                txtpwd.Text = "";
                txtpwd.isPassword = true;
            }
        }

        private void Txtpwd_Leave(object sender, EventArgs e)
        {
            if (txtpwd.Text == "")
            {
                txtpwd.Text = "Type your pass";
                txtpwd.isPassword = false;
            }
        }

        private void Txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpwd.Focus();
            }
        }

        private void Txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtuser.Focus();
            }
        }
    }
}
