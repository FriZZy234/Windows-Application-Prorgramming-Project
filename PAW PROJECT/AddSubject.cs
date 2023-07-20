using PAW_PROJECT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PAW_PROJECT
{
    public partial class AddSubject : Form
    {
        private List<Subject> subjects;
        private ErrorProvider errorProvider;

        public AddSubject()
        {
            InitializeComponent();
            subjects = new List<Subject>();
            errorProvider = new ErrorProvider();
            AddSubjectForm_Load(null, EventArgs.Empty);
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {
            listViewsubject.Columns.Add("Subject ID", 80);
            listViewsubject.Columns.Add("Subject Name", 120);
            listViewsubject.Columns.Add("Teacher ID", 80);
            listViewsubject.Columns.Add("Teacher", 120);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void AddsubjectButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int subjectID = Convert.ToInt32(subIDb.Text);
                string subjectName = subNameb.Text;
                int teacherID = Convert.ToInt32(subteacherIDb.Text);
                string teacher = subteacherNameb.Text;

                try
                {
                    Subject newSubject = new Subject(subjectID, subjectName, teacherID, teacher);
                    subjects.Add(newSubject);

                    bool itemExists = false;
                    foreach (ListViewItem item in listViewsubject.Items)
                    {
                        if (item.SubItems[0].Text == subjectID.ToString())
                        {
                            item.SubItems[1].Text = subjectName;
                            item.SubItems[2].Text = teacherID.ToString();
                            item.SubItems[3].Text = teacher;
                            itemExists = true;
                            break;
                        }
                    }

                    
                    if (!itemExists)
                    {
                        ListViewItem newItem = new ListViewItem(subjectID.ToString());
                        newItem.SubItems.Add(subjectName);
                        newItem.SubItems.Add(teacherID.ToString());
                        newItem.SubItems.Add(teacher);
                        listViewsubject.Items.Add(newItem);
                    }


                    
                    MessageBox.Show("Subject added successfully!");
                }
                catch (DuplicateSubjectIDException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the subject: " + ex.Message);
                }
            }
        }

        private bool ValidateInput()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(subIDb.Text))
            {
                errorProvider.SetError(subIDb, "Please enter a subject ID.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(subNameb.Text))
            {
                errorProvider.SetError(subNameb, "Please enter a subject name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(subteacherIDb.Text))
            {
                errorProvider.SetError(subteacherIDb, "Please enter a teacher ID.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(subteacherNameb.Text))
            {
                errorProvider.SetError(subteacherNameb, "Please enter a teacher name.");
                return false;
            }

            int subjectID;
            if (!int.TryParse(subIDb.Text, out subjectID))
            {
                errorProvider.SetError(subIDb, "Invalid subject ID. Please enter a valid integer value.");
                return false;
            }

            int teacherID;
            if (!int.TryParse(subteacherIDb.Text, out teacherID))
            {
                errorProvider.SetError(subteacherIDb, "Invalid teacher ID. Please enter a valid integer value.");
                return false;
            }

            return true;
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (listViewsubject.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewsubject.SelectedItems[0];

                if (ValidateInput())
                {
                    int subjectID = Convert.ToInt32(subIDb.Text);
                    string subjectName = subNameb.Text;
                    int teacherID = Convert.ToInt32(subteacherIDb.Text);
                    string teacher = subteacherNameb.Text;

                    selectedItem.SubItems[0].Text = subjectID.ToString();
                    selectedItem.SubItems[1].Text = subjectName;
                    selectedItem.SubItems[2].Text = teacherID.ToString();
                    selectedItem.SubItems[3].Text = teacher;



                    MessageBox.Show("Subject updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to update.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listViewsubject.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewsubject.SelectedItems[0];
                listViewsubject.Items.Remove(selectedItem);
                MessageBox.Show("Subject deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a subject to delete.");
            }
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.Enter))
            {
                AddsubjectButton_Click(null, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

[Serializable]
internal class DuplicateSubjectIDException : Exception
{
    public DuplicateSubjectIDException()
    {
    }

    public DuplicateSubjectIDException(string message) : base(message)
    {
    }

    public DuplicateSubjectIDException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected DuplicateSubjectIDException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

}

