using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Person
{
    public class Teacher : Person
    {
        protected string Position;
        protected string Chair;
        protected string NameUniversity;

        public Teacher(string firstName, string lastName, Date dateOfBirth, string position, string chair, string nameUniversity) : base(firstName, lastName, dateOfBirth)
        {
            SetPosition(position);
            SetChair(chair);
            SetNameUniversity(nameUniversity);
        }

        public Teacher(string firstName, string lastName, Date dateOfBirth, string position, string chair) : base(firstName, lastName, dateOfBirth)
        {
            SetPosition(position);
            SetChair(chair);
            SetNameUniversity("Unknown");
        }

        public void SetPosition(string position)
        {
            if (position.Length >= 4)
                Position = position;
            else Position = "Unknown";
        }

        public void SetChair(string chair)
        {
            if (chair.Length >= 4)
                Chair = chair;
            else Chair = "Unknown";
        }

        public void SetNameUniversity(string nameUniversity)
        {
            if (nameUniversity.Length >= 2)
                NameUniversity = nameUniversity;
            else NameUniversity = "Unknown";
        }

        public string GetPosition()
        {
            return Position;
        }

        public string GetChair()
        {
            return Chair;
        }

        public string GetNameUniversity()
        {
            return NameUniversity;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Викладач: {FirstName} {LastName} {DateOfBirth.GetInfo()}\nПосада: {Position}\nКафедра: {Chair}\nНазва вищого навчального закладу: {NameUniversity}\n");
        }
    }
}
