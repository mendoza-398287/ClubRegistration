using System;
using System.Data;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;

        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
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

                cmbStudentId.Items.Clear();
                if (clubRegistrationQuery.DisplayList())
                {
                    foreach (DataRow memberRow in clubRegistrationQuery.dataTable.Rows)
                    {
                        cmbStudentId.Items.Add(memberRow["StudentId"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn’t set up the update form correctly.\n\nError: " + ex.Message, "Form Loading Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!long.TryParse(cmbStudentId.Text, out long studentId))
                {
                    MessageBox.Show("That Student ID doesn’t seem right — pick another one.", "Incorrect Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clubRegistrationQuery.GetMember(studentId))
                {
                    txtLastName.Text = clubRegistrationQuery._LastName;
                    txtFirstName.Text = clubRegistrationQuery._FirstName;
                    txtMiddleName.Text = clubRegistrationQuery._MiddleName;
                    txtAge.Text = clubRegistrationQuery._Age.ToString();
                    cmbGender.SelectedItem = clubRegistrationQuery._Gender?.Trim();
                    cmbProgram.SelectedItem = clubRegistrationQuery._Program?.Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn’t load this member’s details.\n\nWhat went wrong: " + ex.Message, "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudentId.SelectedIndex == -1)
                {
                    MessageBox.Show("First, choose which student you want to edit.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(cmbStudentId.Text, out long studentId))
                {
                    MessageBox.Show("Hmm, that ID isn’t valid — select one from the list.", "Bad ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    MessageBox.Show("Please fill in the first name, last name, and age.", "Some Fields Are Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtAge.Text.Trim(), out int age) || age < 1 || age > 120)
                {
                    MessageBox.Show("Age needs to be between 1 and 120 — double-check it.", "Age Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAge.Focus();
                    return;
                }

                if (cmbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Make sure you select a gender from the options.", "Gender Not Chosen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbProgram.SelectedIndex == -1)
                {
                    MessageBox.Show("Pick the program the student is enrolled in.", "Program Not Chosen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clubRegistrationQuery.UpdateStudent(studentId, txtFirstName.Text.Trim(), txtMiddleName.Text.Trim(), txtLastName.Text.Trim(), age, cmbGender.Text, cmbProgram.Text))
                {
                    MessageBox.Show("All done! Member information has been saved.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn’t save the changes right now.\n\nDetails: " + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
