using System;
using System.Collections.Generic;
using System.Text;

namespace company
{
   public class Employee
    {
        //Employee Name və Surname dəyərləri yalnız hərflərdən ibarət olmalıdır və Böyük hərflə başlamalıdır
        //Salary dəyəri 250-dən aşağı ola bilməz
        private string _name;
        private string _surname;
        private double _salary;

        public string Name
        {
            get { return _name; }
            set
            {
                foreach (var item in value)
                {
                    if(char.IsLetter(item)&& char.IsUpper(value[0]))
                    {
                        _name = value;
                    }
                    
                } 
            } 
        }

        public string Surname 
        { 
            get { return _surname; } 
            set
            {
                foreach (var item in value)
                {
                    if (char.IsLetter(item) && char.IsUpper(value[0]))
                    {
                        _surname = value;
                    }
                }
            }
        }
        public double Salary { get { return _salary; }
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
            }
        }

    }
}
