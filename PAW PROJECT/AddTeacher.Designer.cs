namespace PAW_PROJECT
{
    partial class AddTeacher
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
            this.TnameButt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teacheridtxt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveTBtn = new System.Windows.Forms.Button();
            this.BackTBTN = new System.Windows.Forms.Button();
            this.numberttxt = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacheridtxt)).BeginInit();
            this.SuspendLayout();
            // 
            // TnameButt
            // 
            this.TnameButt.Location = new System.Drawing.Point(408, 78);
            this.TnameButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TnameButt.Name = "TnameButt";
            this.TnameButt.Size = new System.Drawing.Size(234, 26);
            this.TnameButt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teacher ID";
            // 
            // teacheridtxt
            // 
            this.teacheridtxt.Location = new System.Drawing.Point(408, 166);
            this.teacheridtxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacheridtxt.Name = "teacheridtxt";
            this.teacheridtxt.Size = new System.Drawing.Size(236, 26);
            this.teacheridtxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // SaveTBtn
            // 
            this.SaveTBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTBtn.Location = new System.Drawing.Point(992, 605);
            this.SaveTBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveTBtn.Name = "SaveTBtn";
            this.SaveTBtn.Size = new System.Drawing.Size(140, 65);
            this.SaveTBtn.TabIndex = 6;
            this.SaveTBtn.Text = "ADD";
            this.SaveTBtn.UseVisualStyleBackColor = true;
            this.SaveTBtn.Click += new System.EventHandler(this.SaveTBtn_Click);
            // 
            // BackTBTN
            // 
            this.BackTBTN.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackTBTN.Location = new System.Drawing.Point(20, 605);
            this.BackTBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackTBTN.Name = "BackTBTN";
            this.BackTBTN.Size = new System.Drawing.Size(124, 65);
            this.BackTBTN.TabIndex = 7;
            this.BackTBTN.Text = "BACK";
            this.BackTBTN.UseVisualStyleBackColor = true;
            this.BackTBTN.Click += new System.EventHandler(this.BackTBTN_Click);
            // 
            // numberttxt
            // 
            this.numberttxt.Location = new System.Drawing.Point(408, 242);
            this.numberttxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberttxt.Name = "numberttxt";
            this.numberttxt.Size = new System.Drawing.Size(234, 26);
            this.numberttxt.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(72, 345);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(979, 204);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(642, 605);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(123, 65);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(813, 605);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 65);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Location = new System.Drawing.Point(726, 270);
            this.DeserializeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(153, 65);
            this.DeserializeButton.TabIndex = 12;
            this.DeserializeButton.Text = "DESERIALIZE";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click_1);
            // 
            // SerializeButton
            // 
            this.SerializeButton.Location = new System.Drawing.Point(911, 270);
            this.SerializeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(123, 65);
            this.SerializeButton.TabIndex = 13;
            this.SerializeButton.Text = "SERIALIZE";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click_1);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(487, 605);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(123, 65);
            this.ExportButton.TabIndex = 14;
            this.ExportButton.Text = "EXPORT";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.SerializeButton);
            this.Controls.Add(this.DeserializeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.numberttxt);
            this.Controls.Add(this.BackTBTN);
            this.Controls.Add(this.SaveTBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacheridtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TnameButt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.teacheridtxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TnameButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown teacheridtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveTBtn;
        private System.Windows.Forms.Button BackTBTN;
        private System.Windows.Forms.TextBox numberttxt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button ExportButton;
    }
}