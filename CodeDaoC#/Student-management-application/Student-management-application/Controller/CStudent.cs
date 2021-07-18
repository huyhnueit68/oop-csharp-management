using Student_management_application.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Student_management_application.Enums.Enum;

namespace Student_management_application.Controller
{
    class CStudent
    {
        #region DECLARE
        #endregion

        #region Construct
        public CStudent()
        {

        }
        #endregion

        #region Method
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_students"></param>
        /// <returns></returns>
        public bool AddNew(List<Student> _students)
        {
            bool isResult = true;

            Student student = new Student();
            student.Insert();
            _students.Add(student);

            return isResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_students"></param>
        public void DisplayList(List<Student> _students)
        {
            try
            {
                Console.WriteLine(Properties.Resources.ReportTitle);
                foreach (var item in _students)
                {
                    item.Display();
                    Console.WriteLine();
                }
            } catch(Exception ce)
            {
                Console.WriteLine(ce);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_students"></param>
        public void UpdateRemove(List<Student> _students)
        {
            try
            {
                // display list before choose
                this.DisplayList(_students);

                // choose student
                Console.WriteLine(Properties.Resources.SelectStudent);
                int _studentID = Convert.ToInt32(Console.ReadLine());

                var studentFilter = _students.FirstOrDefault(o => (int)o.studentID == _studentID);

                if (studentFilter == null)
                {
                    Console.WriteLine(Properties.Resources.SearchNull + " " + _studentID);
                } else
                {
                    bool isChoose = false;

                    while (!isChoose)
                    {
                        Console.WriteLine(Properties.Resources.ChooseAction);
                        Console.WriteLine(Properties.Resources.Update);
                        Console.WriteLine(Properties.Resources.Delete);

                        int choose = Convert.ToInt32(Console.ReadLine());

                        switch(choose)
                        {
                            case (int)EntityState.Update:
                                this.UpdateStudent(_students, studentFilter);
                                isChoose = true;
                                break;
                            case (int)EntityState.Delete:
                                this.Delete(_students, studentFilter);
                                isChoose = true;
                                break;
                            default:
                                Console.WriteLine("\n" + Properties.Resources.ChooseErr);
                                break;
                        }
                    }
                }
            }
            catch (Exception ce)
            {
                Console.WriteLine(ce);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_students"></param>
        public void Search(List<Student> _students)
        {
            try
            {
                Console.Write(Properties.Resources.SrearchByID);
                int idFilter = Convert.ToInt32(Console.ReadLine());

                var studentFilter = _students.FirstOrDefault(o => (int)o.studentID == idFilter);

                if(studentFilter != null)
                {
                    Console.WriteLine(Properties.Resources.ResultSearch);
                    studentFilter.Display();
                    Console.WriteLine();
                } else
                {
                    Console.WriteLine(Properties.Resources.SearchNull + idFilter);
                }

            }
            catch (Exception ce)
            {
                Console.WriteLine(ce);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_students"></param>
        public void Sort(List<Student> _students)
        {
            try
            {
                Console.Write(Properties.Resources.SrearchByID);

                bool isChoose = false;

                while (!isChoose)
                {
                    Console.WriteLine(Properties.Resources.ChooseAction);
                    Console.WriteLine(Properties.Resources.SortDesc);
                    Console.WriteLine(Properties.Resources.SortAsc);

                    int choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case (int)EntityState.SortDesc:
                            this.SortDesc(_students);
                            isChoose = true;
                            break;
                        case (int)EntityState.SortAsc:
                            this.SortAsc(_students);
                            isChoose = true;
                            break;
                        default:
                            Console.WriteLine("\n" + Properties.Resources.ChooseErr);
                            break;
                    }
                }
            }
            catch (Exception ce)
            {
                Console.WriteLine(ce);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_students"></param>
        protected void SortDesc(List<Student> _students)
        {
            _students.Sort(new StudentIDCompareDesc());
            Console.WriteLine(Properties.Resources.SortResult);
            foreach(Student student in _students)
            {
                student.Display();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_students"></param>
        protected void SortAsc(List<Student> _students)
        {
            _students.Sort(new StudentIDCompareAsc());
            Console.WriteLine(Properties.Resources.SortResult);
            foreach (Student student in _students)
            {
                student.Display();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_students"></param>
        /// <param name="studentFilter"></param>
        protected void Delete(List<Student> _students, Student studentFilter)
        {
            try
            {
                _students.Remove(studentFilter);
                Console.WriteLine(Properties.Resources.DeleteSuccess);
            }
            catch (Exception ce)
            {
                Console.WriteLine(ce);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_students"></param>
        /// <param name="studentFilter"></param>
        protected void UpdateStudent(List<Student> _students, Student studentFilter)
        {
            try
            {
                Student tempStudent = new Student();

                // Input data update
                tempStudent.studentID = studentFilter.studentID;
                tempStudent.InputUpdate();

                // assign info
                _students.FirstOrDefault(o => (int)o.studentID == studentFilter.studentID).studentName = tempStudent.studentName;
                _students.FirstOrDefault(o => (int)o.studentID == studentFilter.studentID).semester = tempStudent.semester;
                _students.FirstOrDefault(o => (int)o.studentID == studentFilter.studentID).courseName = tempStudent.courseName;

                Console.WriteLine(Properties.Resources.UpdateSuccess);
            } catch(Exception ce)
            {
                Console.WriteLine(ce);
            }
        }
        #endregion
    }
}
