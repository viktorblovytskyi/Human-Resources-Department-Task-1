using System;
using System.Collections.Generic;

namespace HumanResourcesDepartment
{
    [Serializable]
    sealed public class Company
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
        /// This method adds to the list employee object. 
        /// </summary>
        /// <param name="employee">Employee</param>
        public void AddEmployee(string FirstName, string LastName, string ContactDetails, string Position, string Subdivision)
        {
            Employee emp = new Employee(this.id, FirstName, LastName, ContactDetails, Position);
            this.FindSubdivisionByName(Subdivision).AddEmployee(emp);
            this.Employees.Add(emp);
            ++id;
        }

        /// <summary>
        /// This method adds to the list employee object. 
        /// </summary>
        /// <param name="employee">Employee</param>
        public void AddEmployee(string FirstName, string LastName, string ContactDetails, string Position, int EmployerId)
        {
            Employee emp = new Employee(this.id, FirstName, LastName, ContactDetails, Position, this.FindById(EmployerId));
            this.Employees.Add(emp);
            ++id;
        }

        /// <summary>
        /// This method adds to the list employee object. 
        /// </summary>
        /// <param name="employee">Employee</param>
        public void AddEmployee(string FirstName, string LastName, string ContactDetails, string Position, string Subdivision, int EmployerId)
        {
            Employee emp = new Employee(this.id, FirstName, LastName, ContactDetails, Position,  this.FindById(EmployerId));
            this.FindSubdivisionByName(Subdivision).AddEmployee(emp);
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
            employee.Subdivision.RemoveEmployee(employee);
            this.Employees.Remove(employee);

        }

        /// <summary>
        /// This method sets employee's subdivision.
        /// </summary>
        /// <param name="employeeId">int</param>
        /// <param name="subdivName">string</param>
        public void SetSubdivision (int employeeId, string subdivName)
        {
            this.FindSubdivisionByName(subdivName).AddEmployee(this.FindById(employeeId));
        }

        /// <summary>
        /// This method set employee's employer.
        /// </summary>
        /// <param name="employeeId">int</param>
        /// <param name="employerId">int</param>
        public void SetEmployer (int employeeId, int employerId)
        {
            this.FindById(employeeId).SetEmployer(this.FindById(employerId));
        }
    }
}
