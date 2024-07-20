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
        string con1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\pawpal-formApp\DogCareFormApp\DogRegForm.mdf;Integrated Security=True";
        SqlConnection sqlCon;


        public UserControlDOGlist()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(con1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(con1))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Dog", sqlCon);
                    DataTable dataTable = new DataTable();
                    sqlDa.Fill(dataTable);

                    guna2DataGridView1.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions here
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other potential exceptions here
                MessageBox.Show("An unexpected error occurred: " + ex.Message);

            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(con1))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Dog", sqlCon);
                    DataTable dataTable = new DataTable();
                    sqlDa.Fill(dataTable);

                    guna2DataGridView1.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions here
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other potential exceptions here
                MessageBox.Show("An unexpected error occurred: " + ex.Message);

            }
        

    }
}
}
