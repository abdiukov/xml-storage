namespace CreateNewXml
{
    partial class Form1
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
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonAddElement = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRemove = new System.Windows.Forms.Panel();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.buttonRemoveElement = new System.Windows.Forms.Button();
            this.panelDisp = new System.Windows.Forms.Panel();
            this.buttonList = new System.Windows.Forms.Button();
            this.panelList = new System.Windows.Forms.Panel();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelAdd.SuspendLayout();
            this.panelRemove.SuspendLayout();
            this.panelList.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(223, 8);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(147, 38);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Remove element";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(8, 8);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 38);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add element";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.label7);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.textBoxDuration);
            this.panelAdd.Controls.Add(this.textBoxStartDate);
            this.panelAdd.Controls.Add(this.comboBoxCourses);
            this.panelAdd.Controls.Add(this.textBoxLastName);
            this.panelAdd.Controls.Add(this.textBoxFirstName);
            this.panelAdd.Controls.Add(this.buttonAddElement);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Location = new System.Drawing.Point(8, 234);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(367, 169);
            this.panelAdd.TabIndex = 1;
            this.panelAdd.Visible = false;
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Items.AddRange(new object[] {
            "Web development",
            "Coding - Python",
            "Cyber security"});
            this.comboBoxCourses.Location = new System.Drawing.Point(104, 62);
            this.comboBoxCourses.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(122, 26);
            this.comboBoxCourses.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(104, 33);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(122, 25);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(104, 4);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(122, 25);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // buttonAddElement
            // 
            this.buttonAddElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddElement.Location = new System.Drawing.Point(241, 63);
            this.buttonAddElement.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddElement.Name = "buttonAddElement";
            this.buttonAddElement.Size = new System.Drawing.Size(93, 25);
            this.buttonAddElement.TabIndex = 4;
            this.buttonAddElement.Text = "Add element";
            this.buttonAddElement.UseVisualStyleBackColor = true;
            this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Course name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Remove an element";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRemove
            // 
            this.panelRemove.Controls.Add(this.listBoxStudents);
            this.panelRemove.Controls.Add(this.label2);
            this.panelRemove.Controls.Add(this.buttonRemoveElement);
            this.panelRemove.Location = new System.Drawing.Point(395, 51);
            this.panelRemove.Margin = new System.Windows.Forms.Padding(2);
            this.panelRemove.Name = "panelRemove";
            this.panelRemove.Size = new System.Drawing.Size(367, 169);
            this.panelRemove.TabIndex = 1;
            this.panelRemove.Visible = false;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 18;
            this.listBoxStudents.Location = new System.Drawing.Point(11, 44);
            this.listBoxStudents.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(347, 58);
            this.listBoxStudents.TabIndex = 1;
            // 
            // buttonRemoveElement
            // 
            this.buttonRemoveElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveElement.Location = new System.Drawing.Point(125, 135);
            this.buttonRemoveElement.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveElement.Name = "buttonRemoveElement";
            this.buttonRemoveElement.Size = new System.Drawing.Size(121, 25);
            this.buttonRemoveElement.TabIndex = 4;
            this.buttonRemoveElement.Text = "Remove element";
            this.buttonRemoveElement.UseVisualStyleBackColor = true;
            this.buttonRemoveElement.Click += new System.EventHandler(this.buttonRemoveElement_Click);
            // 
            // panelDisp
            // 
            this.panelDisp.Location = new System.Drawing.Point(8, 51);
            this.panelDisp.Margin = new System.Windows.Forms.Padding(2);
            this.panelDisp.Name = "panelDisp";
            this.panelDisp.Size = new System.Drawing.Size(367, 169);
            this.panelDisp.TabIndex = 1;
            // 
            // buttonList
            // 
            this.buttonList.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.Location = new System.Drawing.Point(127, 8);
            this.buttonList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(92, 38);
            this.buttonList.TabIndex = 0;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.textBoxDetails);
            this.panelList.Controls.Add(this.label6);
            this.panelList.Location = new System.Drawing.Point(395, 230);
            this.panelList.Margin = new System.Windows.Forms.Padding(2);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(367, 169);
            this.panelList.TabIndex = 1;
            this.panelList.Visible = false;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetails.Location = new System.Drawing.Point(15, 49);
            this.textBoxDetails.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDetails.Size = new System.Drawing.Size(345, 114);
            this.textBoxDetails.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "List all";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartDate.Location = new System.Drawing.Point(104, 92);
            this.textBoxStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(122, 25);
            this.textBoxStartDate.TabIndex = 5;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuration.Location = new System.Drawing.Point(104, 121);
            this.textBoxDuration.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(122, 25);
            this.textBoxDuration.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Duration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 409);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelRemove);
            this.Controls.Add(this.panelDisp);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Student XML doc - create, add, remove";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelRemove.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelRemove;
        private System.Windows.Forms.Panel panelDisp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonAddElement;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Button buttonRemoveElement;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxStartDate;
    }
}

