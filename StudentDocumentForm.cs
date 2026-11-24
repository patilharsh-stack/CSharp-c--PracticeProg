using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;

using System.IO;
using System.Configuration;

namespace WinFormUserInformation
{
    public partial class StudentDocumentFrom : Form  //class
    {
        String connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
        //        Initial Catalog=UserRegistrationDB;
        //        Integrated Security=True;";

        int selectedDocumentId = 0; // Variable to store the selected document ID

        string selectedFilePath = ""; // Variable to store the selected file path

        public StudentDocumentFrom()
        {

            InitializeComponent();
            LoadStudentRollNumbers(); // call the method to load student roll numbers when the form is initialized
            LoadDocuments();
        }


        private void iappnamelabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvdocumentpreviewGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpStudentInfo_Enter(object sender, EventArgs e)
        {

        }

        private void textdoccomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadDocuments()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                         DocumentId,
                         StudentRollNo,
                         DocumentType,
                         FileName,
                         UploadDate
                         FROM StudentDocuments
                         ORDER BY DocumentId DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvdocumentpreviewGridView1.DataSource = dt;
            }
        }



        private void LoadStudentRollNumbers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Userid FROM Users";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                StudentrollcomboBox1.DataSource = dt;
                StudentrollcomboBox1.DisplayMember = "Userid";
                StudentrollcomboBox1.ValueMember = "Userid";
            }
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {



            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Student Document";

            ofd.Filter = "Document Files|*.pdf;*.jpg;*.jpeg;*.png";

            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = ofd.FileName;

                textdoccomboBox1.Text = Path.GetFileName(selectedFilePath);

                string extension = Path.GetExtension(selectedFilePath).ToLower();

                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                {
                    using (Image img = Image.FromFile(selectedFilePath))
                    {
                        pictureBox1.Image = new Bitmap(img);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("PDF selected successfully.");
                }
            }
        }

        private void Uploadbutton1_Click(object sender, EventArgs e)
        {


            // 1. Validation
            if (StudentrollcomboBox1.SelectedValue == null ||
                StudentrollcomboBox1.SelectedValue is DataRowView)
            {
                MessageBox.Show("Please select Student Roll No.");
                return;
            }

            if (documentTypecomboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Document Type.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedFilePath) ||
                !File.Exists(selectedFilePath))
            {
                MessageBox.Show("Please choose a valid file.");
                return;
            }

            // 2. Create object
            StudentDocument doc = new StudentDocument();

            doc.StudentRollNo =
                Convert.ToInt32(StudentrollcomboBox1.SelectedValue);

            doc.DocumentType =
                documentTypecomboBox1.Text;

            doc.FileName =
                Path.GetFileName(selectedFilePath);

            // 3. Create folder
            string folderPath = Path.Combine(
                Application.StartupPath, "StudentDocuments");

            Directory.CreateDirectory(folderPath);

            // 4. Copy file
            string newFileName =
                Guid.NewGuid().ToString() +
                Path.GetExtension(selectedFilePath);

            doc.FilePath = Path.Combine(folderPath, newFileName);

            File.Copy(selectedFilePath, doc.FilePath);

            // 5. Save details in SQL
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO StudentDocuments
                         (StudentRollNo, DocumentType, FileName, FilePath)
                         VALUES
                         (@StudentRollNo, @DocumentType, @FileName, @FilePath)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentRollNo", doc.StudentRollNo);
                    cmd.Parameters.AddWithValue("@DocumentType", doc.DocumentType);
                    cmd.Parameters.AddWithValue("@FileName", doc.FileName);
                    cmd.Parameters.AddWithValue("@FilePath", doc.FilePath);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Document uploaded successfully!");
            LoadDocuments();

            selectedFilePath = "";
            textdoccomboBox1.Text = "";
            documentTypecomboBox1.SelectedIndex = -1;
        }

        private void dgvdocumentpreviewGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selectedDocumentId = Convert.ToInt32(
                dgvdocumentpreviewGridView1.Rows[e.RowIndex]
                .Cells["DocumentId"].Value
            );

            documentTypecomboBox1.Text = Convert.ToString(
                dgvdocumentpreviewGridView1.Rows[e.RowIndex]
                .Cells["DocumentType"].Value
            ) ?? "";

            textdoccomboBox1.Text = Convert.ToString(
                dgvdocumentpreviewGridView1.Rows[e.RowIndex]
                .Cells["FileName"].Value
            ) ?? "";
        }

        private void deletebutton1_Click(object sender, EventArgs e)
        {


            // Step 1: Check row selected or not
            if (selectedDocumentId == 0)
            {
                MessageBox.Show("Please select a document first!");
                return;
            }

            // Step 2: Confirm delete
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this document?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Step 3: Get file path
                        string filePath = "";

                        string selectQuery =
                            "SELECT FilePath FROM StudentDocuments WHERE DocumentId = @DocumentId";

                        using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@DocumentId", selectedDocumentId);

                            object value = cmd.ExecuteScalar();

                            if (value != null && value != DBNull.Value)
                            {
                                filePath = value.ToString() ?? "";
                            }
                        }

                        // Step 4: Delete database record
                        string deleteQuery =
                            "DELETE FROM StudentDocuments WHERE DocumentId = @DocumentId";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@DocumentId", selectedDocumentId);

                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                // Step 5: Delete physical file
                                if (!string.IsNullOrWhiteSpace(filePath) &&
                                    File.Exists(filePath))
                                {
                                    File.Delete(filePath);
                                }

                                MessageBox.Show("Document deleted successfully!");

                                // Step 6: Refresh grid
                                selectedDocumentId = 0;
                                documentTypecomboBox1.SelectedIndex = -1;
                                textdoccomboBox1.Text = "";

                                LoadDocuments();
                            }
                            else
                            {
                                MessageBox.Show("Document not found!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message);
                }
            }
        }
        // view document by student roll number
        private void viewbutton2_Click(object sender, EventArgs e)
        {
            if (StudentrollcomboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a student roll number.");
                return;
            }
            int studentRollNo = Convert.ToInt32(StudentrollcomboBox1.SelectedValue);

            MessageBox.Show("Student Roll Number: " + studentRollNo);

            string query = @"SELECT * FROM StudentDocuments WHERE StudentRollNo = @StudentRollNo";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentRollNo", studentRollNo);
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvdocumentpreviewGridView1.DataSource = dt;
                    MessageBox.Show("Total Documents: " + dt.Rows.Count);
                }
            }
        }

        private void Mainpanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



