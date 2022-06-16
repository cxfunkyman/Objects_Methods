using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Methods.Business
{
    public class Course
    { // Use customs methods
        private int studentId;

        public void SetStudentId(int sId)
        { 
            studentId = sId; 
        }
        public int GetStudentId()
        {
            return studentId;
        }

        private String firstName;

        public void SetFirstName(string fname)
        {
            firstName = fname;
        }
        public string GetFirstName()
        {
            return firstName;
        }

        private String lastName;

        public void SetLastName(string lname)
        {
            lastName = lname;
        }
        public string GetLastName()
        {
            return lastName;
        }

        private float midTermGrade;

        public void SetMidtermGrade(float mTermGrade)
        { 
            midTermGrade = mTermGrade;
        }
        public float getMidTermGrade()
        {
            return midTermGrade;
        }

        public string GetInfo(Course oGradeRecord)
        {
            string infoGrade = oGradeRecord.GetStudentId().ToString() +
                "\n" + oGradeRecord.GetFirstName().ToString() + "\n" +
                oGradeRecord.GetLastName().ToString() + "\n" +
                oGradeRecord.getMidTermGrade().ToString();

            return infoGrade;
        }

//        public string GetInfo()
//       {
//            return "First Name: " + firstName + " Last Name: " + lastName + " Grade: " + midTermGrade;
//       }

    }
}
