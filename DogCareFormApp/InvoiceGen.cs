using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_2_paw_pal;

namespace DogCareFormApp
{
    public partial class InvoiceGen : Form
    {
        public InvoiceGen()
        {
            InitializeComponent();
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

            string filePath = "invoice.pdf";
            invoice.GeneratePdfInvoice(filePath);
            MessageBox.Show($"Invoice generated at: {filePath}", "Invoice Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPetID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}