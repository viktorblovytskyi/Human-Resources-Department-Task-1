using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesDepartment
{
  
    /// <summary>
    /// 
    /// </summary>
    sealed public class Employee: Person
    {
        private Employee Employer { get; set; }
        private string Position { get; set; }
        private Subdivision Subdivision { get; set; }

        /// <summary>
        /// 
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
        /// <param name="sd">Subdivision</param>
        public void SetSubdivision(Subdivision sd)
        {
            this.Subdivision = sd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emp"></param>
        public void SetEmployer(Employee emp)
        {
            this.Employer = emp;
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
