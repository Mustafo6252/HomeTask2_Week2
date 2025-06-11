namespace Homework2_week2.Person
{

    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Address;

        public string GetFullName()
        {
            return $"My name is {FirstName} {LastName}";
        }

        public int GetBirthYear()
        {
            return 2025 - Age;
        }

        public string GetAddress()
        {
            return $"My address is {Address}";
        }

    }
}
