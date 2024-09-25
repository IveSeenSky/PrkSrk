using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorAutoWorkers.AppData
{
    internal class Connection
    {
        public static EmployeesEntities c;
        public static EmployeesEntities context
        {
            get {
                if (c == null)
                    c = new EmployeesEntities();
                return c;
            }
        }
    }
}
