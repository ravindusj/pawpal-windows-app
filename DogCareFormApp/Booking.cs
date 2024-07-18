using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogCareFormApp
{
    public partial class Booking : Form
    {

        private SqlConnection con;
        public Booking()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\pawpal-formApp\DogCareFormApp\BookingDatabase.mdf;Integrated Security=True");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string label1 = textBox1.Text;
            string label2 = textBox2.Text;
            string label3 = textBox3.Text;
            string label4 = textBox4.Text;
            string label5 = textBox5.Text;
            string label6 = textBox5.Text;

            if (label1 == "" || label2 == "" || label3 == "" || label4 == "" || label5 == "" || label6 == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            string Query = $"INSERT INTO TableInt (label1, label2,label3,label4,label5,label6) VALUES ('{label1}','{label2}','{label3}','{label4}','{label5}','{label6}')";
            SqlCommand cmd = new SqlCommand(Query, con);
            {
                try { con.Open(); cmd.ExecuteNonQuery(); MessageBox.Show("Booking Added"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
