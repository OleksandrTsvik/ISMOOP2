using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Person
{
    public class Applicant : Person
    {
        protected PointZNO PointsZNO;
        protected double PointsDocumentEducation;
        protected string NameSecondarySchool;

        public Applicant(string firstName, string lastName, Date dateOfBirth, PointZNO pointsZNO, double pointsDocumentEducation, string nameSecondarySchool) : base(firstName, lastName, dateOfBirth)
        {
            SetPointsZNO(pointsZNO);
            SetPointsDocumentEducation(pointsDocumentEducation);
            SetNameSecondarySchool(nameSecondarySchool);
        }

        public Applicant(string firstName, string lastName, Date dateOfBirth, double pointsDocumentEducation) : base(firstName, lastName, dateOfBirth)
        {
            SetPointsZNO(new PointZNO(120, 120, 120));
            SetPointsDocumentEducation(pointsDocumentEducation);
            SetNameSecondarySchool("Unknown");
        }

        public void SetPointsZNO(PointZNO pointsZNO)
        {
            PointsZNO = pointsZNO;
        }

        public void SetPointsDocumentEducation(double pointsDocumentEducation)
        {
            if ((pointsDocumentEducation > 0 && pointsDocumentEducation <= 12) || (pointsDocumentEducation >= 100 && pointsDocumentEducation <= 200))
                PointsDocumentEducation = pointsDocumentEducation;
            else PointsDocumentEducation = 0;
        }

        public void SetNameSecondarySchool(string nameSecondarySchool)
        {
            if (nameSecondarySchool.Length >= 2)
                NameSecondarySchool = nameSecondarySchool;
            else NameSecondarySchool = "Unknown";
        }

        public PointZNO GetPointsZNO()
        {
            return PointsZNO;
        }

        public double GetPointsDocumentEducation()
        {
            return PointsDocumentEducation;
        }

        public string GetNameSecondarySchool()
        {
            return NameSecondarySchool;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Абітурієнт: {FirstName} {LastName} {DateOfBirth.GetInfo()}\nКількість балів сертифікатів ЗНО:\n{PointsZNO.GetInfo()}Кількість балів за документ про освіту - {PointsDocumentEducation}\nНазва загальноосвітнього навчального закладу - {NameSecondarySchool}\n");
        }
    }
}
