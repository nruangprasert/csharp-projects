/* ClassFilledException.cs
 * This is a custom defined exception class
 * used when the current enrollment exceedds 
 * maximum enrollment by three students.
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEnrollmentApp
{
    class ClassFilledException : System.ApplicationException
    {
        private string courseName;
        private int overMax;
        private int currentEnrollment;

        public ClassFilledException(string exceptionMessage, string cName,
                                       int currentEnr, int maxEnroll)
            : base (exceptionMessage)
        {
            courseName = cName;
            overMax = maxEnroll;
            currentEnrollment = currentEnr;
        }

        public ClassFilledException( )
            : base( )
        {
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }
        }
        public int OverMax
        {
            get
            {
                return overMax;
            }
        }
        public int CurrentEnrollment
        {
            get
            {
                return currentEnrollment;
            }
        }
    }
}
