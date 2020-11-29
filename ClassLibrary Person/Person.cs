using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Person
{
    public class Person
    {
        protected string FirstName;
        protected string LastName;
        protected Date DateOfBirth;

        public Person(string firstName, string lastName, Date dateOfBirth)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            SetDateOfBirth(dateOfBirth);
        }

        public Person(string firstName)
        {
            SetFirstName(firstName);
            SetLastName("Unknown");
            SetDateOfBirth(new Date(2000, 1, 1));
        }

        public void SetFirstName(string firstName)
        {
            if (firstName.Length >= 4)
                FirstName = firstName;
            else FirstName = "Unknown";
        }

        public void SetLastName(string lastName)
        {
            if (lastName.Length >= 4)
                LastName = lastName;
            else LastName = "Unknown";
        }

        public void SetDateOfBirth(Date dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public Date GetDateOfBirth()
        {
            return DateOfBirth;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {DateOfBirth.GetInfo()}\n");
        }
    }
}
