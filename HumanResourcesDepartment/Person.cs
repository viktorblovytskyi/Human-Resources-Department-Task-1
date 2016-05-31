namespace HumanResourcesDepartment
{
    public class Person
    {
        protected int id;
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string ContactDetails { get; protected set; }

        /// <summary>
        /// Initial constructor
        /// </summary>
        /// <param name="id">Employee's id. Type: int</param>
        /// <param name="FirstName">Firstname of employee. Type: string. </param>
        /// <param name="LastName">Lastname of employee. Type: string. </param>
        /// <param name="ContactDetails">Contact details of employee. Type: string. </param>
        public Person(int id, string FirstName, string LastName, string ContactDetails)
        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ContactDetails = ContactDetails;
        }
    }
}
