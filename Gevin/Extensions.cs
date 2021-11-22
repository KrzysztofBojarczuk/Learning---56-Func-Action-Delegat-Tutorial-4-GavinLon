using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gevin
{
    public static class Extensions
    {
        public static List<Employee> FilterEmployees(this List<Employee> employees, Predicate<Employee> predicate)
        {
            List<Employee> employeesFiltered = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (predicate(employee))
                {
                    employeesFiltered.Add(employee);
                }
            }
            return employeesFiltered;
        }
    }
}
