namespace ClubRegistration
{
    partial class FrmUpdateMember
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
            lblStudentId = new Label();
            cmbStudentId = new ComboBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            lblProgram = new Label();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Book Antiqua", 9.75F);
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(22, 18);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(73, 17);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // cmbStudentId
            // 
            cmbStudentId.BackColor = Color.White;
            cmbStudentId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentId.Font = new Font("Book Antiqua", 9.75F);
            cmbStudentId.ForeColor = Color.Black;
            cmbStudentId.FormattingEnabled = true;
            cmbStudentId.Location = new Point(25, 43);
            cmbStudentId.Name = "cmbStudentId";
            cmbStudentId.Size = new Size(280, 25);
            cmbStudentId.TabIndex = 2;
            cmbStudentId.SelectedIndexChanged += cmbStudentId_SelectedIndexChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Book Antiqua", 9.75F);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(25, 89);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(71, 17);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.Font = new Font("Book Antiqua", 9.75F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(25, 112);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 24);
            txtLastName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.FlatStyle = FlatStyle.Flat;
            lblFirstName.Font = new Font("Book Antiqua", 9.75F);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(25, 160);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(75, 17);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.Font = new Font("Book Antiqua", 9.75F);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(25, 183);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 24);
            txtFirstName.TabIndex = 6;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Book Antiqua", 9.75F);
            lblMiddleName.ForeColor = Color.Black;
            lblMiddleName.Location = new Point(25, 230);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(88, 17);
            lblMiddleName.TabIndex = 7;
            lblMiddleName.Text = "Middle name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.Font = new Font("Book Antiqua", 9.75F);
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(25, 253);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(280, 24);
            txtMiddleName.TabIndex = 8;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Book Antiqua", 9.75F);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(25, 303);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 17);
            lblAge.TabIndex = 9;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.Font = new Font("Book Antiqua", 9.75F);
            txtAge.ForeColor = Color.Black;
            txtAge.Location = new Point(25, 326);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(120, 24);
            txtAge.TabIndex = 10;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Book Antiqua", 9.75F);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(25, 372);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 17);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Book Antiqua", 9.75F);
            cmbGender.ForeColor = Color.Black;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(25, 395);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(180, 25);
            cmbGender.TabIndex = 12;
            // 
            // cmbProgram
            // 
            cmbProgram.BackColor = Color.White;
            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.Font = new Font("Book Antiqua", 9.75F);
            cmbProgram.ForeColor = Color.Black;
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(25, 460);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(280, 25);
            cmbProgram.TabIndex = 13;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Book Antiqua", 9.75F);
            lblProgram.ForeColor = Color.Black;
            lblProgram.Location = new Point(25, 437);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(61, 17);
            lblProgram.TabIndex = 14;
            lblProgram.Text = "Program:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(224, 224, 224);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Book Antiqua", 9.75F);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Location = new Point(104, 508);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(122, 39);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(333, 568);
            Controls.Add(btnConfirm);
            Controls.Add(lblProgram);
            Controls.Add(cmbProgram);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(cmbStudentId);
            Controls.Add(lblStudentId);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(236, 239, 244);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateMember";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Member";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private ComboBox cmbStudentId;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private Label lblProgram;
        private Button btnConfirm;
    }
}