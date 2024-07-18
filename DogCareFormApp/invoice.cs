using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace test_2_paw_pal
{
    public class Invoice
    {
        public string PetID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public List<string> AdditionalTreatments { get; set; } = new List<string>();
        public List<decimal> TreatmentCosts { get; set; } = new List<decimal>();
        public decimal DailyRate { get; set; } = 50.0m;

        public decimal CalculateTotalCost()
        {
            int totalDays = (CheckOutDate - CheckInDate).Days;
            decimal totalCost = totalDays * DailyRate;
            for (int i = 0; i < TreatmentCosts.Count; i++)
            {
                totalCost += TreatmentCosts[i];
            }
            return totalCost;
        }

        public void GeneratePdfInvoice(string filePath)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Invoice";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12);

            gfx.DrawString("Dog Care Center", font, XBrushes.Black, new XRect(0, 0, page.Width, 50), XStringFormats.Center);
            gfx.DrawString($"Pet ID: {PetID}", font, XBrushes.Black, new XRect(40, 80, page.Width, 20), XStringFormats.TopLeft);
            gfx.DrawString($"Check-In Date: {CheckInDate.ToShortDateString()}", font, XBrushes.Black, new XRect(40, 110, page.Width, 20), XStringFormats.TopLeft);
            gfx.DrawString($"Check-Out Date: {CheckOutDate.ToShortDateString()}", font, XBrushes.Black, new XRect(40, 140, page.Width, 20), XStringFormats.TopLeft);

            gfx.DrawString("Additional Treatments:", font, XBrushes.Black, new XRect(40, 170, page.Width, 20), XStringFormats.TopLeft);

            int yOffset = 200;
            for (int i = 0; i < AdditionalTreatments.Count; i++)
            {
                gfx.DrawString($"{AdditionalTreatments[i]} - {TreatmentCosts[i]:C}", font, XBrushes.Black, new XRect(60, yOffset, page.Width, 20), XStringFormats.TopLeft);
                yOffset += 30;
            }

            decimal totalCost = CalculateTotalCost();
            gfx.DrawString($"Total Cost: {totalCost:C}", font, XBrushes.Black, new XRect(40, yOffset, page.Width, 20), XStringFormats.TopLeft);

            document.Save(filePath);
        }
    }
}