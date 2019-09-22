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
    public partial class customerstab : UserControl
    {
        public customerstab()
        {
            InitializeComponent();
        }

        private void Customerstab_Load(object sender, EventArgs e)
        {
            FillGridCus("");
        }
        public void FillGridCus(string SearchValue)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand gridfill = new MySqlCommand("SELECT * FROM Customer WHERE CONCAT(cid,cname) LIKE '%" + SearchValue + "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvcustomers.RowTemplate.Height = 30;
            dgvcustomers.AllowUserToAddRows = false;
            dgvcustomers.DataSource = table;
            dgvcustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcustomers.Columns[0].Visible = false;
        }
        public void Clearman()
        {
            txtcid.Text = "";
            txtcname.Text = "";
            txtcphone.Text = "";
            txtcaddress.Text = "";
            txtrepoints.Text = "";
            btndelete.Enabled = false;
        }
        private void Dgvcustomers_DoubleClick(object sender, EventArgs e)
        {
            txtcid.Text = dgvcustomers.CurrentRow.Cells[1].Value.ToString();
            txtcname.Text = dgvcustomers.CurrentRow.Cells[2].Value.ToString();
            txtcphone.Text = dgvcustomers.CurrentRow.Cells[3].Value.ToString();
            txtcaddress.Text = dgvcustomers.CurrentRow.Cells[4].Value.ToString();
            txtrepoints.Text = dgvcustomers.CurrentRow.Cells[5].Value.ToString();
            btndelete.Enabled = Enabled;
        }

        private void Btninsert_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO Customer (cid,cname,cphone,caddress,repoints) VALUES (@cid,@cname,@cphone,@caddress,@repoints)", conn);
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = txtcid.Text;
            command.Parameters.Add("@cname", MySqlDbType.VarChar).Value = txtcname.Text;
            command.Parameters.Add("@cphone", MySqlDbType.VarChar).Value = txtcphone.Text;
            command.Parameters.Add("@caddress", MySqlDbType.VarChar).Value = txtcaddress.Text;
            command.Parameters.Add("@repoints", MySqlDbType.Int32).Value = txtrepoints.Text;
            ExecMyQuery(command, "Inserted");
        }
        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("Fail");
            }
            conn.Close();
            FillGridCus("");

        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("UPDATE Customer SET cid=@cid, cname=@cname, cphone=@cphone, caddress=@caddress, repoints=@repoints WHERE id=@id", conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dgvcustomers.CurrentRow.Cells[0].Value.ToString();
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = txtcid.Text;
            command.Parameters.Add("@cname", MySqlDbType.VarChar).Value = txtcname.Text;
            command.Parameters.Add("@cphone", MySqlDbType.VarChar).Value = txtcphone.Text;
            command.Parameters.Add("@caddress", MySqlDbType.VarChar).Value = txtcaddress.Text;
            command.Parameters.Add("@repoints", MySqlDbType.Int32).Value = txtrepoints.Text;
            ExecMyQuery(command, "Updated");
            conn.Close();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM Customer WHERE id = @id", conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dgvcustomers.CurrentRow.Cells[0].Value.ToString();
            ExecMyQuery(command, "Deleted");
            Clearman();
            conn.Close();
        }

        private void Txtsearchbyid_TextChanged(object sender, EventArgs e)
        {
            FillGridCus(txtsearchbyid.Text);
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Customer WHERE cid = @cid", conn);
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = txtcid.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Empty");
                Clearman();
            }
            else
            {
                txtcid.Text = table.Rows[0][1].ToString();
                txtcname.Text = table.Rows[0][2].ToString();
                txtcphone.Text = table.Rows[0][3].ToString();
                txtcaddress.Text = table.Rows[0][4].ToString();
                txtrepoints.Text = table.Rows[0][5].ToString();
            }
            conn.Close();
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            Clearman();
        }

        private void Txtsearchbyid_Enter(object sender, EventArgs e)
        {
            if (txtsearchbyid.Text == "Keyword Here")
            {
                txtsearchbyid.Text = "";
                txtsearchbyid.ForeColor = Color.Crimson;
            }
        }

        private void Txtsearchbyid_Leave(object sender, EventArgs e)
        {
            if (txtsearchbyid.Text == "")
            {
                txtsearchbyid.Text = "Keyword Here";
                txtsearchbyid.ForeColor = Color.Gainsboro;
            }
        }
    }
}
