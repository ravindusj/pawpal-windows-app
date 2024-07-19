using System;
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
    public partial class reset_settings : UserControl
    {
        public reset_settings()
        {
            InitializeComponent();
        }

        private void CurrentUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void savechanges_Click(object sender, EventArgs e)
        {
            string currentUsername = CurrentUsername.Text;
            string currentPassword = CurrentPassword.Text;
            string newUsername = NewUsername.Text;
            string newPassword = NewPassword.Text;

            // Validate the current username and password
            if (currentUsername != UserCredentials.Username || currentPassword != UserCredentials.Password)
            {
                MessageBox.Show("Current username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the new username and password
            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("New username and password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the credentials
            UserCredentials.Username = newUsername;
            UserCredentials.Password = newPassword;

            MessageBox.Show("Username and password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
