using System;
using System.Collections.Generic;
using System.Globalization;

namespace AumentaSalarioLista
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get;private set; }
        public double Salary { get;private set; }

        public Employee(int Id,string Name, double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary = Salary * (1 + percentage / 100); 
        }

        public override string ToString()
        {
            return 
                Id   +
                ", " +
                Name +
                ", " +
                Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
