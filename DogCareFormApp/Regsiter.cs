using ClosedXML.Excel;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DogCareFormApp
{
    public partial class Regsiter : UserControl
    {
        private string savedFilePath;

        public Regsiter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ownerid = int.Parse(OwnerId.Text);
                string ownername = OwnerName.Text;
                string ownercontact = OwnerContact.Text;
                string owneraddress = OwnerAddress.Text;
                string owneremail = OwnerEmail.Text;

                string dogname = DogName.Text;
                string dogbreed = DogBreed.Text;
                int dogage = int.Parse(DogAge.Text);
                string doggender = DogGender.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["DogRegForm"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Enable IDENTITY_INSERT
                    using (SqlCommand identityOnCommand = new SqlCommand("SET IDENTITY_INSERT DogOwner ON", connection))
                    {
                        identityOnCommand.ExecuteNonQuery();
                    }

                    // Insert into DogOwner table with OwnerId
                    string ownerQuery = "INSERT INTO DogOwner (OwnerId, OwnerName, OwnerContact, OwnerAddress, OwnerEmail) VALUES (@OwnerId, @OwnerName, @OwnerContact, @OwnerAddress, @OwnerEmail)";
                    using (SqlCommand command = new SqlCommand(ownerQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OwnerId", ownerid);
                        command.Parameters.AddWithValue("@OwnerName", ownername);
                        command.Parameters.AddWithValue("@OwnerContact", ownercontact);
                        command.Parameters.AddWithValue("@OwnerAddress", owneraddress);
                        command.Parameters.AddWithValue("@OwnerEmail", owneremail);
                        command.ExecuteNonQuery();
                    }

                    // Disable IDENTITY_INSERT
                    using (SqlCommand identityOffCommand = new SqlCommand("SET IDENTITY_INSERT DogOwner OFF", connection))
                    {
                        identityOffCommand.ExecuteNonQuery();
                    }

                    // Insert into Dog table
                    string dogQuery = "INSERT INTO Dog (DogName, DogBreed, DogAge, DogGender) VALUES (@DogName, @DogBreed, @DogAge, @DogGender)";
                    using (SqlCommand command = new SqlCommand(dogQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DogName", dogname);
                        command.Parameters.AddWithValue("@DogBreed", dogbreed);
                        command.Parameters.AddWithValue("@DogAge", dogage);
                        command.Parameters.AddWithValue("@DogGender", doggender);
                        command.ExecuteNonQuery();
                    }

                    if (string.IsNullOrEmpty(savedFilePath))
                    {
                        // Show SaveFileDialog to let user choose save location
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                            saveFileDialog.Title = "Save Owner and Dog Information";
                            saveFileDialog.FileName = "OwnerAndDogInformation.xlsx";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                savedFilePath = saveFileDialog.FileName;
                            }
                            else
                            {
                                MessageBox.Show("Save operation cancelled.");
                                return;
                            }
                        }
                    }

                    using (var workbook = File.Exists(savedFilePath) ? new XLWorkbook(savedFilePath) : new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.FirstOrDefault() ?? workbook.Worksheets.Add("Owner and Dog Information");

                        // If the worksheet is empty, write the headers
                        if (worksheet.LastRowUsed() == null)
                        {
                            worksheet.Cell(1, 1).Value = "Owner ID";
                            worksheet.Cell(1, 2).Value = "Owner Name";
                            worksheet.Cell(1, 3).Value = "Owner Contact";
                            worksheet.Cell(1, 4).Value = "Owner Address";
                            worksheet.Cell(1, 5).Value = "Owner Email";
                            worksheet.Cell(1, 6).Value = "Dog Name";
                            worksheet.Cell(1, 7).Value = "Dog Breed";
                            worksheet.Cell(1, 8).Value = "Dog Age";
                            worksheet.Cell(1, 9).Value = "Dog Gender";
                        }

                        // Find the next available row
                        int newRow = worksheet.LastRowUsed()?.RowNumber() + 1 ?? 2;

                        worksheet.Cell(newRow, 1).Value = ownerid;
                        worksheet.Cell(newRow, 2).Value = ownername;
                        worksheet.Cell(newRow, 3).Value = ownercontact;
                        worksheet.Cell(newRow, 4).Value = owneraddress;
                        worksheet.Cell(newRow, 5).Value = owneremail;
                        worksheet.Cell(newRow, 6).Value = dogname;
                        worksheet.Cell(newRow, 7).Value = dogbreed;
                        worksheet.Cell(newRow, 8).Value = dogage;
                        worksheet.Cell(newRow, 9).Value = doggender;

                        workbook.SaveAs(savedFilePath);
                    }

                    MessageBox.Show("Data inserted and Excel file updated successfully. File saved to: " + savedFilePath);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error occurred: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("File I/O error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(savedFilePath) || !File.Exists(savedFilePath))
                {
                    MessageBox.Show("The Excel file does not exist.");
                    return;
                }

                // Ensure the file is not being used by another process by copying to a temporary file
                string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetFileName(savedFilePath));
                File.Copy(savedFilePath, tempFilePath, true);

                using (var workbook = new XLWorkbook(tempFilePath))
                {
                    var worksheet = workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null || worksheet.LastRowUsed() == null)
                    {
                        MessageBox.Show("The worksheet is empty or does not exist.");
                        return;
                    }

                    // Get the last row number
                    int lastRow = worksheet.LastRowUsed().RowNumber();

                    // Delete the last row
                    worksheet.Row(lastRow).Delete();

                    // Save the changes to the temporary file
                    workbook.SaveAs(tempFilePath);
                }

                // Replace the original file with the modified temporary file
                File.Copy(tempFilePath, savedFilePath, true);
                File.Delete(tempFilePath);

                MessageBox.Show("Last row deleted successfully.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("File I/O error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int ownerid = int.Parse(OwnerId.Text);
                string ownername = OwnerName.Text;
                string ownercontact = OwnerContact.Text;
                string owneraddress = OwnerAddress.Text;
                string owneremail = OwnerEmail.Text;

                string dogname = DogName.Text;
                string dogbreed = DogBreed.Text;
                int dogage = int.Parse(DogAge.Text);
                string doggender = DogGender.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["DogRegForm"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Enable IDENTITY_INSERT
                    using (SqlCommand identityOnCommand = new SqlCommand("SET IDENTITY_INSERT DogOwner ON", connection))
                    {
                        identityOnCommand.ExecuteNonQuery();
                    }

                    // Insert into DogOwner table with OwnerId
                    string ownerQuery = "INSERT INTO DogOwner (OwnerId, OwnerName, OwnerContact, OwnerAddress, OwnerEmail) VALUES (@OwnerId, @OwnerName, @OwnerContact, @OwnerAddress, @OwnerEmail)";
                    using (SqlCommand command = new SqlCommand(ownerQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OwnerId", ownerid);
                        command.Parameters.AddWithValue("@OwnerName", ownername);
                        command.Parameters.AddWithValue("@OwnerContact", ownercontact);
                        command.Parameters.AddWithValue("@OwnerAddress", owneraddress);
                        command.Parameters.AddWithValue("@OwnerEmail", owneremail);
                        command.ExecuteNonQuery();
                    }

                    // Disable IDENTITY_INSERT
                    using (SqlCommand identityOffCommand = new SqlCommand("SET IDENTITY_INSERT DogOwner OFF", connection))
                    {
                        identityOffCommand.ExecuteNonQuery();
                    }

                    // Insert into Dog table
                    string dogQuery = "INSERT INTO Dog (DogName, DogBreed, DogAge, DogGender) VALUES (@DogName, @DogBreed, @DogAge, @DogGender)";
                    using (SqlCommand command = new SqlCommand(dogQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DogName", dogname);
                        command.Parameters.AddWithValue("@DogBreed", dogbreed);
                        command.Parameters.AddWithValue("@DogAge", dogage);
                        command.Parameters.AddWithValue("@DogGender", doggender);
                        command.ExecuteNonQuery();
                    }

                    if (string.IsNullOrEmpty(savedFilePath))
                    {
                        // Show SaveFileDialog to let user choose save location
                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                            saveFileDialog.Title = "Save Owner and Dog Information";
                            saveFileDialog.FileName = "OwnerAndDogInformation.xlsx";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                savedFilePath = saveFileDialog.FileName;
                            }
                            else
                            {
                                MessageBox.Show("Save operation cancelled.");
                                return;
                            }
                        }
                    }

                    using (var workbook = File.Exists(savedFilePath) ? new XLWorkbook(savedFilePath) : new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.FirstOrDefault() ?? workbook.Worksheets.Add("Owner and Dog Information");

                        // If the worksheet is empty, write the headers
                        if (worksheet.LastRowUsed() == null)
                        {
                            worksheet.Cell(1, 1).Value = "Owner ID";
                            worksheet.Cell(1, 2).Value = "Owner Name";
                            worksheet.Cell(1, 3).Value = "Owner Contact";
                            worksheet.Cell(1, 4).Value = "Owner Address";
                            worksheet.Cell(1, 5).Value = "Owner Email";
                            worksheet.Cell(1, 6).Value = "Dog Name";
                            worksheet.Cell(1, 7).Value = "Dog Breed";
                            worksheet.Cell(1, 8).Value = "Dog Age";
                            worksheet.Cell(1, 9).Value = "Dog Gender";
                        }

                        // Find the next available row
                        int newRow = worksheet.LastRowUsed()?.RowNumber() + 1 ?? 2;

                        worksheet.Cell(newRow, 1).Value = ownerid;
                        worksheet.Cell(newRow, 2).Value = ownername;
                        worksheet.Cell(newRow, 3).Value = ownercontact;
                        worksheet.Cell(newRow, 4).Value = owneraddress;
                        worksheet.Cell(newRow, 5).Value = owneremail;
                        worksheet.Cell(newRow, 6).Value = dogname;
                        worksheet.Cell(newRow, 7).Value = dogbreed;
                        worksheet.Cell(newRow, 8).Value = dogage;
                        worksheet.Cell(newRow, 9).Value = doggender;

                        workbook.SaveAs(savedFilePath);
                    }

                    MessageBox.Show("Data inserted and Excel file updated successfully. File saved to: " + savedFilePath);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error occurred: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("File I/O error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(savedFilePath) || !File.Exists(savedFilePath))
                {
                    MessageBox.Show("The Excel file does not exist.");
                    return;
                }

                // Ensure the file is not being used by another process by copying to a temporary file
                string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetFileName(savedFilePath));
                File.Copy(savedFilePath, tempFilePath, true);

                using (var workbook = new XLWorkbook(tempFilePath))
                {
                    var worksheet = workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null || worksheet.LastRowUsed() == null)
                    {
                        MessageBox.Show("The worksheet is empty or does not exist.");
                        return;
                    }

                    // Get the last row number
                    int lastRow = worksheet.LastRowUsed().RowNumber();

                    // Delete the last row
                    worksheet.Row(lastRow).Delete();

                    // Save the changes to the temporary file
                    workbook.SaveAs(tempFilePath);
                }

                // Replace the original file with the modified temporary file
                File.Copy(tempFilePath, savedFilePath, true);
                File.Delete(tempFilePath);

                MessageBox.Show("Last row deleted successfully.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("File I/O error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
    }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Regsiter_Load(object sender, EventArgs e)
        {

        }
    }
}
