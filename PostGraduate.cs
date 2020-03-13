using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL2002Assignment_1
{
    class PostGraduate : Student //PostGraduate class that inherits from Student class
    {
        public string bachelorUniversity;
        public string bachelorDepartment;

        //Contructor for PostGraduate class which takes two parameters
        public PostGraduate(string bachelorUniversity, string bachelorDepartment)
        {
            this.bachelorDepartment = bachelorDepartment;
            this.bachelorUniversity = bachelorUniversity;
        }

        //Override method which return a "3" element string array of previous education information
        public override string[] GetPreviousEducationInfo()
        {
            // Step 1: Array Declaration 
            string[] informationArray;

            // Step 2:Array Initialization 
            informationArray = new string[3] {"PreviousEducation:","Bachelor Degree:"
                                              ,bachelorUniversity + " - " + bachelorDepartment};

            return informationArray;

        }
    }
}
