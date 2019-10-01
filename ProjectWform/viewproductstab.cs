using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectWform
{
    public partial class viewproductstab : UserControl
    {
        public viewproductstab()
        {
            InitializeComponent();
        }
        public void fillproducts(string typename, string brandname)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand fillprot = new MySqlCommand("SELECT * FROM Products WHERE typename LIKE '%"+typename+"%' AND brandname LIKE '%" + brandname + "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(fillprot);
            DataTable showproducts = new DataTable();
            adapter.Fill(showproducts);
            fillproductsgridview.RowTemplate.Height = 90;
            fillproductsgridview.AllowUserToAddRows = false;
            fillproductsgridview.DataSource = showproducts;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)fillproductsgridview.Columns[8];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            fillproductsgridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            fillproductsgridview.Columns[0].Visible = false;
            fillproductsgridview.Columns[1].Visible = false;
            fillproductsgridview.Columns[6].Visible = false;
            fillproductsgridview.Columns[7].Visible = false;
            fillproductsgridview.Columns[9].Visible = false;
        }

        private void Viewproductstab_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT typename FROM Products GROUP BY typename", conn))
                {
                    MySqlDataReader myReader;
                    myReader = cmd.ExecuteReader();
                    List<string> readtypename = new List<string>();
                    while (myReader.Read())
                    {
                        readtypename.Add(myReader.GetString(0));
                    }
                    string[] givetypename = readtypename.ToArray<string>();
                    foreach (var showtype in givetypename)
                    {
                        bunifuDropdown1.AddItem(showtype);
                    }
                }
                using (var cmdbrand = new MySqlCommand("SELECT brandname FROM Products GROUP BY brandname", conn))
                {
                    MySqlDataReader myReader1;
                    myReader1 = cmdbrand.ExecuteReader();
                    List<string> readbrandname = new List<string>();
                    while (myReader1.Read())
                    {
                        readbrandname.Add(myReader1.GetString(0));
                    }
                    string[] givebrandname = readbrandname.ToArray<string>();
                    foreach (var showbrand in givebrandname)
                    {
                        bunifuDropdown2.AddItem(showbrand);
                    }
                }
                conn.Close();
            }
            fillproducts("", "");
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            fillproducts(bunifuDropdown1.selectedValue, "");
        }

        private void BunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            fillproducts("", bunifuDropdown2.selectedValue);
        }
    }
}
