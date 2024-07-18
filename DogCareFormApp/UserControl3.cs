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
    public partial class UserControl1 : UserControl
    {
        private SqlConnection con; // Add a private field for the SqlConnection

        public UserControl1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\pawpal-formApp\DogCareFormApp\Database1.mdf;Integrated Security=True"); // Initialize the SqlConnection
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label6 = textBox6.Text;
            string label2 = textBox2.Text;
            string label5 = textBox5.Text;
            string label4 = textBox4.Text;
            string label8 = textBox1.Text;
            if (label6 == "" || label2 == "" || label5 == "" || label4 == "" || label8 == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string Query = $"INSERT INTO TableInt (label6, label2,label5,label4,label8) VALUES ('{label6}','{label2}','{label5}','{label4}','{label8}')";
            SqlCommand cmd = new SqlCommand(Query, con);
            {
                try { con.Open(); cmd.ExecuteNonQuery(); MessageBox.Show("Saved"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}