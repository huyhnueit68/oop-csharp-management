using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_application.Entitis
{
    class StudentIDCompareDesc : IComparer<Student>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Student x, Student y)
        {
            return y.studentID.CompareTo(x.studentID);
        }
    }
}
