using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL2002Assignment_1
{
    abstract class Student //Abstract Student Class
    {
        //number field
        private long number = 0;
        //Number property
        public long Number {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        //name field
        private string name = " ";
        //Name property
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //department field
        private string department = " ";
        //Department property
        public string Department {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        //The list that holds the lectures that the student have
        public List<Lecture> lectures = new List<Lecture>();


        //The function that calculates and returns the cumulative average of the student
        public float CalculateCumulativeGrade()
        {
            if (lectures.Count == 0)
                return 0;
            int totalECTS = 0;
            float totalGrades = 0;
            foreach (Lecture lecture in lectures)
            {
                totalECTS += lecture.ectsCredit;
                totalGrades += lecture.grade * lecture.ectsCredit;
            }
            return totalGrades / totalECTS;
        }

        //Abstact method which differs on each inherited class
        public abstract string[] GetPreviousEducationInfo();
        
    }
}
