using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogCareFormApp
{
    public partial class BookingDash : UserControl
    {

        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Pawpal-final\DogCareFormApp\BookingDatabase.mdf;Integrated Security=True");

        public BookingDash()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Booking bookingForm = new Booking();
            bookingForm.Show();
        }

        private void Invoice_Click(object sender, EventArgs e)
        {
            InvoiceGen invoiceGen = new InvoiceGen();
            invoiceGen.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    con1.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [Table]", con1);
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

        private void BookingDash_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InvoiceGen invoiceGen = new InvoiceGen();
            invoiceGen.Show();
        }

    }
}
