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
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\pawpal-formApp\DogCareFormApp\Database1.mdf;Integrated Security=True");
        public Inventoryr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand(Query, con1);
            {
                try { con1.Open(); cmd.ExecuteNonQuery(); MessageBox.Show("Saved"); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    con1.Close();
                }
            }
        }
    }
}
