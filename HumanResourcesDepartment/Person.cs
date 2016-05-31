namespace HumanResourcesDepartment
{
    public class Person
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string ContactDetails { get; protected set; }

        public Person(string FirstName, string LastName, string ContactDetails)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ContactDetails = ContactDetails;
        }
    }
}
