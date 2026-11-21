namespace ClubRegistration
{
    partial class FrmClubRegistration
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnRegister = new Button();
            btnUpdate = new Button();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            lblGender = new Label();
            lblAge = new Label();
            txtAge = new TextBox();
            txtMiddleName = new TextBox();
            lblMiddleName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            lblProgram = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            button1 = new Button();
            dataGridView = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(224, 224, 224);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Book Antiqua", 9.75F);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(861, 73);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(122, 39);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Book Antiqua", 9.75F);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(861, 149);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 39);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Book Antiqua", 9.75F);
            cmbGender.ForeColor = Color.Black;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(218, 185);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(170, 25);
            cmbGender.TabIndex = 28;
            // 
            // cmbProgram
            // 
            cmbProgram.BackColor = Color.White;
            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.Font = new Font("Book Antiqua", 9.75F);
            cmbProgram.ForeColor = Color.Black;
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science", "BS in Hospitality Management", "BS in Business Administration" });
            cmbProgram.Location = new Point(218, 55);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(281, 25);
            cmbProgram.TabIndex = 27;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.FromArgb(224, 224, 224);
            lblGender.Font = new Font("Book Antiqua", 9.75F);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(218, 160);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 17);
            lblGender.TabIndex = 26;
            lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.FromArgb(224, 224, 224);
            lblAge.Font = new Font("Book Antiqua", 9.75F);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(25, 160);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 17);
            lblAge.TabIndex = 25;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.Font = new Font("Book Antiqua", 9.75F);
            txtAge.ForeColor = Color.Black;
            txtAge.Location = new Point(28, 185);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 24);
            txtAge.TabIndex = 24;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.Font = new Font("Book Antiqua", 9.75F);
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(408, 120);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(170, 24);
            txtMiddleName.TabIndex = 23;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.BackColor = Color.FromArgb(224, 224, 224);
            lblMiddleName.Font = new Font("Book Antiqua", 9.75F);
            lblMiddleName.ForeColor = Color.Black;
            lblMiddleName.Location = new Point(405, 95);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(88, 17);
            lblMiddleName.TabIndex = 22;
            lblMiddleName.Text = "Middle name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.Font = new Font("Book Antiqua", 9.75F);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(218, 120);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 24);
            txtFirstName.TabIndex = 21;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.FromArgb(224, 224, 224);
            lblFirstName.Font = new Font("Book Antiqua", 9.75F);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(215, 95);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(75, 17);
            lblFirstName.TabIndex = 20;
            lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.Font = new Font("Book Antiqua", 9.75F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(28, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(170, 24);
            txtLastName.TabIndex = 19;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.FromArgb(224, 224, 224);
            lblLastName.Font = new Font("Book Antiqua", 9.75F);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(25, 95);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(71, 17);
            lblLastName.TabIndex = 18;
            lblLastName.Text = "Last name:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.BackColor = Color.FromArgb(224, 224, 224);
            lblProgram.Font = new Font("Book Antiqua", 9.75F);
            lblProgram.ForeColor = Color.Black;
            lblProgram.Location = new Point(218, 30);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(61, 17);
            lblProgram.TabIndex = 17;
            lblProgram.Text = "Program:";
            // 
            // txtStudentId
            // 
            txtStudentId.BackColor = Color.White;
            txtStudentId.Font = new Font("Book Antiqua", 9.75F);
            txtStudentId.ForeColor = Color.Black;
            txtStudentId.Location = new Point(28, 55);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(170, 24);
            txtStudentId.TabIndex = 16;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.FromArgb(224, 224, 224);
            lblStudentId.Font = new Font("Book Antiqua", 9.75F);
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(25, 30);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(73, 17);
            lblStudentId.TabIndex = 15;
            lblStudentId.Text = "Student ID:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(861, 366);
            button1.Name = "button1";
            button1.Size = new Size(122, 39);
            button1.TabIndex = 29;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(215, 215, 215);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Book Antiqua", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 36;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Book Antiqua", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(236, 239, 244);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(215, 215, 215);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(220, 220, 220);
            dataGridView.Location = new Point(12, 297);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Book Antiqua", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(215, 215, 215);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowTemplate.Height = 32;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(840, 188);
            dataGridView.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 222);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Book Antiqua", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 268);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 32;
            label1.Text = "List of Club Members";
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(995, 498);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Controls.Add(button1);
            Controls.Add(cmbGender);
            Controls.Add(cmbProgram);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(lblProgram);
            Controls.Add(txtStudentId);
            Controls.Add(lblStudentId);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(236, 239, 244);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmClubRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Registration";
            Load += FrmClubRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegister;
        private Button btnUpdate;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private Label lblGender;
        private Label lblAge;
        private TextBox txtAge;
        private TextBox txtMiddleName;
        private Label lblMiddleName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private Label lblProgram;
        private TextBox txtStudentId;
        private Label lblStudentId;
        private Button button1;
        private DataGridView dataGridView;
        private Panel panel1;
        private Label label1;
    }
}