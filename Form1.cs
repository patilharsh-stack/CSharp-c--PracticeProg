using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens.Experimental;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace WinFormUserInformation
{
    public partial class Form1 : Form
    {
        //databases connection string
        //string connectionstring = @"Server=(localdb)\MSSQLLocalDB;Database=UserRegistrationDB;Integrated Security=True;TrustServerCertificate=True;";
        //   string connectionstring = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
       String connectionString = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
        private int selectedUserId;

        // constructor of my class
        public Form1()


        {


            InitializeComponent(); // user select केला आहे, त्याचा Userid

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            TestConnection();  // call in from then this exicute the con test when the from open.

            LoadUsers();

            comboBox2.Items.Add("Science");  // hardcoded items
            comboBox2.Items.Add("Commerce");
            comboBox2.Items.Add("Arts");

            comboBox2.SelectedIndex = 0;  //item by default
        }


        private void ClearFields()
        {
            fristNmtextBox.Clear();
            lastnameBox1.Clear();

            MaleradioButton1.Checked = false;
            FemaleradioButton2.Checked = false;
            OtherradioButton1.Checked = false;

            EmployeedcheckBox1.Checked = false;
            UnEmployeedcheckBox2.Checked = false;

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            selectedUserId = 0;
        }




        // test connection of the database 
        private void TestConnection()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try // to code exucuted 
                {
                    con.Open();


                    MessageBox.Show("Database connectin Sucessfully!");
                }
                catch (Exception ex) // handel the code 
                {
                    MessageBox.Show(ex.Message); // disply the massage 
                }
            }
        }

        private void fristNmtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fristNmlabel_Click(object sender, EventArgs e)
        {

        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {
            // Get First Name and Last Name
            string firstName = fristNmtextBox.Text.Trim();
            string lastName = lastnameBox1.Text.Trim();

            //  Get Gender
            string gender = "";

            if (MaleradioButton1.Checked)
                gender = (MaleradioButton1.Text);
            else if (FemaleradioButton2.Checked)
                gender = FemaleradioButton2.Text;
            else if (OtherradioButton1.Checked)
                gender = OtherradioButton1.Text;

            //  Get Employment Status
            string status = "";

            if (EmployeedcheckBox1.Checked)
                status = EmployeedcheckBox1.Text;
            else if (UnEmployeedcheckBox2.Checked)
                status = UnEmployeedcheckBox2.Text;

            //  Get University and Course
            string university = comboBox1.Text.Trim();
            string course = comboBox2.Text.Trim();

            //  Validate all fields
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please enter First Name");
                fristNmtextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter Last Name");
                lastnameBox1.Focus();
                return;
            }

            if (gender == "")
            {
                MessageBox.Show("Please select Gender");
                return;
            }

            if (status == "")
            {
                MessageBox.Show("Please select Employment Status");
                return;
            }

            if (string.IsNullOrWhiteSpace(university))
            {
                MessageBox.Show("Please select University");
                return;
            }

            if (string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please select Course");
                return;
            }

            //  SQL INSERT query
            string query = @"
        // INSERT INTO Users
        //(FristName, LastName, Gender, UserStatus, University, Course)
        //VALUES
        //(@FirstName, @LastName, @Gender, @Status, @University, @Course)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // con.Open();

                    //
                    //using (SqlCommand cmd = new SqlCommand(query, con))

                    using (SqlCommand cmd = new SqlCommand("usp_ManageUsers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure; // this the sp call in thsi code 

                        cmd.Parameters.AddWithValue("@Action", "INSERT");
                        cmd.Parameters.AddWithValue("@FristName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@UserStatus", status);
                        cmd.Parameters.AddWithValue("@University", university);
                        cmd.Parameters.AddWithValue("@Course", course);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                //  Refresh DataGridView
                LoadUsers();

                MessageBox.Show("Registration Saved Successfully!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // create the Load user for data retriview from the data base 

        private void LoadUsers()
        {
            // String query = "select * from Users";

            try
            {  // create a sql connection
                using (SqlConnection con = new SqlConnection(connectionString))
                    
                //{
                //    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))  // to phase the data give in the sql 
                //    {                                                                 //using adapter to an exicuting the sql query
                //        DataTable dt = new DataTable();  // create a empty table in memory

                //        adapter.Fill(dt); // exicute the select qury and fill data in empty datatable

                //        dataGridView1.DataSource = dt;  // display in the database

                //    }

                    
                {
                    //// Create SQL Command
                    //using (SqlCommand cmd =
                    //       new SqlCommand(query, con))


                    using (SqlCommand cmd = new SqlCommand("usp_ManageUsers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure; // this the sp call in thsi code 
                        cmd.Parameters.AddWithValue("@Action", "SELECT");

                        {

                            // Open connection
                            // con.Open();

                            // Execute SELECT query
                            using (SqlDataAdapter adapter =
                                   new SqlDataAdapter(cmd))   //  use tp a like
                            {
                                // Create DataTable
                                DataTable dt = new DataTable();

                                adapter.Fill(dt);
                                // Load reader data into DataTable
                                //     dt.Load(reader);

                                // Display data in Grid
                                dataGridView1.DataSource = dt;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Display Error: " + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox2.Text = ("Science");
            //comboBox2.Text = ("Commerce");
            // InitializeComponent();

            // comboBox2.Items.Add("commerce");
        }

        private void lastnameBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnEmployeedcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (UnEmployeedcheckBox2.Checked)
            {
                EmployeedcheckBox1.Checked = false;
            }
        }

        private void EmployeedcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (EmployeedcheckBox1.Checked)
            {
                UnEmployeedcheckBox2.Checked = false;
            }
        }

        //update button


        private void Updatebutton2_Click(object sender, EventArgs e)
        {
            // 1. Get values from form
            string firstName = fristNmtextBox.Text.Trim();
            string lastName = lastnameBox1.Text.Trim();
            string university = comboBox1.Text.Trim();
            string course = comboBox2.Text.Trim();

            // 2. Get Gender
            string gender = "";

            if (MaleradioButton1.Checked)
                gender = MaleradioButton1.Text;
            else if (FemaleradioButton2.Checked)
                gender = FemaleradioButton2.Text;
            else if (OtherradioButton1.Checked)
                gender = OtherradioButton1.Text;

            // 3. Get Employment Status
            string status = "";

            if (EmployeedcheckBox1.Checked)
                status = EmployeedcheckBox1.Text;
            else if (UnEmployeedcheckBox2.Checked)
                status = UnEmployeedcheckBox2.Text;

            // 4. Check selected record
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a record from DataGridView");
                return;
            }

            // 5. Validate fields
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(status) ||
                string.IsNullOrWhiteSpace(university) ||
                string.IsNullOrWhiteSpace(course))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            //    // 6. SQL UPDATE query
            //    string query = @"UPDATE Users SET
            //FristName = @FirstName,
            //LastName = @LastName,
            //Gender = @Gender,
            //UserStatus = @Status,
            //University = @University,
            //Course = @Course
            //WHERE Userid = @Userid";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {


                    using (SqlCommand cmd = new SqlCommand("usp_ManageUsers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure; // this the sp call in thsi code

                        cmd.Parameters.AddWithValue("@Action", "UPDATE");
                        cmd.Parameters.AddWithValue("@Userid", selectedUserId);


                        cmd.Parameters.AddWithValue("@FristName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@UserStatus", status);
                        cmd.Parameters.AddWithValue("@University", university);
                        cmd.Parameters.AddWithValue("@Course", course);


                        con.Open();

                        // 7. Execute UPDATE query
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Record Updated Successfully!");

                            //  Refresh DataGridView
                            LoadUsers();

                            ClearFields();
                            fristNmtextBox.Focus();
                            // Reset selected ID
                            selectedUserId = 0;
                        }
                        else
                        {
                            MessageBox.Show("Record Not Found!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            selectedUserId = Convert.ToInt32(row.Cells["Userid"].Value);
            fristNmtextBox.Text = row.Cells["FristName"].Value.ToString();
            lastnameBox1.Text = row.Cells["LastName"].Value.ToString();
            comboBox1.Text = row.Cells["University"].Value.ToString();
            comboBox2.Text = row.Cells["Course"].Value.ToString();

            string gender = Convert.ToString(row.Cells["Gender"].Value).Trim();

            MaleradioButton1.Checked = gender == (MaleradioButton1.Text);
            FemaleradioButton2.Checked = gender == (FemaleradioButton2.Text);
            OtherradioButton1.Checked = gender == (OtherradioButton1.Text);


            String status = Convert.ToString(row.Cells["UserStatus"].Value).Trim();

            EmployeedcheckBox1.Checked = status == EmployeedcheckBox1.Text;
            UnEmployeedcheckBox2.Checked = status == UnEmployeedcheckBox2.Text;
        }

        // delete operation start

        private void Deletebutton1_Click(object sender, EventArgs e)
        {

            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a record from DataGridView");
                return;
            }

            // Ask confirmation before deleting
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }

            //  DELETE query
            // string query = "DELETE FROM Users WHERE Userid = @Userid";


            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Open database connection
                    // con.Open();

                    // MessageBox.Show("Database Connected Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message);
            }


            // delete record code start



            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    //con.Open();

                    using (SqlCommand cmd = new SqlCommand("usp_ManageUsers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Action", "DELETE");


                        // Pass selected User ID
                        cmd.Parameters.AddWithValue("@Userid", selectedUserId);
                        con.Open();
                        // Execute DELETE query
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully!");

                            selectedUserId = 0;

                            LoadUsers();

                            ClearFields();

                        }
                        else
                        {
                            MessageBox.Show("Record Not Found!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
            }

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDocumentFrom from = new StudentDocumentFrom();
            from.Show();
        }
    }

}
            