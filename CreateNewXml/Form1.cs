using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CreateNewXml
{
    public partial class Form1 : Form
    {
        String fileName = "student.xml";
        XmlDocument studentDoc;
        XmlNode root, nodeName, nodeFName, nodeLName, nodeCourse, nodeStartDate, nodeDuration;

        public Form1()
        {
            InitializeComponent();
            studentDoc = new XmlDocument();
            if (File.Exists(fileName))
            {
                //student.xml exists
                studentDoc.Load(fileName);
                root = studentDoc.FirstChild;
            }
            else
            {
                //student.xml does not exist
                root = studentDoc.CreateElement("students");
                studentDoc.AppendChild(root);
            }
        }

        private void buttonRemoveElement_Click(object sender, EventArgs e)
        {
            string toRemove = listBoxStudents.SelectedItem.ToString();
            string[] fields = toRemove.Split('|');
            string[] first_last = fields[0].Split();
            XmlNodeList students = root.SelectNodes("student");

            foreach (XmlNode n in students)
            {
                if ((n.SelectSingleNode("studentName/firstName").InnerText == first_last[0]) &&
                    (n.SelectSingleNode("studentName/lastName").InnerText == first_last[1]))
                {
                    root.RemoveChild(n);
                }
            }
            studentDoc.Save(fileName);
            studentDoc.Load(fileName);
            buttonList_Click(sender, e);
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelRemove.Visible = false;
            panelDisp.Visible = false;
            panelList.Location = panelDisp.Location;
            panelList.Visible = true;
            textBoxDetails.Text = displayAll();
            
        }

        private String displayAll()
        {
            XmlNodeList students = root.SelectNodes("student");
            String tmp = "";
            foreach (XmlNode n in students)
            {
                tmp += "Name: " + n.SelectSingleNode("studentName/firstName").InnerText + " "
                    + n.SelectSingleNode("studentName/lastName").InnerText + " | "
                    + "Course: " + n.SelectSingleNode("courseName").InnerText + Environment.NewLine
                    + "Start Date : " + n.SelectSingleNode("startDate").InnerText + Environment.NewLine
                    + "Duration : " + n.SelectSingleNode("Duration").InnerText + Environment.NewLine;
            }
            return tmp;
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelList.Visible = false;
            panelDisp.Visible = false;
            panelRemove.Location = panelDisp.Location;
            panelRemove.Visible = true;
            loadStudents();
        }

        private void loadStudents()
        {
            XmlNodeList students = root.SelectNodes("student");
            listBoxStudents.Items.Clear();
            foreach (XmlNode n in students)
            {
                listBoxStudents.Items.Add(n.SelectSingleNode("studentName/firstName").InnerText + " "
                    + n.SelectSingleNode("studentName/lastName").InnerText + " | "
                    + "Course: " + n.SelectSingleNode("courseName").InnerText
                    + "Start Date : " + n.SelectSingleNode("startDate").InnerText
                    + "Duration : " + n.SelectSingleNode("Duration").InnerText);
            }
        }
        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            String firstName, lastName, course, startDate, Duration;
            firstName = textBoxFirstName.Text;
            lastName = textBoxLastName.Text;
            course = comboBoxCourses.SelectedItem.ToString();
            startDate = textBoxStartDate.Text;
            Duration = textBoxDuration.Text;

            

            if (firstName.Length > 0 && lastName.Length > 0 && course.Length > 0
                && startDate.Length > 0 && Duration.Length > 0)
            {
                XmlNode student = studentDoc.CreateElement("student");
                root.AppendChild(student);
                nodeName = studentDoc.CreateElement("studentName");

                nodeFName = studentDoc.CreateElement("firstName");
                nodeFName.InnerText = firstName;
                nodeName.AppendChild(nodeFName);

                nodeLName = studentDoc.CreateElement("lastName");
                nodeLName.InnerText = lastName;
                nodeName.AppendChild(nodeLName);

                student.AppendChild(nodeName);

                nodeCourse = studentDoc.CreateElement("courseName");
                nodeCourse.InnerText = course;
                student.AppendChild(nodeCourse);

                nodeStartDate = studentDoc.CreateElement("startDate");
                nodeStartDate.InnerText = startDate;
                student.AppendChild(nodeStartDate);

                nodeDuration = studentDoc.CreateElement("Duration");
                nodeDuration.InnerText = Duration;
                student.AppendChild(nodeDuration);

                studentDoc.Save(fileName);
            }
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxDuration.Clear();
            textBoxStartDate.Clear();
            comboBoxCourses.Text = "";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            panelDisp.Visible = false;
            panelRemove.Visible = false;
            panelList.Visible = false;
            panelAdd.Location = panelDisp.Location;
            panelAdd.Visible = true;
        }


    }
}
