using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Person
{
    public class Library_user : Person
    {
        protected int ReadersTicketNumber;
        protected Date DateIssue;
        protected double AmountMonthlyReadersFee;

        public Library_user(string firstName, string lastName, Date dateOfBirth, int readersTicketNumber, Date dateIssue, double amountMonthlyReadersFee) : base(firstName, lastName, dateOfBirth)
        {
            SetReadersTicketNumber(readersTicketNumber);
            SetDateIssue(dateIssue);
            SetAmountMonthlyReadersFee(amountMonthlyReadersFee);
        }

        public Library_user(string firstName, string lastName, Date dateOfBirth, int readersTicketNumber, Date dateIssue) : base(firstName, lastName, dateOfBirth)
        {
            SetReadersTicketNumber(readersTicketNumber);
            SetDateIssue(dateIssue);
            SetAmountMonthlyReadersFee(0);
        }

        public void SetReadersTicketNumber(int readersTicketNumber)
        {
            if (readersTicketNumber >= 1)
                ReadersTicketNumber = readersTicketNumber;
            else ReadersTicketNumber = 0;
        }

        public void SetDateIssue(Date dateIssue)
        {
            DateIssue = dateIssue;
        }

        public void SetAmountMonthlyReadersFee(double amountMonthlyReadersFee)
        {
            if (amountMonthlyReadersFee > 0)
                AmountMonthlyReadersFee = amountMonthlyReadersFee;
            else AmountMonthlyReadersFee = 0;
        }

        public int GetReadersTicketNumber()
        {
            return ReadersTicketNumber;
        }

        public Date GetDateIssue()
        {
            return DateIssue;
        }

        public double GetAmountMonthlyReadersFee()
        {
            return AmountMonthlyReadersFee;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Користувач бібліотеки: {FirstName} {LastName} {DateOfBirth.GetInfo()}\nНомер читацького квитка: {ReadersTicketNumber}\nДата видачі: {DateIssue.GetInfo()}\nРозмір щомісячного читацького внеску: {AmountMonthlyReadersFee}\n");
        }
    }
}
