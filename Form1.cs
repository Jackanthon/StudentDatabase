using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Day1Assignment1
{
    public partial class Form1 : Form
    {
        //ArrayList slist;
                List<Student> slist = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridStudents.Visible = false;
            //Out-dated code
            //slist = new ArrayList();
            //slist.Add(new Student(33456, firstn: "Sam", lastn: "Club", YearofStudent.Freshman, Gender.Other));
            //slist.Add(new Student(33243, firstn: "Derrick", lastn: "Choma", YearofStudent.Senior, Gender.Male));
            //slist.Add(new Student(33266, firstn: "Sarah", lastn: "Parker", YearofStudent.Junior, Gender.Female));
            slist.Add(new Student() { SID = 6258, FirstN = "Joe", LastN = "Wright", Gender = Gender.Male, StudentYear = YearofStudent.Junior });
            slist.Add(new Student() { SID = 6527, FirstN = "Brook", LastN = "Allen", Gender = Gender.Female, StudentYear = YearofStudent.Softmore });
            slist.Add(new Student() { SID = 6560, FirstN = "Carly", LastN = "Smith", Gender = Gender.Other, StudentYear = YearofStudent.Freshman });
            slist.Add(new Student() { SID = 6497, FirstN = "Parker", LastN = "Underwood", Gender = Gender.Male, StudentYear = YearofStudent.Senior });
            slist.Add(new Student() { SID = 6497, FirstN = "Sarah", LastN = "Smith", Gender = Gender.Female, StudentYear = YearofStudent.Softmore });
            slist.Add(new Student() { SID = 6497, FirstN = "Tim", LastN = "Corey", Gender = Gender.Male, StudentYear = YearofStudent.Freshman });

            gridStudents.DataSource = slist;
            cboxYearS.DataSource = Enum.GetValues(typeof(YearofStudent));
            cboxGenderS.DataSource = Enum.GetValues(typeof(Gender));
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSID.Text != string.Empty && txtFirstN.Text != string.Empty && txtLastN.Text != string.Empty)
                {
                    Student newStudent = new Student();
                    newStudent.SID = Int32.Parse(txtSID.Text);
                    newStudent.FirstN = txtFirstN.Text;
                    newStudent.LastN = txtLastN.Text;
                    newStudent.StudentYear = (YearofStudent)cboxYearS.SelectedItem;
                    newStudent.Gender = (Gender)cboxGenderS.SelectedValue;
                    slist.Add(newStudent);
                }
                else
                {
                    MessageBox.Show("Please fill in all text boxes.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid ID.");
            }
            RefreshValues();
        }
        private void Id_StudentID(int studentID)
        {
            MessageBox.Show("Invalid ID");
        }
        private void RefreshValues()
        {
            txtSID.Clear();
            txtFirstN.Clear();
            txtLastN.Clear();
            cboxYearS.Text = "Year";
            cboxGenderS.Text = "Gender";
            gridStudents.DataSource = null;
            gridStudents.DataSource = slist;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            slist.RemoveAt(gridStudents.CurrentRow.Index);
            gridStudents.DataSource = null;
            gridStudents.DataSource = slist;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            gridStudents.Visible = true;
        }
    }
}
