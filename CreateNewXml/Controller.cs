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
            string[] firstLastNames = fields[0].Split();
            XmlNodeList students = root.SelectNodes("student");

            foreach (XmlNode node in students)
            {
                if ((node.SelectSingleNode("studentName/firstName").InnerText == firstLastNames[0]) &&
                    (node.SelectSingleNode("studentName/lastName").InnerText == firstLastNames[1]))
                {
                    root.RemoveChild(node);
                }
            }
            studentDoc.Save(FILE_LOCATION_XML);
            studentDoc.Load(FILE_LOCATION_XML);
        }

        public void AddElement(string firstName, string lastName, string course, string startDate, string duration)
        {
            if (firstName.Length > 0 && lastName.Length > 0 && course.Length > 0
    && startDate.Length > 0 && duration.Length > 0)
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
                nodeDuration.InnerText = duration;
                student.AppendChild(nodeDuration);

                studentDoc.Save(FILE_LOCATION_XML);
            }
        }

        public string DisplayAll()
        {
            XmlNodeList students = root.SelectNodes("student");
            string output = "";
            foreach (XmlNode node in students)
            {
                output += "Name: " + node.SelectSingleNode("studentName/firstName").InnerText + " "
                    + node.SelectSingleNode("studentName/lastName").InnerText + " | "
                    + "Course: " + node.SelectSingleNode("courseName").InnerText + Environment.NewLine
                    + "Start Date : " + node.SelectSingleNode("startDate").InnerText + Environment.NewLine
                    + "Duration : " + node.SelectSingleNode("Duration").InnerText + Environment.NewLine;
            }
            return output;
        }


        public string[] LoadAllStudents()
        {
            XmlNodeList students = root.SelectNodes("student");
            string[] output = new string[students.Count];
            int i = 0;

            foreach (XmlNode node in students)
            {
                output[i] = (node.SelectSingleNode("studentName/firstName").InnerText + " "
                    + node.SelectSingleNode("studentName/lastName").InnerText + " | "
                    + "Course: " + node.SelectSingleNode("courseName").InnerText + " | "
                    + "Start Date : " + node.SelectSingleNode("startDate").InnerText + " | "
                    + "Duration : " + node.SelectSingleNode("Duration").InnerText) + " | ";
                i++;
            }
            return output;
        }





    }
}
