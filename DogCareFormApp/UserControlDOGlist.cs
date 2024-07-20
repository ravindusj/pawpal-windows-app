using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
namespace DogCareFormApp
{
    public partial class UserControlDOGlist : UserControl
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Pawpal-final\DogCareFormApp\Dog.mdf;Integrated Security=True");


        public UserControlDOGlist()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    con1.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Dog", con1);
                    DataTable dataTable = new DataTable();
                    sqlDa.Fill(dataTable);
                    guna2DataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con1.Close();
            }


        }
}
}
