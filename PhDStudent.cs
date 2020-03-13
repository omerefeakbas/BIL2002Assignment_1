using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL2002Assignment_1
{
    class PhDStudent : Student //PhdStudent class that inherits from Student class
    {
        public string bachelorUniversity;
        public string bachelorDepartment;
        public string postGraduateUniversity;
        public string postGraduateDepartment;

        //Contructor for PhDStudent class which takes four parameters
        public PhDStudent(string bachelorUniversity, string bachelorDepartment, string postGraduateUniversity, string postGraduateDepartment)
        {
            this.bachelorDepartment = bachelorDepartment;
            this.bachelorUniversity = bachelorUniversity;
            this.postGraduateDepartment = postGraduateDepartment;
            this.postGraduateUniversity = postGraduateUniversity;
        }

        //Override method which returns a "5" element string array of previous education information
        public override string[] GetPreviousEducationInfo()
        {
            string[] informationArray;

            informationArray = new string[5] {"PreviousEducation:",
                                            "Bachelor Degree:",
                                            bachelorUniversity + " - " + bachelorDepartment,
                                            "Postgraduate Degree:",
                                            postGraduateUniversity + " - " + postGraduateDepartment};

            return informationArray;
        }
    }
}
