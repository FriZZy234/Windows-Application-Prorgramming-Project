using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_PROJECT
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AddTeacher();
            form.Show();
            this.Hide();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form= new AddRoom();
            form.Show(); this.Hide();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form=new AddSubject();
            form.Show(); this.Hide();
        }

        private void contextMenuStrip4_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip4.Show(button1,0,button1.Height);
        }

        private void teacherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form form = new AddTeacher();
            form.Show(); this.Hide();
        }

        private void roomToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form form = new AddRoom();
            form.Show(); this.Hide();
        }

        private void subjectToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form form= new AddSubject();
            form.Show(); this.Hide();   
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
