using System;
using Question4;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Data
{
    class EF
    {
        private static EmpDeptEntities db = new EmpDeptEntities();

        private static ObservableCollection<Departments> OEDDepartments = null;
        private static bool initDepartments = false;

        private static ObservableCollection<Employees> OEDEmployees = null;
        private static bool initEmployees = false;

        internal static ObservableCollection<Departments> GetDepartments()
        {
            if (!initDepartments)
            {
                db.Departments.Load();
                OEDDepartments = db.Departments.Local;
                initDepartments = true;
            }
            return OEDDepartments;
        }

        internal static ObservableCollection<Employees> GetEmployees()
        {
            if (!initEmployees)
            {
                db.Employees.Load();
                OEDEmployees = db.Employees.Local;
                initEmployees = true;
            }
            return OEDEmployees;
        }

        internal static int SaveChanges()
        {
            try
            {
                db.SaveChanges();
                return 0;
            }
            catch (Exception)
            {
                Reload();
                return -1;
            }
        }

        internal static void Reload()
        {
            db = new EmpDeptEntities();
            initDepartments = false;
            initEmployees = false;
        }
    }
}
