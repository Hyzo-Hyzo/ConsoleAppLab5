using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab5
{
    public class Employee
    {
        private string name;
        private int age;
        private decimal salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public static Employee operator +(Employee e, decimal amount)
        {
            e.salary += amount;
            return e;
        }

        public static Employee operator -(Employee e, decimal amount)
        {
            e.salary -= amount;
            return e;
        }

        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.salary == e2.salary;
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
        }

        public static bool operator >(Employee e1, Employee e2)
        {
            return e1.salary > e2.salary;
        }

        public static bool operator <(Employee e1, Employee e2)
        {
            return e1.salary < e2.salary;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee e = (Employee)obj;
            return salary == e.salary;
        }

        public override int GetHashCode()
        {
            return salary.GetHashCode();
        }
    }
}
