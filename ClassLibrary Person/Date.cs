using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Person
{
    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;

        public Date()
        {
            SetYear(2003);
            SetMonth(10);
            SetDay(11);
        }

        public Date(int year, int month, int day) 
        {
            SetYear(year);
            SetMonth(month);
            SetDay(day);
        }

        public Date(int month, int day)
        {
            SetYear(2020);
            SetMonth(month);
            SetDay(day);
        }

        public void SetYear(int year)
        {
            if (year >= 1930 && year <= 2100)
                Year = year;
            else Year = 1930;
        }

        public void SetMonth(int month)
        {
            if (month >= 1 && month <= 12)
                Month = month;
            else Month = 1;
        }

        public void SetDay(int day)
        {
            if (day >= 1 && day <= 31)
                Day = day;
            else Day = 1;
        }

        public int GetYear()
        {
            return Year;
        }

        public int GetMonth()
        {
            return Month;
        }

        public int GetDay()
        {
            return Day;
        }

        public string GetInfo()
        {
            return $"{Year}.{AddZeroForOutput(Month)}.{AddZeroForOutput(Day)}";
        }

        private string AddZeroForOutput(int num)
        {
            string numAddZero = Convert.ToString(num);
            if (numAddZero.Length == 1)
                return '0' + numAddZero;
            return numAddZero;
        }
    }
}
