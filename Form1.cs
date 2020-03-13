using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIL2002Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //A list for holding the students that the user added
        List<Student> students = new List<Student>();


        private void button1_Click(object sender, EventArgs e) //Add Student Button Click Event
        {
            
            //Add a student of type "Bachelor"
            if (comboBox1.SelectedItem.ToString() == "Bachelor") 
            {
                students.Add(new Bachelor());
            }
            //Add a student of type "PostGraduate"
            else if (comboBox1.SelectedItem.ToString() == "Postgraduate") 
            {
                students.Add(new PostGraduate(bachelorUniversityTextBox.Text, bachelorDepartmentTextBox.Text));
            }
            //Add a student of type "PhDStudent"
            else if (comboBox1.SelectedItem.ToString() == "PhD") 
            {
                students.Add(new PhDStudent(bachelorUniversityTextBox.Text, bachelorDepartmentTextBox.Text, postGraduateUniversityTextBox.Text, postGraduateDepartmentTextBox.Text));
            }

            //Add recently added student's name to the combo box
            studentsComboBox.Items.Add(nameTextBox.Text);
            //Then select it
            studentsComboBox.SelectedIndex = studentsComboBox.Items.Count-1;
            

            //Assing the name, number, and department values to recently added student
            students[studentsComboBox.SelectedIndex].Name = nameTextBox.Text;
            students[studentsComboBox.SelectedIndex].Number = Convert.ToInt64(numberTextBox.Text);
            students[studentsComboBox.SelectedIndex].Department = departmentTextBox.Text;
            
            //Write the information to listbox
            GetStudentDetails();

            //Make the add lecture section visible if there is at least 1 student
            addLectureGroupBox.Visible = true;

            //Handle the string operations
            addLectureGroupBox.Text = "Add Lecture(s): " + nameTextBox.Text;
            pointLabel.Text = "Student Added: " + nameTextBox.Text + "  ------->";


            //Clear the input fields after the user adds the student
            nameTextBox.Clear();
            numberTextBox.Clear();
            departmentTextBox.Clear();
            bachelorUniversityTextBox.Clear();
            bachelorDepartmentTextBox.Clear();
            postGraduateUniversityTextBox.Clear();
            postGraduateDepartmentTextBox.Clear();
           

        }

        private void GetStudentDetails()
        {
            //Empty the listbox
            listBox1.Items.Clear();

            //Add the name
            listBox1.Items.Add("Name:");
            listBox1.Items.Add(students[studentsComboBox.SelectedIndex].Name);
            listBox1.Items.Add(" ");


            //Add the previous education info if the student is a postgraduate or a PhD Student
            if(students[studentsComboBox.SelectedIndex].GetType().Name == "PostGraduate")
            {
                listBox1.Items.Add(students[studentsComboBox.SelectedIndex].GetPreviousEducationInfo()[0]);
                listBox1.Items.Add(" ");
                listBox1.Items.Add(students[studentsComboBox.SelectedIndex].GetPreviousEducationInfo()[1]);
                listBox1.Items.Add(students[studentsComboBox.SelectedIndex].GetPreviousEducationInfo()[2]);
                listBox1.Items.Add(" ");
            }
            else if (students[studentsComboBox.SelectedIndex].GetType().Name == "PhDStudent")
            {
                listBox1.Items.Add(students[studentsComboBox.SelectedIndex].GetPreviousEducationInfo()[0]);
                listBox1.Items.Add(" ");
                listBox1.Items.Add(students[studentsComboBox.SelectedIndex].GetPreviousEducationInfo()[1]);
                listBox1.Items.Add(students[studentsComboBox.SelectedIndex].GetPreviousEducationInfo()[2]);
                listBox1.Items.Add(" ");
                listBox1.Items.Add(students[studentsComboBox.SelectedIndex].GetPreviousEducationInfo()[3]);
                listBox1.Items.Add(students[studentsComboBox.SelectedIndex].GetPreviousEducationInfo()[4]);
                listBox1.Items.Add(" ");
            }


            //Add the school number
            listBox1.Items.Add("School Number:");
            listBox1.Items.Add(students[studentsComboBox.SelectedIndex].Number);
            listBox1.Items.Add(" ");

            //Add the departmet
            listBox1.Items.Add("Department:");
            listBox1.Items.Add(students[studentsComboBox.SelectedIndex].Department);
            listBox1.Items.Add(" ");

            //Add lectures
            listBox1.Items.Add("Lectures:");

            //Iterate between each lecture that the student have and add the lecture details to the listbox
            foreach(Lecture lecture in students[studentsComboBox.SelectedIndex].lectures)
            {
                listBox1.Items.Add(lecture.lectureCode + " - " + lecture.name);
                listBox1.Items.Add("Grade: " + lecture.grade.ToString() + "    ECTS: " + lecture.ectsCredit.ToString());
                listBox1.Items.Add(" ");
            }
            listBox1.Items.Add(" ");

            //Calculate the cumulative average with a method that the Student class have, than add it to the listbox
            listBox1.Items.Add("Cumulative Average: " + students[studentsComboBox.SelectedIndex].CalculateCumulativeGrade().ToString("G4")); //G4 -> xx.xx 2 step format
        }

        private void studentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the current student's details
            GetStudentDetails();

            //Show, that the user will add a lecture to the current student
            addLectureGroupBox.Text = "Add Lecture(s): " + studentsComboBox.SelectedItem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Bachelor")
            {
                bachelorUniversityLabel.Visible = false;
                bachelorUniversityTextBox.Visible = false;
                bachelorDepartmentLabel.Visible = false;
                bachelorDepartmentTextBox.Visible = false;
                postGraduateUniversityLabel.Visible = false;
                postGraduateUniversityTextBox.Visible = false;
                postGraduateDepartmentLabel.Visible = false;
                postGraduateDepartmentTextBox.Visible = false;
            }
            else if(comboBox1.SelectedItem.ToString() == "Postgraduate")
            {
                bachelorUniversityLabel.Visible = true;
                bachelorUniversityTextBox.Visible = true;
                bachelorDepartmentLabel.Visible = true;
                bachelorDepartmentTextBox.Visible = true;
                postGraduateUniversityLabel.Visible = false;
                postGraduateUniversityTextBox.Visible = false;
                postGraduateDepartmentLabel.Visible = false;
                postGraduateDepartmentTextBox.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "PhD")
            {
                bachelorUniversityLabel.Visible = true;
                bachelorUniversityTextBox.Visible = true;
                bachelorDepartmentLabel.Visible = true;
                bachelorDepartmentTextBox.Visible = true;
                postGraduateUniversityLabel.Visible = true;
                postGraduateUniversityTextBox.Visible = true;
                postGraduateDepartmentLabel.Visible = true;
                postGraduateDepartmentTextBox.Visible = true;
            }

        }

        private void addLectureButton_Click(object sender, EventArgs e)
        {
            //Add a lecture to the student with given values
            if(ectsCreditTextBox.Text != "")
                students[studentsComboBox.SelectedIndex].lectures.Add(new Lecture(lectureCodetextBox.Text, lectureNametextBox.Text, Convert.ToInt32(gradeTextBox.Text), Convert.ToInt32(ectsCreditTextBox.Text)));

            //Add a lecture to the student with given values if the ectsCredit field left blank assing it to a default value of 5
            else if (ectsCreditTextBox.Text == "")
                students[studentsComboBox.SelectedIndex].lectures.Add(new Lecture(lectureCodetextBox.Text, lectureNametextBox.Text, Convert.ToInt32(gradeTextBox.Text)));

            pointLabel.Text = "Lecture Added to " + studentsComboBox.SelectedItem.ToString() + "  ---->";

            //Refresh the student details
            GetStudentDetails();

            //Clear the input field
            lectureCodetextBox.Clear();
            lectureNametextBox.Clear();
            ectsCreditTextBox.Clear();
            gradeTextBox.Clear();
        }

    }
}
