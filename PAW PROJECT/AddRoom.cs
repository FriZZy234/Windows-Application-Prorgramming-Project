using PAW_PROJECT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAW_PROJECT
{
    public partial class AddRoom : Form
    {

        private List<Room> rooms;
        public AddRoom()
        {
            InitializeComponent();
            rooms = new List<Room>();
            AddRoomForm_Load(null, EventArgs.Empty);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void AddRoomForm_Load(object sender, EventArgs e)
        {

            listViewroom.Columns.Add("Room ID", 80);
            listViewroom.Columns.Add("Room Number", 100);
            listViewroom.Columns.Add("Availability", 100);
            listViewroom.Columns.Add("Subject ID", 80);
        }

        private void button1_Click(object sender, EventArgs e)

        {

            int RoomID = Convert.ToInt32(roomIDb.Text);
            int RoomNumber = Convert.ToInt32(roomNb.Text);
            bool Availability = AvailB.Checked;
            int SubjectID = Convert.ToInt32(roomSb.Text);

            bool itemExists = false;

            
            foreach (ListViewItem item in listViewroom.Items)
            {
                if (item.SubItems[0].Text == RoomID.ToString())
                {
                    item.SubItems[1].Text = RoomNumber.ToString();
                    item.SubItems[2].Text = Availability.ToString();
                    item.SubItems[3].Text = SubjectID.ToString();
                    itemExists = true;
                    break;
                }
            }

           
            if (!itemExists)
            {
                ListViewItem newItem = new ListViewItem(RoomID.ToString());
                newItem.SubItems.Add(RoomNumber.ToString());
                newItem.SubItems.Add(Availability.ToString());
                newItem.SubItems.Add(SubjectID.ToString());
                listViewroom.Items.Add(newItem);
            }

            DialogResult = DialogResult.OK;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (listViewroom.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = listViewroom.SelectedItems[0];

                int roomID = Convert.ToInt32(roomIDb.Text);
                int roomNumber = Convert.ToInt32(roomNb.Text);
                bool availability = AvailB.Checked;
                int subjectID = Convert.ToInt32(roomSb.Text);


                selectedItem.SubItems[0].Text = roomID.ToString();
                selectedItem.SubItems[1].Text = roomNumber.ToString();
                selectedItem.SubItems[2].Text = availability.ToString();
                selectedItem.SubItems[3].Text = subjectID.ToString();


                roomIDb.Text = "";
                roomNb.Text = "";
                AvailB.Checked = false;
                roomSb.Text = "";

                MessageBox.Show("Room updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a room to update.");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (listViewroom.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewroom.SelectedItems[0];


                listViewroom.Items.Remove(selectedItem);

                MessageBox.Show("Room deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a room to delete.");
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintDocument_PrintPage;

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            Font font = new Font("Arial", 12);
            int margin = 50;
            int lineHeight = font.Height + 5;

            
            float startX = margin;
            float startY = margin;

            
            foreach (ColumnHeader columnHeader in listViewroom.Columns)
            {
                e.Graphics.DrawString(columnHeader.Text, font, Brushes.Black, startX, startY);
                startX += columnHeader.Width;
            }

            
            startY += lineHeight;

            
            foreach (ListViewItem item in listViewroom.Items)
            {
                startX = margin;

                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    e.Graphics.DrawString(subItem.Text, font, Brushes.Black, startX, startY);
                    startX += listViewroom.Columns[item.SubItems.IndexOf(subItem)].Width;
                }

                
                startY += lineHeight;
            }
        }

    }



}





