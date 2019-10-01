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
    public partial class salelogtab : UserControl
    {
        public salelogtab()
        {
            InitializeComponent();
            textBox2.Visible = false;
            txtsid.Visible = false;
            getdate.Visible = false;
            getdateto.Visible = false;
        }

        private void Salelogtab_Load(object sender, EventArgs e)
        {
            bunifuDatepicker1.FormatCustom = "dd/MM/yyyy";
            bunifuDatepicker2.FormatCustom = "dd/MM/yyyy";
            gettingiduser(textBox2.Text);
            FillGridLogs();
            
        }
        public void FillGridLogs()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string txtid = txtsid.Text;
            MySqlCommand gridfill = new MySqlCommand("SELECT * From Salelog", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        public void gettingiduser(string staffidget)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "Select staffid FROM Users WHERE username = '" + staffidget + "'";
            string typeaccount = Convert.ToString(cmd1.ExecuteScalar());
            txtsid.Text = typeaccount; 
            conn.Close();
        }
        public string ID
        {
            set { textBox2.Text = value; }
        }

        private void BunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            getdate.Text = bunifuDatepicker1.Value.ToString("yyyy/MM/dd");
            getdateto.Text = bunifuDatepicker2.Value.ToString("yyyy/MM/dd");
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string txtid = txtsid.Text;
            MySqlCommand gridfill = new MySqlCommand("SELECT * FROM Salelog WHERE date(dofsale) BETWEEN '"+ getdate.Text + "' and '"+ getdateto.Text + "'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(gridfill);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}
