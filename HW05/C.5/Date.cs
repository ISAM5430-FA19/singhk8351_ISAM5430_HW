using System;
namespace C
{
    public class Date
    {
        private int _month;
        private int _day;
        private int _year;
        public Date(int month,int day,int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }      
        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
            }
        }
        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}
