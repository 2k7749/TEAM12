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
    public partial class cruduserstab : UserControl
    {
        int id = 0;
        public cruduserstab()
        {
            InitializeComponent();
        }
        
        void GridFill(string SearchValue)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand gridfill = new MySqlCommand("SELECT * FROM Users WHERE CONCAT(staffid,username,staffphone) LIKE '%" + SearchValue + "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvUsers.RowTemplate.Height = 30;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dgvUsers.Columns[9];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.Columns[0].Visible = false;
        }

        private void Cruduserstab_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill("");
        }

        void Clear()
        {
            txtsuser.Text = txtstaffid.Text = txtspwd.Text = txtlevels.Text = txtsex.Text = txtposition.Text = txtphone.Text = txtaddress.Text = "";
            pictureBox1.Image = null;
            id = 0;
            btnDelete.Enabled = false;
        }

        private void DgvUsers_DoubleClick(object sender, EventArgs e)
        {
            if(dgvUsers.CurrentRow.Index != -1)
            {
                Byte[] img = (Byte[])dgvUsers.CurrentRow.Cells[9].Value;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                txtstaffid.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                txtsuser.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
                txtspwd.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
                txtlevels.Text = dgvUsers.CurrentRow.Cells[4].Value.ToString();
                txtsex.Text = dgvUsers.CurrentRow.Cells[5].Value.ToString();
                txtposition.Text = dgvUsers.CurrentRow.Cells[6].Value.ToString();
                txtphone.Text = dgvUsers.CurrentRow.Cells[7].Value.ToString();
                txtaddress.Text = dgvUsers.CurrentRow.Cells[8].Value.ToString();
                id = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                btnDelete.Enabled = Enabled;
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Users WHERE staffid = @staffid", conn);
            command.Parameters.Add("@staffid", MySqlDbType.VarChar).Value = txtstaffid.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Empty");
                Clear();
            }
            else
            {
                txtstaffid.Text = table.Rows[0][1].ToString();
                txtsuser.Text = table.Rows[0][2].ToString();
                txtspwd.Text = table.Rows[0][3].ToString();
                txtlevels.Text = table.Rows[0][8].ToString();
                txtsex.Text = table.Rows[0][4].ToString();
                txtposition.Text = table.Rows[0][5].ToString();
                txtphone.Text = table.Rows[0][6].ToString();
                txtaddress.Text = table.Rows[0][7].ToString();
                byte[] img = (byte[])table.Rows[0][9];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                MySqlCommand connafterrcmd = new MySqlCommand("UsersDeleteID", conn);
                connafterrcmd.CommandType = CommandType.StoredProcedure;
                connafterrcmd.Parameters.AddWithValue("_id", id);
                connafterrcmd.ExecuteNonQuery();
                Clear();
                GridFill("");
                conn.Close();
            }
        }
        private void Btnupdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("UPDATE Users SET staffid=@staffid,username=@username,password=@password,sex=@sex,position=@position,staffphone=@staffphone,address=@address,level=@level,image=@image WHERE id= @id", conn);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            command.Parameters.Add("@staffid", MySqlDbType.VarChar).Value = txtstaffid.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtsuser.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtspwd.Text;
            command.Parameters.Add("@sex", MySqlDbType.Int32).Value = txtsex.Text;
            command.Parameters.Add("@position", MySqlDbType.Int32).Value = txtposition.Text;
            command.Parameters.Add("@staffphone", MySqlDbType.Int32).Value = txtphone.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtaddress.Text;
            command.Parameters.Add("@level", MySqlDbType.Int32).Value = txtlevels.Text;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = img;
            ExecMyQuery(command, "Updated");
            conn.Close();
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            MySqlCommand command = new MySqlCommand("INSERT INTO Users (staffid, username, password, sex, position, staffphone, address, level, image) VALUES (@staffid, @username, @password, @sex, @position, @staffphone, @address, @level, @image)", conn);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            command.Parameters.Add("@staffid", MySqlDbType.VarChar).Value = txtstaffid.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtsuser.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtspwd.Text;
            command.Parameters.Add("@sex", MySqlDbType.Int32).Value = txtsex.Text;
            command.Parameters.Add("@position", MySqlDbType.Int32).Value = txtposition.Text;
            command.Parameters.Add("@staffphone", MySqlDbType.Int32).Value = txtphone.Text;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = txtaddress.Text;
            command.Parameters.Add("@level", MySqlDbType.Int32).Value = txtlevels.Text;
            command.Parameters.Add("@image", MySqlDbType.Blob).Value = img;
            ExecMyQuery(command, "Inserted");
            conn.Close();
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
            GridFill("");

        }

        private void Txtsearchbyid_TextChanged(object sender, EventArgs e)
        {
            GridFill(txtsearchbyid.Text);
        }

        private void Txtsearchbyid_Enter(object sender, EventArgs e)
        {
            if(txtsearchbyid.Text == "Keyword Here")
            {
                txtsearchbyid.Text = "";
                txtsearchbyid.ForeColor = Color.DeepPink;
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

        private void Btnchooseimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Choose Image FROM UR PC(*.JPG,*.PNG,*.GIF)|*.jpg;*.png;*.gif";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
        }
    }
}
