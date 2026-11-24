namespace WinFormUserInformation
{
    partial class StudentDocumentFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hederpanel1 = new Panel();
            iappnamelabel1 = new Label();
            Welcomelabel1 = new Label();
            siderpanel1 = new Panel();
            Reportsbutton5 = new Button();
            StudentManagementbutton4 = new Button();
            EmployeeManegemetbutton3 = new Button();
            StudentDocumetbutton2 = new Button();
            UserRegistrationbutton1 = new Button();
            dashbordbutton1 = new Button();
            Mainpanel1 = new Panel();
            dgvdocumentpreviewGridView1 = new DataGridView();
            PreviewgroupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            documentuploadgroupBox1 = new GroupBox();
            viewbutton2 = new Button();
            button1 = new Button();
            deletebutton1 = new Button();
            Addbutton1 = new Button();
            documenttypelabe = new Label();
            documentTypecomboBox1 = new ComboBox();
            Uploadbutton1 = new Button();
            textdoccomboBox1 = new ComboBox();
            chosefilelabel2 = new Label();
            grpStudentInfo = new GroupBox();
            label1 = new Label();
            StudentrollcomboBox1 = new ComboBox();
            documenttitlelabel1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            hederpanel1.SuspendLayout();
            siderpanel1.SuspendLayout();
            Mainpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdocumentpreviewGridView1).BeginInit();
            PreviewgroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            documentuploadgroupBox1.SuspendLayout();
            grpStudentInfo.SuspendLayout();
            SuspendLayout();
            // 
            // hederpanel1
            // 
            hederpanel1.BackColor = Color.DarkSlateBlue;
            hederpanel1.Controls.Add(iappnamelabel1);
            hederpanel1.Dock = DockStyle.Top;
            hederpanel1.Location = new Point(0, 0);
            hederpanel1.Name = "hederpanel1";
            hederpanel1.Size = new Size(1200, 125);
            hederpanel1.TabIndex = 0;
            // 
            // iappnamelabel1
            // 
            iappnamelabel1.AutoSize = true;
            iappnamelabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iappnamelabel1.ForeColor = SystemColors.ControlLight;
            iappnamelabel1.Location = new Point(44, 30);
            iappnamelabel1.Name = "iappnamelabel1";
            iappnamelabel1.Size = new Size(182, 20);
            iappnamelabel1.TabIndex = 1;
            iappnamelabel1.Text = "User Managemet Studio ";
            iappnamelabel1.Click += iappnamelabel1_Click;
            // 
            // Welcomelabel1
            // 
            Welcomelabel1.AutoSize = true;
            Welcomelabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcomelabel1.Location = new Point(900, 30);
            Welcomelabel1.Name = "Welcomelabel1";
            Welcomelabel1.Size = new Size(133, 20);
            Welcomelabel1.TabIndex = 2;
            Welcomelabel1.Text = "Welcome : Admin";
            // 
            // siderpanel1
            // 
            siderpanel1.BackColor = Color.DarkSlateBlue;
            siderpanel1.Controls.Add(Reportsbutton5);
            siderpanel1.Controls.Add(StudentManagementbutton4);
            siderpanel1.Controls.Add(EmployeeManegemetbutton3);
            siderpanel1.Controls.Add(StudentDocumetbutton2);
            siderpanel1.Controls.Add(UserRegistrationbutton1);
            siderpanel1.Controls.Add(dashbordbutton1);
            siderpanel1.Dock = DockStyle.Left;
            siderpanel1.Location = new Point(0, 125);
            siderpanel1.Name = "siderpanel1";
            siderpanel1.Size = new Size(250, 585);
            siderpanel1.TabIndex = 3;
            // 
            // Reportsbutton5
            // 
            Reportsbutton5.BackColor = Color.SlateBlue;
            Reportsbutton5.Cursor = Cursors.Hand;
            Reportsbutton5.FlatStyle = FlatStyle.Flat;
            Reportsbutton5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reportsbutton5.ForeColor = Color.White;
            Reportsbutton5.Location = new Point(15, 401);
            Reportsbutton5.Name = "Reportsbutton5";
            Reportsbutton5.Size = new Size(208, 42);
            Reportsbutton5.TabIndex = 9;
            Reportsbutton5.Text = "        Reports";
            Reportsbutton5.TextAlign = ContentAlignment.MiddleLeft;
            Reportsbutton5.UseVisualStyleBackColor = false;
            // 
            // StudentManagementbutton4
            // 
            StudentManagementbutton4.BackColor = Color.SlateBlue;
            StudentManagementbutton4.Cursor = Cursors.Hand;
            StudentManagementbutton4.FlatStyle = FlatStyle.Flat;
            StudentManagementbutton4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentManagementbutton4.ForeColor = Color.White;
            StudentManagementbutton4.Location = new Point(15, 182);
            StudentManagementbutton4.Name = "StudentManagementbutton4";
            StudentManagementbutton4.Size = new Size(211, 45);
            StudentManagementbutton4.TabIndex = 8;
            StudentManagementbutton4.Text = "Student Management";
            StudentManagementbutton4.TextAlign = ContentAlignment.MiddleLeft;
            StudentManagementbutton4.UseVisualStyleBackColor = false;
            // 
            // EmployeeManegemetbutton3
            // 
            EmployeeManegemetbutton3.BackColor = Color.SlateBlue;
            EmployeeManegemetbutton3.Cursor = Cursors.Hand;
            EmployeeManegemetbutton3.FlatStyle = FlatStyle.Flat;
            EmployeeManegemetbutton3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeManegemetbutton3.ForeColor = Color.White;
            EmployeeManegemetbutton3.Location = new Point(15, 251);
            EmployeeManegemetbutton3.Name = "EmployeeManegemetbutton3";
            EmployeeManegemetbutton3.Size = new Size(208, 47);
            EmployeeManegemetbutton3.TabIndex = 7;
            EmployeeManegemetbutton3.Text = "Employee Manegemet";
            EmployeeManegemetbutton3.TextAlign = ContentAlignment.MiddleLeft;
            EmployeeManegemetbutton3.UseVisualStyleBackColor = false;
            // 
            // StudentDocumetbutton2
            // 
            StudentDocumetbutton2.BackColor = Color.SlateBlue;
            StudentDocumetbutton2.Cursor = Cursors.Hand;
            StudentDocumetbutton2.FlatStyle = FlatStyle.Flat;
            StudentDocumetbutton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentDocumetbutton2.ForeColor = Color.White;
            StudentDocumetbutton2.Location = new Point(12, 330);
            StudentDocumetbutton2.Name = "StudentDocumetbutton2";
            StudentDocumetbutton2.Size = new Size(208, 42);
            StudentDocumetbutton2.TabIndex = 6;
            StudentDocumetbutton2.Text = "    Student Documet";
            StudentDocumetbutton2.TextAlign = ContentAlignment.MiddleLeft;
            StudentDocumetbutton2.UseVisualStyleBackColor = false;
            // 
            // UserRegistrationbutton1
            // 
            UserRegistrationbutton1.BackColor = Color.SlateBlue;
            UserRegistrationbutton1.Cursor = Cursors.Hand;
            UserRegistrationbutton1.FlatStyle = FlatStyle.Flat;
            UserRegistrationbutton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserRegistrationbutton1.ForeColor = Color.White;
            UserRegistrationbutton1.Location = new Point(15, 112);
            UserRegistrationbutton1.Name = "UserRegistrationbutton1";
            UserRegistrationbutton1.Size = new Size(208, 37);
            UserRegistrationbutton1.TabIndex = 5;
            UserRegistrationbutton1.Text = "User Registration";
            UserRegistrationbutton1.TextAlign = ContentAlignment.MiddleLeft;
            UserRegistrationbutton1.UseVisualStyleBackColor = false;
            // 
            // dashbordbutton1
            // 
            dashbordbutton1.BackColor = Color.SlateBlue;
            dashbordbutton1.Cursor = Cursors.Hand;
            dashbordbutton1.FlatStyle = FlatStyle.Flat;
            dashbordbutton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashbordbutton1.ForeColor = Color.White;
            dashbordbutton1.Location = new Point(12, 41);
            dashbordbutton1.Name = "dashbordbutton1";
            dashbordbutton1.Size = new Size(211, 33);
            dashbordbutton1.TabIndex = 4;
            dashbordbutton1.Text = "      Dashboard";
            dashbordbutton1.TextAlign = ContentAlignment.MiddleLeft;
            dashbordbutton1.UseVisualStyleBackColor = false;
            // 
            // Mainpanel1
            // 
            Mainpanel1.AutoScroll = true;
            Mainpanel1.Controls.Add(dgvdocumentpreviewGridView1);
            Mainpanel1.Controls.Add(PreviewgroupBox1);
            Mainpanel1.Controls.Add(documentuploadgroupBox1);
            Mainpanel1.Controls.Add(grpStudentInfo);
            Mainpanel1.Controls.Add(documenttitlelabel1);
            Mainpanel1.Dock = DockStyle.Fill;
            Mainpanel1.Location = new Point(250, 125);
            Mainpanel1.Name = "Mainpanel1";
            Mainpanel1.Padding = new Padding(15);
            Mainpanel1.Size = new Size(950, 585);
            Mainpanel1.TabIndex = 4;
            Mainpanel1.Paint += Mainpanel1_Paint;
            // 
            // dgvdocumentpreviewGridView1
            // 
            dgvdocumentpreviewGridView1.AllowUserToAddRows = false;
            dgvdocumentpreviewGridView1.AllowUserToDeleteRows = false;
            dgvdocumentpreviewGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdocumentpreviewGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvdocumentpreviewGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdocumentpreviewGridView1.Location = new Point(6, 337);
            dgvdocumentpreviewGridView1.MultiSelect = false;
            dgvdocumentpreviewGridView1.Name = "dgvdocumentpreviewGridView1";
            dgvdocumentpreviewGridView1.ReadOnly = true;
            dgvdocumentpreviewGridView1.RowHeadersVisible = false;
            dgvdocumentpreviewGridView1.RowHeadersWidth = 51;
            dgvdocumentpreviewGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdocumentpreviewGridView1.Size = new Size(932, 230);
            dgvdocumentpreviewGridView1.TabIndex = 12;
            dgvdocumentpreviewGridView1.CellClick += dgvdocumentpreviewGridView1_CellClick;
            dgvdocumentpreviewGridView1.CellContentClick += dgvdocumentpreviewGridView1_CellContentClick;
            // 
            // PreviewgroupBox1
            // 
            PreviewgroupBox1.Controls.Add(pictureBox1);
            PreviewgroupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreviewgroupBox1.Location = new Point(565, 24);
            PreviewgroupBox1.Name = "PreviewgroupBox1";
            PreviewgroupBox1.Size = new Size(373, 307);
            PreviewgroupBox1.TabIndex = 11;
            PreviewgroupBox1.TabStop = false;
            PreviewgroupBox1.Text = "Document Preview";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(6, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // documentuploadgroupBox1
            // 
            documentuploadgroupBox1.Controls.Add(viewbutton2);
            documentuploadgroupBox1.Controls.Add(button1);
            documentuploadgroupBox1.Controls.Add(deletebutton1);
            documentuploadgroupBox1.Controls.Add(Addbutton1);
            documentuploadgroupBox1.Controls.Add(documenttypelabe);
            documentuploadgroupBox1.Controls.Add(documentTypecomboBox1);
            documentuploadgroupBox1.Controls.Add(Uploadbutton1);
            documentuploadgroupBox1.Controls.Add(textdoccomboBox1);
            documentuploadgroupBox1.Controls.Add(chosefilelabel2);
            documentuploadgroupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            documentuploadgroupBox1.Location = new Point(34, 120);
            documentuploadgroupBox1.Name = "documentuploadgroupBox1";
            documentuploadgroupBox1.Size = new Size(519, 205);
            documentuploadgroupBox1.TabIndex = 2;
            documentuploadgroupBox1.TabStop = false;
            documentuploadgroupBox1.Text = "Document Upload";
            // 
            // viewbutton2
            // 
            viewbutton2.BackColor = Color.Green;
            viewbutton2.FlatStyle = FlatStyle.Flat;
            viewbutton2.ForeColor = Color.White;
            viewbutton2.Location = new Point(267, 131);
            viewbutton2.Name = "viewbutton2";
            viewbutton2.Size = new Size(101, 29);
            viewbutton2.TabIndex = 13;
            viewbutton2.Text = "View All";
            viewbutton2.UseVisualStyleBackColor = false;
            viewbutton2.Click += viewbutton2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(313, 176);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // deletebutton1
            // 
            deletebutton1.BackColor = Color.Green;
            deletebutton1.FlatStyle = FlatStyle.Flat;
            deletebutton1.ForeColor = Color.White;
            deletebutton1.Location = new Point(132, 131);
            deletebutton1.Name = "deletebutton1";
            deletebutton1.Size = new Size(101, 29);
            deletebutton1.TabIndex = 11;
            deletebutton1.Text = "Delete";
            deletebutton1.UseVisualStyleBackColor = false;
            deletebutton1.Click += deletebutton1_Click;
            // 
            // Addbutton1
            // 
            Addbutton1.BackColor = Color.FromArgb(0, 64, 64);
            Addbutton1.FlatStyle = FlatStyle.Flat;
            Addbutton1.ForeColor = Color.White;
            Addbutton1.Location = new Point(417, 75);
            Addbutton1.Name = "Addbutton1";
            Addbutton1.Size = new Size(78, 29);
            Addbutton1.TabIndex = 7;
            Addbutton1.Text = "Browse";
            Addbutton1.UseVisualStyleBackColor = false;
            Addbutton1.Click += Addbutton1_Click;
            // 
            // documenttypelabe
            // 
            documenttypelabe.AutoSize = true;
            documenttypelabe.Location = new Point(32, 33);
            documenttypelabe.Name = "documenttypelabe";
            documenttypelabe.Size = new Size(119, 20);
            documenttypelabe.TabIndex = 3;
            documenttypelabe.Text = "Document Type";
            // 
            // documentTypecomboBox1
            // 
            documentTypecomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            documentTypecomboBox1.FormattingEnabled = true;
            documentTypecomboBox1.Items.AddRange(new object[] { "10th Marksheet", "12th Marksheet", "Aadhaar Card", "PAN Card", "Graduation Marksheet", "Post Graduation Marksheet", "Caste Certificate", "Domicile Certificate", "Experience Certificate", "Skill Certificate", "Resume", "Other Documents" });
            documentTypecomboBox1.Location = new Point(191, 33);
            documentTypecomboBox1.Name = "documentTypecomboBox1";
            documentTypecomboBox1.Size = new Size(313, 28);
            documentTypecomboBox1.TabIndex = 4;
            // 
            // Uploadbutton1
            // 
            Uploadbutton1.BackColor = Color.Green;
            Uploadbutton1.FlatStyle = FlatStyle.Flat;
            Uploadbutton1.ForeColor = Color.White;
            Uploadbutton1.Location = new Point(18, 131);
            Uploadbutton1.Name = "Uploadbutton1";
            Uploadbutton1.Size = new Size(93, 29);
            Uploadbutton1.TabIndex = 8;
            Uploadbutton1.Text = "Upload";
            Uploadbutton1.UseVisualStyleBackColor = false;
            Uploadbutton1.Click += Uploadbutton1_Click;
            // 
            // textdoccomboBox1
            // 
            textdoccomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textdoccomboBox1.FormattingEnabled = true;
            textdoccomboBox1.Location = new Point(155, 76);
            textdoccomboBox1.Name = "textdoccomboBox1";
            textdoccomboBox1.Size = new Size(243, 28);
            textdoccomboBox1.TabIndex = 6;
            textdoccomboBox1.SelectedIndexChanged += textdoccomboBox1_SelectedIndexChanged;
            // 
            // chosefilelabel2
            // 
            chosefilelabel2.AutoSize = true;
            chosefilelabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chosefilelabel2.Location = new Point(32, 75);
            chosefilelabel2.Name = "chosefilelabel2";
            chosefilelabel2.Size = new Size(79, 20);
            chosefilelabel2.TabIndex = 5;
            chosefilelabel2.Text = "Chose File";
            // 
            // grpStudentInfo
            // 
            grpStudentInfo.Controls.Add(label1);
            grpStudentInfo.Controls.Add(StudentrollcomboBox1);
            grpStudentInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpStudentInfo.Location = new Point(40, 41);
            grpStudentInfo.Name = "grpStudentInfo";
            grpStudentInfo.Size = new Size(513, 73);
            grpStudentInfo.TabIndex = 1;
            grpStudentInfo.TabStop = false;
            grpStudentInfo.Text = "Student Information";
            grpStudentInfo.Enter += grpStudentInfo_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 1;
            label1.Text = "Student Roll No";
            label1.Click += label1_Click;
            // 
            // StudentrollcomboBox1
            // 
            StudentrollcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentrollcomboBox1.FormattingEnabled = true;
            StudentrollcomboBox1.Location = new Point(162, 29);
            StudentrollcomboBox1.Name = "StudentrollcomboBox1";
            StudentrollcomboBox1.Size = new Size(351, 31);
            StudentrollcomboBox1.TabIndex = 0;
            // 
            // documenttitlelabel1
            // 
            documenttitlelabel1.AutoSize = true;
            documenttitlelabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            documenttitlelabel1.Location = new Point(41, 15);
            documenttitlelabel1.Name = "documenttitlelabel1";
            documenttitlelabel1.Size = new Size(238, 20);
            documenttitlelabel1.TabIndex = 0;
            documenttitlelabel1.Text = "Student Document Management";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // StudentDocumentFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 710);
            Controls.Add(Mainpanel1);
            Controls.Add(siderpanel1);
            Controls.Add(Welcomelabel1);
            Controls.Add(hederpanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StudentDocumentFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Document Management";
            hederpanel1.ResumeLayout(false);
            hederpanel1.PerformLayout();
            siderpanel1.ResumeLayout(false);
            Mainpanel1.ResumeLayout(false);
            Mainpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdocumentpreviewGridView1).EndInit();
            PreviewgroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            documentuploadgroupBox1.ResumeLayout(false);
            documentuploadgroupBox1.PerformLayout();
            grpStudentInfo.ResumeLayout(false);
            grpStudentInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void StudentrollcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel hederpanel1;
        private Label iappnamelabel1;
        private Label Welcomelabel1;
        private Panel siderpanel1;
        private Button dashbordbutton1;
        private Button Reportsbutton5;
        private Button StudentManagementbutton4;
        private Button EmployeeManegemetbutton3;
        private Button StudentDocumetbutton2;
        private Button UserRegistrationbutton1;
        private Panel Mainpanel1;
        private Label documenttitlelabel1;
        private GroupBox grpStudentInfo;
        private Label label1;
        private ComboBox StudentrollcomboBox1;
        private GroupBox documentuploadgroupBox1;
        private ComboBox documentTypecomboBox1;
        private Label documenttypelabe;
        private ComboBox textdoccomboBox1;
        private Label chosefilelabel2;
        private Button Addbutton1;
        private Button Uploadbutton1;
        private GroupBox PreviewgroupBox1;
        private PictureBox pictureBox1;
        private DataGridView dgvdocumentpreviewGridView1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button deletebutton1;
        private Button viewbutton2;
        private Button button1;
    }
}