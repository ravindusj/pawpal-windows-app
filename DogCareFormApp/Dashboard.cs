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
    public partial class Dashboard : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\pawpal-formApp\DogCareFormApp\alertdata.mdf;Integrated Security=True");
        SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\pawpal-formApp\DogCareFormApp\BookingDatabase.mdf;Integrated Security=True");


        public Dashboard()
        {
            InitializeComponent();
            this.Text = "Paw-Pal Dog Care Center";
        }

        private void guna2VProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Landing f1 = new Landing();
            f1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Landing f2 = new Landing();
            f2.Show();
        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Landing f2 = new Landing();
            f2.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void inventorybutton_Click(object sender, EventArgs e)
        {
            inventoryr1.BringToFront();
        }

        private void bookinbutton_Click(object sender, EventArgs e)
        {
            bookingDash1.BringToFront();
        }

        private void dashbutton1_Click(object sender, EventArgs e)
        {
            new11.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Regform form = new Regform();
            form.Show();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            reset_settings1.BringToFront();
        }

        private void inventoryr1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            alert form = new alert();
            form.Show();

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

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Landing landing = new Landing();
            this.Hide();
            landing.Show();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            alert form = new alert();
            form.Show();

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            alert form = new alert();
            form.Show();

            try
            {
                {
                    con1.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT PetID,Alert FROM [Table]", con1);
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

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                {
                    con2.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT petID,date FROM [Table]", con2);
                    DataTable dataTable = new DataTable();
                    sqlDa.Fill(dataTable);
                    guna2DataGridView2.DataSource = dataTable;
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            userControlDOGlist1.BringToFront();
        }

    }
}
