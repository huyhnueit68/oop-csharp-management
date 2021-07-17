using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_application.Enums
{
    class Enum
    {
        /// <summary>
        /// State of user
        /// </summary>
        public enum EntityState
        {
            AddNew = 1,
            Search = 2,
            Sort = 3,
            UpdateDelete = 4,
            Report = 5,
            Exit = 6,
            Update = 1,
            Delete = 2,
            SortDesc = 1,
            SortAsc = 2
        }
    }
}
