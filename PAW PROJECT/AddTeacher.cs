using PAW_PROJECT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PAW_PROJECT
{
    public partial class AddTeacher : Form
    {
        private Teacher teacher;
        private List<Teacher> teachers;
        private string filePath = "teacherfile.json"; 

        public AddTeacher()
        {
            InitializeComponent();
            teachers = new List<Teacher>();
        }

        private void SaveTBtn_Click(object sender, EventArgs e)
        {
            teacher = new Teacher(TnameButt.Text, int.Parse(teacheridtxt.Text), int.Parse(numberttxt.Text));
            teachers.Add(teacher);

            
            ListViewItem item = new ListViewItem(teacher.Name);
            item.SubItems.Add(teacher.TeacherID.ToString());
            item.SubItems.Add(teacher.PhoneNumber.ToString());

            
            listView1.Items.Add(item);

            SaveTeachers();

            DialogResult = DialogResult.OK;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                selectedItem.SubItems[0].Text = TnameButt.Text;
                selectedItem.SubItems[1].Text = teacheridtxt.Value.ToString();
                selectedItem.SubItems[2].Text = numberttxt.Text;

                SaveTeachers();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                listView1.Items.Remove(selectedItem);

                SaveTeachers();
            }
        }

        private void LoadTeachers()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                teachers = JsonConvert.DeserializeObject<List<Teacher>>(json);
                UpdateListView();
            }
        }

        private void SaveTeachers()
        {
            string json = JsonConvert.SerializeObject(teachers);
            File.WriteAllText(filePath, json);
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();

            foreach (Teacher teacher in teachers)
            {
                ListViewItem item = new ListViewItem(teacher.Name);
                item.SubItems.Add(teacher.TeacherID.ToString());
                item.SubItems.Add(teacher.PhoneNumber.ToString());
                listView1.Items.Add(item);
            }
        }

        private void BackTBTN_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        

   

        private void SerializeButton_Click_1(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(teachers);
            
            MessageBox.Show("Teachers serialized successfully!");
        }

        private void DeserializeButton_Click_1(object sender, EventArgs e)
        {
            string json = File.ReadAllText(filePath);
            teachers = JsonConvert.DeserializeObject<List<Teacher>>(json);
            UpdateListView();
            
            MessageBox.Show("Teachers deserialized successfully!");
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files|*.txt";
            saveFileDialog.Title = "Export Report";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Teacher teacher in teachers)
                    {
                        writer.WriteLine($"Name: {teacher.Name}");
                        writer.WriteLine($"Teacher ID: {teacher.TeacherID}");
                        writer.WriteLine($"Phone Number: {teacher.PhoneNumber}");
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Report exported successfully!");
            }

        }
    }
}
