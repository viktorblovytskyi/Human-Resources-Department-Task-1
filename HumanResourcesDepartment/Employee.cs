using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesDepartment
{
    sealed public class Employee: Person
    {

        private Employee Employer { get; set; }
        private string Position { get; set; }
        private Subdivision Subdivision { get; set; }

        /// <summary>
        /// Initial constructor
        /// </summary>
        /// <param name="FirstName">Firstname of employee. Type: string. </param>
        /// <param name="LastName">Lastname of employee. Type: string. </param>
        /// <param name="ContactDetails">Contact details of employee. Type: string. </param>
        /// <param name="Position">Employye's position. Type: string. </param>
        /// <param name="Employer">Employee's employer. Type: Employee.</param>
        public Employee (string FirstName, string LastName, string ContactDetails, string Position)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ContactDetails = ContactDetails;
            this.Position = Position;
        }

        /// <summary>
        /// This method set subdivision in class employee.
        /// </summary>
        /// <param name="sd">Subdivision object</param>
        public void SetSubdivision(Subdivision sd)
        {
            this.Subdivision = sd;
        }

        /// <summary>
        /// This method sets employer.
        /// </summary>
        /// <param name="emp">Employee object</param>
        public void SetEmployer(Employee emp)
        {
            this.Employer = emp;
        }

        /// <summary>
        /// This method changes employee's subdivision.
        /// </summary>
        /// <param name="oldSubdivision">Old subdivision object</param>
        /// <param name="newSubdivision">New subdivision object</param>
        public void ChangeSubdivision(Subdivision newSubdivision)
        {
            this.Subdivision.RemoveEmployee(this);
            newSubdivision.AddEmployee(this);
        }

        /// <summary>
        /// This method display data.
        /// </summary>
        public void DisplayData()
        {
            if(this.Employer != null && this.Subdivision != null)
            {
                Console.WriteLine(this.FirstName + "\t" + this.LastName + "\t" + this.Position + "\t" + this.Subdivision.Name + "\t" + this.Employer.FirstName);
            }
            else if(this.Employer == null && this.Subdivision != null)
            {
                Console.WriteLine(this.FirstName + "\t " + this.LastName + "\t" + this.Position + "\t" + this.Subdivision.Name + "\t" );
            }
            else if(this.Subdivision == null && this.Employer != null)
            {
                Console.WriteLine(this.FirstName + "\t" + this.LastName + "\t" + this.Position + "\t" + " " + "\t" + this.Employer.FirstName);
            }
            
        }


    }

   
}
