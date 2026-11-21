using System;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int Age;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void RefreshListOfClubMembers()
        {
            try
            {
                if (clubRegistrationQuery.DisplayList())
                {
                    dataGridView.DataSource = clubRegistrationQuery.bindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn’t load the member list right now.\n\nError info: " + ex.Message, "List Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                clubRegistrationQuery = new ClubRegistrationQuery();

                cmbGender.Items.Clear();
                cmbGender.Items.AddRange(new object[] { "Male", "Female" });

                cmbProgram.Items.Clear();
                cmbProgram.Items.AddRange(new object[] {
                    "BS in Information Technology",
                    "BS in Computer Science",
                    "BS in Hospitality Management",
                    "BS in Business Administration"
                });

                RefreshListOfClubMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while opening the form.\n\nDetails: " + ex.Message, "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            cmbProgram.SelectedIndex = -1;
            txtStudentId.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtStudentId.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    MessageBox.Show("Oops! Please fill out all required fields first.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(txtStudentId.Text.Trim(), out StudentId) || StudentId <= 0)
                {
                    MessageBox.Show("Please enter a valid, positive Student ID number.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStudentId.Focus();
                    return;
                }

                if (!int.TryParse(txtAge.Text.Trim(), out Age) || Age < 1 || Age > 120)
                {
                    MessageBox.Show("Age should be a real number between 1 and 120.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAge.Focus();
                    return;
                }

                if (cmbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Don’t forget to pick a gender from the list.", "Gender Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbProgram.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose your program from the dropdown.", "Program Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FirstName = txtFirstName.Text.Trim();
                MiddleName = txtMiddleName.Text.Trim();
                LastName = txtLastName.Text.Trim();
                Gender = cmbGender.Text;
                Program = cmbProgram.Text;

                if (clubRegistrationQuery.RegisterStudent(StudentId, FirstName, MiddleName, LastName, Age, Gender, Program))
                {
                    MessageBox.Show("Great! New member has been added successfully.", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    RefreshListOfClubMembers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We ran into an issue while saving this member.\n\nWhat happened: " + ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
                frmUpdateMember.ShowDialog();
                RefreshListOfClubMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn’t bring up the update form right now.\n\nReason: " + ex.Message, "Update Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
