namespace HumanResourcesDepartment
{
    public class Person
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string ContactDetails { get; protected set; }

        /// <summary>
        /// Initial constructor
        /// </summary>
        /// <param name="FirstName">Firstname of employee. Type: string. </param>
        /// <param name="LastName">Lastname of employee. Type: string. </param>
        /// <param name="ContactDetails">Contact details of employee. Type: string. </param>
        public Person(string FirstName, string LastName, string ContactDetails)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ContactDetails = ContactDetails;
        }
    }
}
