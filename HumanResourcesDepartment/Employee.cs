using System;

namespace HumanResourcesDepartment
{
    [Serializable]
    sealed public class Employee: Person
    {
        public Employee Employer { get;  set; }
        public string Position { get; private set; }
        public Subdivision Subdivision { get; private set; }

        /// <summary>
        /// Initial constructor
        /// </summary>
        /// <param name="id">Employee's id. Type: int</param>
        /// <param name="FirstName">Firstname of employee. Type: string. </param>
        /// <param name="LastName">Lastname of employee. Type: string. </param>
        /// <param name="ContactDetails">Contact details of employee. Type: string. </param>
        /// <param name="Position">Employye's position. Type: string. </param>
        public Employee (int id, string FirstName, string LastName, string ContactDetails, string Position) : 
            base(id, FirstName, LastName, ContactDetails)
        {            
            this.Position = Position;
        }

        /// <summary>
        /// Initial constructor
        /// </summary>
        /// <param name="id">Employee's id. Type: int</param>
        /// <param name="FirstName">Firstname of employee. Type: string. </param>
        /// <param name="LastName">Lastname of employee. Type: string. </param>
        /// <param name="ContactDetails">Contact details of employee. Type: string. </param>
        /// <param name="Position">Employye's position. Type: string. </param>
        /// <param name="Employer">Employee's employer. Type: Employee.</param>
        public Employee(int id, string FirstName, string LastName, string ContactDetails, string Position, Employee Employer) : 
            base(id, FirstName, LastName, ContactDetails)
        {
            this.Position = Position;
            this.Employer = Employer;
        }

        /// <summary>
        /// Initial constructor
        /// </summary>
        /// <param name="id">Employee's id. Type: int</param>
        /// <param name="FirstName">Firstname of employee. Type: string. </param>
        /// <param name="LastName">Lastname of employee. Type: string. </param>
        /// <param name="ContactDetails">Contact details of employee. Type: string. </param>
        /// <param name="Position">Employye's position. Type: string. </param>
        /// <param name="Subdiv">Subdivision object</param>
        public Employee(int id, string FirstName, string LastName, string ContactDetails, string Position, Subdivision Subdiv) : 
            base(id, FirstName, LastName, ContactDetails)
        {
            this.Position = Position;
            this.Subdivision = Subdiv;
        }

        /// <summary>
        /// Initial constructor
        /// </summary>
        /// <param name="id">Employee's id. Type: int</param>
        /// <param name="FirstName">Firstname of employee. Type: string. </param>
        /// <param name="LastName">Lastname of employee. Type: string. </param>
        /// <param name="ContactDetails">Contact details of employee. Type: string. </param>
        /// <param name="Position">Employye's position. Type: string. </param>
        /// <param name="Employer">Employee's employer. Type: Employee.</param>
        /// <param name="Subdiv">Subdivision object</param>
        public Employee(int id, string FirstName, string LastName, string ContactDetails, string Position, Employee Employer, Subdivision Subdiv) : 
            base(id, FirstName, LastName, ContactDetails)
        {
            this.Position = Position;
            this.Employer = Employer;
            this.Subdivision = Subdiv;
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
        /// This method removes subdivision.
        /// </summary>
        public void RemoveSubdivision()
        {
            this.Subdivision = null;
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
            base.ContactDetails = contactDetails;
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
        /// This method changes all employee's information.  
        /// </summary>
        /// <param name="firstName">string</param>
        /// <param name="lastName">string</param>
        /// <param name="contactDetails">string</param>
        /// <param name="position">string</param>
        /// <param name="subdivision">Subdivision</param>
        /// <param name="employer">Employee</param>
        public void ChangeAllData(string firstName, string lastName, string contactDetails, string position, Subdivision subdivision, Employee employer)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            base.ContactDetails = contactDetails;
            this.Position = position;
            this.Employer = employer;
            this.ChangeSubdivision(subdivision);
        }        
    }   
}