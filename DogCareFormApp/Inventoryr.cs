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
    public partial class Inventoryr : UserControl

    {
        SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\pawpal-formApp\DogCareFormApp\Database1.mdf;Integrated Security=True");
        public Inventoryr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ProductID = Product.Text;
            string NOP = NOPT.Text;
            string Cate = Category.Text;
            string Quantity = Qt.Text;
            string Date = DT.Text;
            if (ProductID == "" || NOP == "" || Cate == "" || Quantity == "" || Date == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string Query = $"INSERT INTO TableInt (ProductID, NOP,Cate,Quantity,Date) VALUES ('{ProductID}','{NOP}','{Cate}','{Quantity}','{Date}')";
            SqlCommand cmd = new SqlCommand(Query, con2);
            {
                try { con2.Open(); cmd.ExecuteNonQuery(); MessageBox.Show("Saved"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    con2.Close();
                }
            }
        }

        private void Product_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    con2.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [TableInt]", con2);
                    DataTable dataTable = new DataTable();
                    sqlDa.Fill(dataTable);
                    guna2DataGridView4.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con2.Close();
            }
        }

        private void guna2DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Category_TextChanged(object sender, EventArgs e)
        {

        }

        private void Qt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NOPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductID_Click(object sender, EventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void Cate_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_Click(object sender, EventArgs e)
        {

        }

        private void NOP_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DT_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                {
                    con2.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [TableInt]", con2);
                    DataTable dataTable = new DataTable();
                    sqlDa.Fill(dataTable);
                    guna2DataGridView4.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con2.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string ProductID = Product.Text;
            string NOP = NOPT.Text;
            string Cate = Category.Text;
            string Quantity = Qt.Text;
            string Date = DT.Text;
            if (ProductID == "" || NOP == "" || Cate == "" || Quantity == "" || Date == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string Query = $"INSERT INTO TableInt (ProductID, NOP,Cate,Quantity,Date) VALUES ('{ProductID}','{NOP}','{Cate}','{Quantity}','{Date}')";
            SqlCommand cmd = new SqlCommand(Query, con2);
            {
                try { con2.Open(); cmd.ExecuteNonQuery(); MessageBox.Show("Saved"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    con2.Close();
                }
            }
        
    }
    }
}
