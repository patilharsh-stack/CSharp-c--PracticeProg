namespace WinFormUserInformation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fristNmlabel = new Label();
            fristNmtextBox = new TextBox();
            label1 = new Label();
            lastnameBox1 = new TextBox();
            comboBox1 = new ComboBox();
            Universityabel2 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            Savebutton1 = new Button();
            Deletebutton1 = new Button();
            Updatebutton2 = new Button();
            EmployeedcheckBox1 = new CheckBox();
            UnEmployeedcheckBox2 = new CheckBox();
            MaleradioButton1 = new RadioButton();
            OtherradioButton1 = new RadioButton();
            FemaleradioButton2 = new RadioButton();
            genderlabel3 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // fristNmlabel
            // 
            fristNmlabel.AutoSize = true;
            fristNmlabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fristNmlabel.Location = new Point(25, 58);
            fristNmlabel.Name = "fristNmlabel";
            fristNmlabel.Size = new Size(107, 23);
            fristNmlabel.TabIndex = 0;
            fristNmlabel.Text = "Frist Name :";
            fristNmlabel.Click += fristNmlabel_Click;
            // 
            // fristNmtextBox
            // 
            fristNmtextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fristNmtextBox.Location = new Point(138, 51);
            fristNmtextBox.Name = "fristNmtextBox";
            fristNmtextBox.Size = new Size(198, 30);
            fristNmtextBox.TabIndex = 1;
            fristNmtextBox.TextChanged += fristNmtextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 51);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 2;
            label1.Text = "Last Name :";
            // 
            // lastnameBox1
            // 
            lastnameBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastnameBox1.Location = new Point(472, 48);
            lastnameBox1.Name = "lastnameBox1";
            lastnameBox1.Size = new Size(248, 30);
            lastnameBox1.TabIndex = 3;
            lastnameBox1.TextChanged += lastnameBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Shivaji University Kolhapur,Maharastra,India.", "Pune University,Maharastra,India." });
            comboBox1.Location = new Point(900, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(375, 28);
            comboBox1.TabIndex = 4;
            // 
            // Universityabel2
            // 
            Universityabel2.AutoSize = true;
            Universityabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Universityabel2.Location = new Point(771, 47);
            Universityabel2.Name = "Universityabel2";
            Universityabel2.Size = new Size(100, 23);
            Universityabel2.TabIndex = 5;
            Universityabel2.Text = "University :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1299, 49);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 6;
            label2.Text = "Course :";
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "Shivaji University Kolhapur,Maharastra,India.", "Pune University,Maharastra,India." });
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.ForeColor = Color.Black;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1390, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(262, 28);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Savebutton1
            // 
            Savebutton1.BackColor = Color.FromArgb(128, 255, 128);
            Savebutton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebutton1.ForeColor = Color.Black;
            Savebutton1.Location = new Point(103, 273);
            Savebutton1.Name = "Savebutton1";
            Savebutton1.Size = new Size(356, 40);
            Savebutton1.TabIndex = 8;
            Savebutton1.Text = "Save";
            Savebutton1.UseVisualStyleBackColor = false;
            Savebutton1.Click += Savebutton1_Click;
            // 
            // Deletebutton1
            // 
            Deletebutton1.BackColor = Color.FromArgb(128, 255, 128);
            Deletebutton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebutton1.Location = new Point(993, 273);
            Deletebutton1.Name = "Deletebutton1";
            Deletebutton1.Size = new Size(356, 40);
            Deletebutton1.TabIndex = 9;
            Deletebutton1.Text = "Delete";
            Deletebutton1.UseVisualStyleBackColor = false;
            Deletebutton1.Click += Deletebutton1_Click;
            // 
            // Updatebutton2
            // 
            Updatebutton2.BackColor = Color.FromArgb(128, 255, 128);
            Updatebutton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatebutton2.Location = new Point(510, 273);
            Updatebutton2.Name = "Updatebutton2";
            Updatebutton2.Size = new Size(396, 40);
            Updatebutton2.TabIndex = 10;
            Updatebutton2.Text = "Update";
            Updatebutton2.UseVisualStyleBackColor = false;
            Updatebutton2.Click += Updatebutton2_Click;
            // 
            // EmployeedcheckBox1
            // 
            EmployeedcheckBox1.AutoSize = true;
            EmployeedcheckBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeedcheckBox1.Location = new Point(290, 39);
            EmployeedcheckBox1.Name = "EmployeedcheckBox1";
            EmployeedcheckBox1.Size = new Size(121, 27);
            EmployeedcheckBox1.TabIndex = 12;
            EmployeedcheckBox1.Text = "Employeed";
            EmployeedcheckBox1.UseVisualStyleBackColor = true;
            EmployeedcheckBox1.CheckedChanged += EmployeedcheckBox1_CheckedChanged;
            // 
            // UnEmployeedcheckBox2
            // 
            UnEmployeedcheckBox2.AutoSize = true;
            UnEmployeedcheckBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnEmployeedcheckBox2.Location = new Point(84, 39);
            UnEmployeedcheckBox2.Name = "UnEmployeedcheckBox2";
            UnEmployeedcheckBox2.Size = new Size(143, 27);
            UnEmployeedcheckBox2.TabIndex = 15;
            UnEmployeedcheckBox2.Text = "UnEmployeed";
            UnEmployeedcheckBox2.UseVisualStyleBackColor = true;
            UnEmployeedcheckBox2.CheckedChanged += UnEmployeedcheckBox2_CheckedChanged;
            // 
            // MaleradioButton1
            // 
            MaleradioButton1.AutoSize = true;
            MaleradioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaleradioButton1.Location = new Point(252, 142);
            MaleradioButton1.Name = "MaleradioButton1";
            MaleradioButton1.Size = new Size(70, 27);
            MaleradioButton1.TabIndex = 16;
            MaleradioButton1.TabStop = true;
            MaleradioButton1.Text = "Male";
            MaleradioButton1.UseVisualStyleBackColor = true;
            // 
            // OtherradioButton1
            // 
            OtherradioButton1.AutoSize = true;
            OtherradioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OtherradioButton1.Location = new Point(510, 142);
            OtherradioButton1.Name = "OtherradioButton1";
            OtherradioButton1.Size = new Size(77, 27);
            OtherradioButton1.TabIndex = 17;
            OtherradioButton1.TabStop = true;
            OtherradioButton1.Text = "Other";
            OtherradioButton1.UseVisualStyleBackColor = true;
            // 
            // FemaleradioButton2
            // 
            FemaleradioButton2.AutoSize = true;
            FemaleradioButton2.BackgroundImageLayout = ImageLayout.Center;
            FemaleradioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FemaleradioButton2.Location = new Point(371, 142);
            FemaleradioButton2.Name = "FemaleradioButton2";
            FemaleradioButton2.Size = new Size(88, 27);
            FemaleradioButton2.TabIndex = 18;
            FemaleradioButton2.TabStop = true;
            FemaleradioButton2.Text = "Female";
            FemaleradioButton2.UseVisualStyleBackColor = true;
            // 
            // genderlabel3
            // 
            genderlabel3.AutoSize = true;
            genderlabel3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderlabel3.Location = new Point(78, 142);
            genderlabel3.Name = "genderlabel3";
            genderlabel3.Size = new Size(136, 23);
            genderlabel3.TabIndex = 19;
            genderlabel3.Text = "Select Gender  :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 192);
            groupBox2.Controls.Add(EmployeedcheckBox1);
            groupBox2.Controls.Add(UnEmployeedcheckBox2);
            groupBox2.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(886, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(528, 108);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Working Status";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 333);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1724, 339);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1383, 273);
            button1.Name = "button1";
            button1.Size = new Size(317, 40);
            button1.TabIndex = 22;
            button1.Text = "Documents Upaloads ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1724, 684);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(genderlabel3);
            Controls.Add(FemaleradioButton2);
            Controls.Add(OtherradioButton1);
            Controls.Add(MaleradioButton1);
            Controls.Add(Updatebutton2);
            Controls.Add(Deletebutton1);
            Controls.Add(Savebutton1);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(Universityabel2);
            Controls.Add(comboBox1);
            Controls.Add(lastnameBox1);
            Controls.Add(label1);
            Controls.Add(fristNmtextBox);
            Controls.Add(fristNmlabel);
            Name = "Form1";
            Text = "User Registration From";
            Load += Form1_Load;
            DoubleClick += Form1_DoubleClick;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fristNmlabel;
        private TextBox fristNmtextBox;
        private Label label1;
        private TextBox lastnameBox1;
        private ComboBox comboBox1;
        private Label Universityabel2;
        private Label label2;
        private ComboBox comboBox2;
        private Button Savebutton1;
        private Button Deletebutton1;
        private Button Updatebutton2;
        private CheckBox EmployeedcheckBox1;
        private CheckBox UnEmployeedcheckBox2;
        private RadioButton MaleradioButton1;
        private RadioButton OtherradioButton1;
        private RadioButton FemaleradioButton2;
        private Label genderlabel3;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
