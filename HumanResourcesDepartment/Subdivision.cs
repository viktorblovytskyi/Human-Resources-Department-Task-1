using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesDepartment
{
    sealed public class Subdivision
    {

        public string Name { get; set; }
        public List<Employee> Employees { get; }

        /// <summary>
        /// Initial constructor.
        /// </summary>
        /// <param name="Name">Name of subdivision. Type string.</param>
        public Subdivision(string Name)
        {
            this.Name = Name;
            this.Employees = new List<Employee>();
        }
        /// <summary>
        /// This method add employee in subdivision. 
        /// </summary>
        /// <param name="emp">Emloyee</param>
        public void AddEmployee(Employee emp)
        {
            this.Employees.Add(emp);
            emp.SetSubdivision(this);
        }

        /// <summary>
        /// This method remove employee from subdivision
        /// </summary>
        /// <param name="emp">Emloyee</param>
        public void RemoveEmployee(Employee emp)
        {
            this.Employees.Remove(emp);
        }
    }
}
