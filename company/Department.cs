using System;
using System.Collections.Generic;
using System.Text;

namespace company
{
    public class Department
    {
        public Department()
        {
            this.Employees = new Employee[0];
        }

        public string Name;
        public int EmployeeLimit;
        public int SalaryLimit;
        public Employee[] Employees;

        public void AddEmployee(Employee employee)
        {
            if (EmployeeLimit > this.Employees.Length)
            {
                Array.Resize(ref this.Employees, this.Employees.Length + 1);
                this.Employees[this.Employees.Length - 1] = employee;
            }

        }
        public Department(int salarylimit)
        {

            this.SalaryLimit = salarylimit;
            Employee salary = new Employee();

            if (salary.Salary > salarylimit)
            {
                Console.WriteLine("Salary limiti kecdiniz!");
            }
        }
        //public int Salarylimit
        //{
        //    get { return SalaryLimit; }
        //    set
        //    {
        //        Employee salary = new Employee();

        //        if (salary.Salary > SalaryLimit)
        //        {
        //            Console.WriteLine("Salary limiti kecdiniz!");
        //        }
        //    }

        //}
    }
}
