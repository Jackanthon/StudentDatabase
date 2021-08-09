using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment1
{
    enum YearofStudent
    {
        Freshman, Softmore, Junior, Senior
    }
    enum Gender { Male, Female, Other }
    class Student
    {
        private int _sid;
        public int SID 
        {   get { return _sid; } 
            set
            {
                if (value >= 6000 && value <= 7000)
                {
                    _sid = value;
                }
                else
                {
                    _sid = 0;
                }
            }
        }
        public string FirstN { get; set; }
        public string LastN { get; set; }
        public YearofStudent StudentYear { get; set; }
        public Gender Gender { get; set; }
    }
}
//1. Play with controls! Use different controls on windows forms and change their properties.
//2. Create a structure : Student with fields like studid, firstname, lastname, address, monthofadmission, grade .: A, B,C
//  Create a list of students and perform following operations in windows application:

//add new records,
//delete record and
//display them in grid.
//Monthofadmission should be enum.

