using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesDepartment
{
    [Serializable]
    public class Company
    {
        public string Name { get; private set; }
        public List<Employee> Employees { get; set; }
        public List<Subdivision> Subdivisions { get; set; }
        private int id = 0;

        /// <summary>
        /// Initial constructor
        /// </summary>
        /// <param name="Name">string</param>
        public Company(string Name)
        {
            this.Employees = new List<Employee>();
            this.Subdivisions = new List<Subdivision>();
            this.Name = Name;
        }

        /// <summary>
        /// This method adds subdivision in List of subdivisions.
        /// </summary>
        /// <param name="Name">string</param>
        public void AddSubdivision(string Name)
        {
            this.Subdivisions.Add(new Subdivision(Name));
        }

        /// <summary>
        /// This method adds to the list employee object. 
        /// </summary>
        /// <param name="employee">Employee</param>
        public void AddEmployee (string FirstName, string LastName, string ContactDetails, string Position)
        {
            Employee emp = new Employee(this.id, FirstName, LastName, ContactDetails, Position);
            this.Employees.Add(emp);
            ++id;
        }

        /// <summary>
        /// This method finds employee by id.
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Employee</returns>
        public Employee FindById(int id)
        {
            return this.Employees.Find(x => x.id == id);
        }

        /// <summary>
        /// This method finds subdivision by name.
        /// </summary>
        /// <param name="Name">string</param>
        /// <returns>Subdivision</returns>
        public Subdivision FindSubdivisionByName(string Name)
        {
            return this.Subdivisions.Find(x => x.Name == Name);
        }

        /// <summary>
        /// This method removes from the list of employees objects.
        /// </summary>
        /// <param name="employee">Employee</param>
        public void RemoveEmloyee (Employee employee)
        {
            this.Employees.Remove(employee);
        }
    }
}
