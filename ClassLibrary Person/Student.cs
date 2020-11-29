using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Person
{
    public class Student : Applicant
    {
        protected int Course;
        protected string Group;
        protected string Faculty;
        protected string NameUniversity;

        public Student(string firstName, string lastName, Date dateOfBirth, PointZNO pointsZNO, double pointsDocumentEducation, string nameSecondarySchool, int course, string group, string faculty, string nameUniversity) : base(firstName, lastName, dateOfBirth, pointsZNO, pointsDocumentEducation, nameSecondarySchool)
        {
            SetCourse(course);
            SetGroup(group);
            SetFaculty(faculty);
            SetNameUniversity(nameUniversity);
        }

        public Student(string firstName, string lastName, Date dateOfBirth, PointZNO pointsZNO, double pointsDocumentEducation, string nameSecondarySchool, string group, string faculty) : base(firstName, lastName, dateOfBirth, pointsZNO, pointsDocumentEducation, nameSecondarySchool)
        {
            SetCourse(1);
            SetGroup(group);
            SetFaculty(faculty);
            SetNameUniversity("Державний університет «Житомирська політехніка»");
        }

        public void SetCourse(int course) 
        {
            if (course >= 1 && course <= 12)
                Course = course;
            else Course = 1;
        }

        public void SetGroup(string group)
        {
            if (group.Length >= 2)
                Group = group;
            else Group = "Unknown";
        }

        public void SetFaculty(string faculty)
        {
            if (faculty.Length >= 2)
                Faculty = faculty;
            else Faculty = "Unknown";
        }

        public void SetNameUniversity(string nameUniversity)
        {
            if (nameUniversity.Length >= 2)
                NameUniversity = nameUniversity;
            else NameUniversity = "Unknown";
        }

        public int GetCourse()
        {
            return Course;
        }

        public string GetGroup()
        {
            return Group;
        }

        public string GetFaculty()
        {
            return Faculty;
        }

        public string GetNameUniversity()
        {
            return NameUniversity;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Студент: {FirstName} {LastName} {DateOfBirth.GetInfo()}\nКількість балів сертифікатів ЗНО:\n{PointsZNO.GetInfo()}Кількість балів за документ про освіту - {PointsDocumentEducation}\nНазва загальноосвітнього навчального закладу - {NameSecondarySchool}\nКурс: {Course}\nГрупа: {Group}\nФакультет: {Faculty}\nНазва вищого навчального закладу: {NameUniversity}\n");
        }
    }
}
