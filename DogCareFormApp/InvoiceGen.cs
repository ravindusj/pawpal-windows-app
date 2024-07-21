using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DogCareFormApp
{
    public partial class InvoiceGen : Form
    {
        public InvoiceGen()
        {
            InitializeComponent();
            this.Text = "Print Invoice";
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice
            {
                PetID = txtPetID.Text,
                CheckInDate = dtpCheckIn.Value,
                CheckOutDate = dtpCheckOut.Value,
                AdditionalTreatments = new List<string>(),
                TreatmentCosts = new List<decimal>()
            };

            foreach (var item in lstTreatments.Items)
            {
                invoice.AdditionalTreatments.Add(item.ToString());
            }

            foreach (var item in lstTreatmentCosts.Items)
            {
                if (decimal.TryParse(item.ToString(), out decimal cost))
                {
                    invoice.TreatmentCosts.Add(cost);
                }
            }

            invoice.GeneratePdfInvoice();
        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            string treatment = Prompt.ShowDialog("Enter Treatment:", "Add Treatment");
            if (!string.IsNullOrEmpty(treatment))
            {
                lstTreatments.Items.Add(treatment);
            }
        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            string cost = Prompt.ShowDialog("Enter Cost:", "Add Cost");
            if (decimal.TryParse(cost, out decimal result))
            {
                lstTreatmentCosts.Items.Add(result.ToString("F2"));
            }
            else
            {
                MessageBox.Show("Please enter a valid decimal number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPetID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateInvoice_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                Invoice invoice = new Invoice
                {
                    PetID = txtPetID.Text,
                    CheckInDate = dtpCheckIn.Value,
                    CheckOutDate = dtpCheckOut.Value,
                    AdditionalTreatments = new List<string>(),
                    TreatmentCosts = new List<decimal>()
                };

                
                foreach (var item in lstTreatments.Items)
                {
                    invoice.AdditionalTreatments.Add(item.ToString());
                }

                foreach (var item in lstTreatmentCosts.Items)
                {
                    if (decimal.TryParse(item.ToString(), out decimal cost))
                    {
                        invoice.TreatmentCosts.Add(cost);
                    }
                }

              
                invoice.GeneratePdfInvoice();
            }
            catch (Exception ex)
            {
              
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstTreatmentCosts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
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

        private void dtpCheckIn_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void lstTreatments_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice
            {
                PetID = txtPetID.Text,
                CheckInDate = dtpCheckIn.Value,
                CheckOutDate = dtpCheckOut.Value,
                AdditionalTreatments = new List<string>(),
                TreatmentCosts = new List<decimal>()
            };

            foreach (var item in lstTreatments.Items)
            {
                invoice.AdditionalTreatments.Add(item.ToString());
            }

            foreach (var item in lstTreatmentCosts.Items)
            {
                if (decimal.TryParse(item.ToString(), out decimal cost))
                {
                    invoice.TreatmentCosts.Add(cost);
                }
            }

            invoice.GeneratePdfInvoice();
        }

        private void InvoiceGen_Load(object sender, EventArgs e)
        {

        }
    }
}
