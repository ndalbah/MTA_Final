using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Departments
    {
        static internal int UpdateDepartments()
        {

            return Data.EF.SaveChanges();
        }
    }

    class Employees
    {
        static internal int UpdateEmployees()
        {
            if (Data.EF.GetEmployees().Where(c => (c.Salary < 15000)).Count() > 0)
            {
                Data.EF.Reload();
                Question4.Form1.BLLMessage("Salary must be above CA$15000");
                return -2;
            }
            else
            {
                return Data.EF.SaveChanges();
            }
        }
    }
}
