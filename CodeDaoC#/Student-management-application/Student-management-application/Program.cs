using Student_management_application.Controller;
using Student_management_application.Entitis;
using System;
using System.Collections.Generic;
using static Student_management_application.Enums.Enum;

namespace Student_management_application
{
    class Program
    {
        #region DECLARE

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region DECLARE
            int choose = -1;
            List<Student> _students = new List<Student>();
            CStudent _cStudent = new CStudent();
            #endregion

            #region view MENU
            try
            {
                while (true)
                {
                    // show menu
                    Console.WriteLine(Properties.Resources.TitleMenu + "\n");

                    // show option menu
                    Console.WriteLine(Properties.Resources.Option1);
                    Console.WriteLine(Properties.Resources.Option2);
                    Console.WriteLine(Properties.Resources.Option3);
                    Console.WriteLine(Properties.Resources.Option4);
                    Console.WriteLine(Properties.Resources.Option5);
                    Console.WriteLine(Properties.Resources.Option6);

                    // user choose
                    Console.Write(Properties.Resources.Choose);
                    choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case (int)EntityState.AddNew:
                            _cStudent.AddNew(_students);
                            break;

                        case (int)EntityState.Search:
                            _cStudent.Search(_students);
                            break;

                        case (int)EntityState.Sort:
                            _cStudent.Sort(_students);
                            break;

                        case (int)EntityState.UpdateDelete:
                            _cStudent.UpdateRemove(_students);
                            break;

                        case (int)EntityState.Report:
                            _cStudent.DisplayList(_students);
                            break;

                        case (int)EntityState.Exit:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("\n" + Properties.Resources.ChooseErr);
                            break;
                    }
                }
            } catch(Exception ce)
            {
                Console.WriteLine(ce);
            }
            
            #endregion
        }
    }
}
