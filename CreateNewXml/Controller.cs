using System;
using System.IO;
using System.Xml;

namespace CreateNewXml
{

    public class Controller
    {
        const string FILE_LOCATION_XML = "student.xml";
        private readonly XmlDocument studentDoc;
        private readonly XmlNode root;
        private XmlNode nodeName;
        private XmlNode nodeFName;
        private XmlNode nodeLName;
        private XmlNode nodeCourse;
        private XmlNode nodeStartDate;
        private XmlNode nodeDuration;

        public Controller()
        {
            studentDoc = new XmlDocument();
            if (File.Exists(FILE_LOCATION_XML))
            {
                //student.xml exists
                studentDoc.Load(FILE_LOCATION_XML);
                root = studentDoc.FirstChild;
            }
            else
            {
                //student.xml does not exist
                root = studentDoc.CreateElement("students");
                studentDoc.AppendChild(root);
            }
        }


        public void RemoveElement(string toRemove)
        {
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
            studentDoc.Save(FILE_LOCATION_XML);
            studentDoc.Load(FILE_LOCATION_XML);
        }

        public void AddElement(string firstName, string lastName, string course, string startDate, string Duration)
        {
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

                studentDoc.Save(FILE_LOCATION_XML);
            }
        }

        public string DisplayAll()
        {
            XmlNodeList students = root.SelectNodes("student");
            string tmp = "";
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


        public string[] LoadAllStudents()
        {
            XmlNodeList students = root.SelectNodes("student");
            string[] output = new string[students.Count];
            int i = 0;

            foreach (XmlNode n in students)
            {
                output[i] = (n.SelectSingleNode("studentName/firstName").InnerText + " "
                    + n.SelectSingleNode("studentName/lastName").InnerText + " | "
                    + "Course: " + n.SelectSingleNode("courseName").InnerText
                    + "Start Date : " + n.SelectSingleNode("startDate").InnerText
                    + "Duration : " + n.SelectSingleNode("Duration").InnerText);
                i++;
            }
            return output;
        }





    }
}
