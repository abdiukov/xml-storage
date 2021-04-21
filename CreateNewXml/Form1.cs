using System;
using System.Windows.Forms;

namespace CreateNewXml
{
    public partial class Form1 : Form
    {
        private readonly Controller controller;
        public Form1()
        {
            InitializeComponent();
            this.controller = new Controller();
        }

        private void ButtonRemoveElement_Click(object sender, EventArgs e)
        {
            string toRemove = listBoxStudents.SelectedItem.ToString();
            controller.RemoveElement(toRemove);
            NavigateToListPanel();
        }

        private void ButtonList_Click(object sender, EventArgs e)
        {
            NavigateToListPanel();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            NavigateToAddPanel();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            NavigateToRemovePanel();
        }

        private void LoadStudents()
        {
            listBoxStudents.Items.Clear();

            string[] allStudents = controller.LoadAllStudents();

            foreach (var item in allStudents)
            {
                listBoxStudents.Items.Add(item);
            }
        }

        private void ButtonAddElement_Click(object sender, EventArgs e)
        {
            string firstName, lastName, course, startDate, duration;
            firstName = textBoxFirstName.Text;
            lastName = textBoxLastName.Text;
            course = comboBoxCourses.Text;
            startDate = textBoxStartDate.Text;
            duration = textBoxDuration.Text;

            controller.AddElement(firstName, lastName, course, startDate, duration);

            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxDuration.Clear();
            textBoxStartDate.Clear();
            comboBoxCourses.Text = "";
        }


        private void NavigateToListPanel()
        {
            panelAdd.Visible = false;
            panelRemove.Visible = false;
            panelDisp.Visible = false;
            panelList.Location = panelDisp.Location;
            panelList.Visible = true;
            textBoxDetails.Text = controller.DisplayAll();
        }

        private void NavigateToAddPanel()
        {
            panelDisp.Visible = false;
            panelRemove.Visible = false;
            panelList.Visible = false;
            panelAdd.Location = panelDisp.Location;
            panelAdd.Visible = true;
        }

        private void NavigateToRemovePanel()
        {
            panelAdd.Visible = false;
            panelList.Visible = false;
            panelDisp.Visible = false;
            panelRemove.Location = panelDisp.Location;
            panelRemove.Visible = true;
            LoadStudents();
        }
    }
}
