using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_application.Entitis
{
    class Student : IEquatable<Student>, IComparable<Student>
    {
        #region DECLARE
        /// <summary>
        /// student id
        /// </summary>
        public int studentID { get; set; }

        /// <summary>
        /// Student name
        /// </summary>
        public string studentName { get; set; }

        /// <summary>
        /// Semester
        /// </summary>
        public int semester { get; set; }

        /// <summary>
        /// Course name
        /// </summary>
        public string courseName { get; set; }

        /// <summary>
        /// Function compare student follow student id
        /// </summary>
        /// <param name="other">object students</param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            return this.studentID.CompareTo(other.studentID);
        }
        #endregion

        #region Method

        /// <summary>
        /// 
        /// </summary>
        public void Insert()
        {
            try
            {
                Console.WriteLine(Properties.Resources.InsertStudent);

                Console.Write(Properties.Resources.StudentID);
                this.studentID = Convert.ToInt32(Console.ReadLine());

                Console.Write(Properties.Resources.StudentName);
                this.studentName = Console.ReadLine();

                Console.Write(Properties.Resources.Semester);
                this.semester = Convert.ToInt32(Console.ReadLine());

                Console.Write(Properties.Resources.CouseName);
                this.courseName = Console.ReadLine();
            }
            catch (Exception ce)
            {
                Console.WriteLine(ce);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void InputUpdate()
        {
            try
            {
                Console.WriteLine(Properties.Resources.InfoUpdate);

                Console.Write(Properties.Resources.StudentName);
                this.studentName = Console.ReadLine();

                Console.Write(Properties.Resources.Semester);
                this.semester = Convert.ToInt32(Console.ReadLine());

                Console.Write(Properties.Resources.CouseName);
                this.courseName = Console.ReadLine();
            }
            catch (Exception ce)
            {
                Console.WriteLine(ce);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Display()
        {
            Console.Write(this.studentName + "|");
            Console.Write(this.semester + "|");
            Console.Write(this.courseName + "|");
            Console.Write(this.studentID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Student other)
        {
            if (other == null)
                return false;
            return (this.studentID.Equals(other.studentID));
        }
        #endregion
    }
}
