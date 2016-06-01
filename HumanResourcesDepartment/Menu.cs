using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace HumanResourcesDepartment
{
    public class Menu
    {
        private string format = "| {0,5} | {1,12} | {2,12} | {3,20} | {4,16} | {5,22} | {6,8} | ";

        /// <summary>
        /// This method draws a horizontal face of the table.
        /// </summary>
        private void PrintBorder()
        {
            int charCount = 117;
            for (int i = 1; i <= charCount; i++)
                Console.Write("-");            
            Console.WriteLine();
        }

        /// <summary>
        /// This method displays employee's object. 
        /// </summary>
        /// <param name="empObj">Employee</param>
        public void PrintEmployee (Employee empObj)
        {        
            if (empObj.Employer != null && empObj.Subdivision != null)
                Console.WriteLine(this.format, empObj.id, empObj.FirstName, empObj.LastName, empObj.Position, empObj.Subdivision.Name, empObj.Employer.FirstName + " " + empObj.Employer.LastName, empObj.Employer.id);
            else if (empObj.Employer == null && empObj.Subdivision != null)
                Console.WriteLine(this.format, empObj.id, empObj.FirstName, empObj.LastName, empObj.Position, empObj.Subdivision.Name, "NULL", "NULL");
            else if (empObj.Subdivision == null && empObj.Employer != null)            
                Console.WriteLine(this.format, empObj.id, empObj.FirstName, empObj.LastName, empObj.Position, "NULL", empObj.Employer.FirstName + " " + empObj.Employer.LastName, empObj.Employer.id);
            else
                Console.WriteLine(this.format, empObj.id, empObj.FirstName, empObj.LastName, empObj.Position, "NULL", "NULL", "NULL");           
        }

        /// <summary>
        /// This method displays list of employee.
        /// </summary>
        /// <param name="empList">List of Employee</param>
        public  void PrintEmployeeList(List<Employee> empList)
        {
            this.PrintBorder();
            Console.WriteLine(this.format,"id", "First name","Last name","Position","Subdivision","Employer","Emplr_id");
            this.PrintBorder();

            foreach (var empObj in empList)
                this.PrintEmployee(empObj);

            this.PrintBorder();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subdivList"></param>
        public void PrinSubdivisionList(List<Subdivision> subdivList)
        {
            foreach(var subdiv in subdivList)
            {
                this.PrintBorder();
                Console.WriteLine("| {0,113} |", subdiv.Name);
                this.PrintBorder();
                this.PrintEmployeeList(subdiv.Employees);
                this.PrintBorder();
            }
        }

        /// <summary>
        /// This method serializes object and stores it in file: company.dll.
        /// </summary>
        /// <param name="company">Company</param>
        public void SaveObject(Company company)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("Company.dat", FileMode.OpenOrCreate))
            {                
                formatter.Serialize(fs, company);
                Console.WriteLine("Объект сериализован");
            }
        }

        /// <summary>
        /// This method deserializes the object and 
        /// stores it in an object of type Company.
        /// </summary>
        /// <returns>Company</returns>
        public Company LoadObject()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
                return (Company)formatter.Deserialize(fs);              
        }
    }
}
