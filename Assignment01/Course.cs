using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Course
    {
        public string name;
        public int theoryGrade;
        public PracticalGrade practicalGrade;

        public bool Passed()
        {
            if (theoryGrade >= 55 && (int)practicalGrade >= 3)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool CumLaude()
        {
            if (theoryGrade >= 80 && (int)practicalGrade == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
