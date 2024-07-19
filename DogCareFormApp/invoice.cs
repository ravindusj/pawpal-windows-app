using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;

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

    public void GeneratePdfInvoice()
    {
        try
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pdfFilePath = System.IO.Path.Combine(documentsPath, "invoice.pdf");

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Invoice";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12);
            gfx.DrawString("Dog Care Center", font, XBrushes.Black, new XRect(0, 0, page.Width.Point, 50), XStringFormats.Center);
            gfx.DrawString($"Pet ID: {PetID}", font, XBrushes.Black, new XRect(40, 80, page.Width.Point, 20), XStringFormats.TopLeft);
            gfx.DrawString($"Check-In Date: {CheckInDate.ToShortDateString()}", font, XBrushes.Black, new XRect(40, 110, page.Width.Point, 20), XStringFormats.TopLeft);
            gfx.DrawString($"Check-Out Date: {CheckOutDate.ToShortDateString()}", font, XBrushes.Black, new XRect(40, 140, page.Width.Point, 20), XStringFormats.TopLeft);
            gfx.DrawString("Additional Treatments:", font, XBrushes.Black, new XRect(40, 170, page.Width.Point, 20), XStringFormats.TopLeft);
            int yOffset = 200;
            for (int i = 0; i < AdditionalTreatments.Count; i++)
            {
                gfx.DrawString($"{AdditionalTreatments[i]} - {TreatmentCosts[i]:C}", font, XBrushes.Black, new XRect(60, yOffset, page.Width.Point, 20), XStringFormats.TopLeft);
                yOffset += 30;
            }
            decimal totalCost = CalculateTotalCost();
            gfx.DrawString($"Total Cost: {totalCost:C}", font, XBrushes.Black, new XRect(40, yOffset, page.Width.Point, 20), XStringFormats.TopLeft);
            document.Save(pdfFilePath);

            MessageBox.Show($"Invoice generated at: {pdfFilePath}", "Invoice Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "ErrorM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
