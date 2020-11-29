using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Person;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Person person = new Person("Олександр", "Цвік", new Date(2002, 10, 11));
            string personLastName = person.GetLastName();
            person.ShowInfo();
            person.SetFirstName("Ivan");

            PointZNO pointZNO = new PointZNO(172);
            pointZNO.SetMaths(183);
            pointZNO.SetPhysics(145);
            Applicant applicant = new Applicant("Олександр", "Цвік", new Date(2002, 10, 11), pointZNO, 179, "ОЗНЗ Радомишльська гімназія");
            applicant.ShowInfo();
            string applicantSchool = applicant.GetNameSecondarySchool();
            applicant.SetPointsDocumentEducation(200);

            Student student1 = new Student("Олександр", "Цвік", new Date(2002, 10, 11), pointZNO, 179, "ОЗНЗ Радомишльська гімназія", "ІПЗ-20-3", "ФІКТ");
            student1.ShowInfo();
            Student student2 = new Student("Ivan", "Ivanov", new Date(2003, 11, 5), new PointZNO(192, 195, 200), 193, "Unknown", 1, "IPZ-20-1", "FICT", "ZDTU");
            student2.ShowInfo();
            string groupStudent2 = student2.GetGroup();
            student2.SetCourse(2);

            Teacher teacher = new Teacher("Ivan", "Ivanov", new Date(1985, 5, 24), "викладач", "вищої математики");
            teacher.SetLastName("Petrov");
            teacher.ShowInfo();
            string teacherUniversity = teacher.GetNameUniversity();

            Library_user libraryUser = new Library_user("Petro", "Petrov", new Date(1999, 3, 11), 23, new Date(2015, 2, 16), 60);
            libraryUser.ShowInfo();
            int libraryUserTicket = libraryUser.GetReadersTicketNumber();
            libraryUser.SetAmountMonthlyReadersFee(250);
        }
    }
}
