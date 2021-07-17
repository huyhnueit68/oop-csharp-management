using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_application.Entitis
{
    class StudentIDCompareAsc : IComparer<Student>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Student x, Student y)
        {
            return x.studentID.CompareTo(y.studentID);
        }
    }
}
