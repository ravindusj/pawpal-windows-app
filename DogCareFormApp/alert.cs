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
    public partial class alert : Form
    {

        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\pawpal-formApp\DogCareFormApp\alertdata.mdf;Integrated Security=True");

        public alert()
        {
            InitializeComponent();
            this.Text = "Add Alert";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alert_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string label1 = textBox1.Text;
            string label2 = richTextBox1.Text;

            if (label1 == "" || label2 == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string Query = $"INSERT INTO [Table] (petID, alert) VALUES ('{label1}','{label2}')";
            SqlCommand cmd = new SqlCommand(Query, con1);
            {
                try { con1.Open(); cmd.ExecuteNonQuery(); MessageBox.Show("Alert Saved"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    con1.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
