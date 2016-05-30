using System;


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
        /// <param name="subdivision">Subdivision object</param>
        public void SetSubdivision(Subdivision subdivision)
        {
            this.Subdivision = subdivision;
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
        /// <param name="subdivision">New subdivision object</param>
        public void ChangeSubdivision(Subdivision subdivision)
        {
            this.Subdivision.RemoveEmployee(this);
            subdivision.AddEmployee(this);
        }

        /// <summary>
        /// This methid change employee's contact information. 
        /// </summary>
        /// <param name="contactDetails">String with new contact details</param>
        public void ChangeContactDetails(string contactDetails)
        {
            this.ContactDetails = contactDetails;
        }

        /// <summary>
        /// This method change employee's position.
        /// </summary>
        /// <param name="position">String with new position</param>
        public void ChangePosition(string position)
        {
            this.Position = position;
        }

        /// <summary>
        /// This method display data. TODO delete. 
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
            else
            {
                Console.WriteLine(this.FirstName + "\t" + this.LastName + "\t" + this.Position + "\t" + " " + "\t" + " ");
            }            
        }
    }   
}
