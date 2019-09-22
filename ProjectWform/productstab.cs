using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;

namespace ProjectWform
{
    public partial class productstab : UserControl
    {
        public productstab()
        {
            InitializeComponent();
        }
        private void Productstab_Load(object sender, EventArgs e)
        {
            FillGridProducts("");
        }
        public void FillGridProducts(string SearchValue)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand gridfill = new MySqlCommand("SELECT * FROM Products WHERE CONCAT(pid,pname,typeid,brandid) LIKE '%" +SearchValue+ "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
        }
        private void Btnchooseimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Choose Image FROM UR PC(*.JPG,*.PNG,*.GIF)|*.jpg;*.png;*.gif";
            if(of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            txtpid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtpname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttypeid.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtbranddid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtprice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            btndelete.Enabled = Enabled;
        }

        private void Btninsert_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("INSERT INTO Products (pid, pname, typeid, brandid, price, image) VALUES (@pid,@pname,@typeid,@brandid,@price,@image)", conn);
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = txtpid.Text;
            command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = txtpname.Text;
            command.Parameters.Add("@typeid", MySqlDbType.VarChar).Value = txttypeid.Text;
            command.Parameters.Add("@brandid", MySqlDbType.VarChar).Value = txtbranddid.Text;
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = txtprice.Text;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = img;
            ExecMyQuery(command, "Inserted");
        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg) { 
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
            FillGridProducts("");

        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("UPDATE Products SET pid=@pid, pname=@pname, typeid=@typeid, brandid=@brandid, price=@price, image=@image WHERE id=@id", conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = txtpid.Text;
            command.Parameters.Add("@pname", MySqlDbType.VarChar).Value = txtpname.Text;
            command.Parameters.Add("@typeid", MySqlDbType.VarChar).Value = txttypeid.Text;
            command.Parameters.Add("@brandid", MySqlDbType.VarChar).Value = txtbranddid.Text;
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = txtprice.Text;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = img;
            ExecMyQuery(command, "Updated");
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM Products WHERE id = @id", conn);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ExecMyQuery(command, "Deleted");
            Clearman();
        }
        private void Txtkeyword_TextChanged(object sender, EventArgs e)
        {
            FillGridProducts(txtkeyword.Text);
        }
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Products WHERE pid = @pid", conn);
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = txtpid.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
           if(table.Rows.Count <= 0)
            {
                MessageBox.Show("Empty");
                Clearman();
            }
            else
            {
                txtpid.Text = table.Rows[0][1].ToString();
                txtpname.Text = table.Rows[0][2].ToString();
                txttypeid.Text = table.Rows[0][3].ToString();
                txtbranddid.Text = table.Rows[0][4].ToString();
                txtprice.Text = table.Rows[0][5].ToString();
                byte[] img = (byte[])table.Rows[0][6];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            Clearman();
        }
        public void Clearman()
        {
            txtpid.Text = "";
            txtpname.Text = "";
            txttypeid.Text = "";
            txtbranddid.Text = "";
            txtprice.Text = "";
            pictureBox1.Image = null;   
            btndelete.Enabled = false;
        }

        private void Txtkeyword_Enter(object sender, EventArgs e)
        {
            if (txtkeyword.Text == "Keyword Here")
            {
                txtkeyword.Text = "";
                txtkeyword.ForeColor = Color.Crimson;
            }
        }
        private void Txtkeyword_Leave_1(object sender, EventArgs e)
        {
            if (txtkeyword.Text == "")
            {
                txtkeyword.Text = "Keyword Here";
                txtkeyword.ForeColor = Color.Gainsboro;
            }
        }
    }
}
