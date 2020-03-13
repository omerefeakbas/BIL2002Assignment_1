using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL2002Assignment_1
{
    class Lecture
    {
        //Information fields
        public string lectureCode;
        public string name;
        public int ectsCredit;
        public float grade;

        //Constructor for Lecture class that takes 3 or 4 parameters depending on the user input
        public Lecture(string lectureCode, string name, float grade, int ectsCredit = 5) //Default ECTS : 5
        {
            this.lectureCode = lectureCode;
            this.name = name;
            this.grade = grade;
            this.ectsCredit = ectsCredit;
        }
    }   
}
