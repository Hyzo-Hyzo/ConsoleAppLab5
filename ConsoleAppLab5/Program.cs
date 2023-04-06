namespace ConsoleAppLab5
{
    internal class Program
    {
        static void Main()
        {
            //1
            Employee employee1 = new Employee();
            employee1.Name = "John";
            employee1.Age = 30;
            employee1.Salary = 50000;

            Employee employee2 = new Employee();
            employee2.Name = "Jane";
            employee2.Age = 25;
            employee2.Salary = 60000;



            Console.WriteLine("1 працівник  " + employee1.Name + " age" + employee1.Age + " " + employee1.Salary);
            Console.WriteLine("2 працівник  " + employee2.Name + " age " + employee2.Age + " " + employee2.Salary);
            if (employee1 == employee2)
            {
                Console.WriteLine("Зарплати працівників рівні");
            }
            else if (employee1 > employee2)
            {
                Console.WriteLine("Зарплата працівника 1 більша за зарплату працівника 2");
            }
            else if (employee1 < employee2)
            {
                Console.WriteLine("Зарплата працівника 1 менша за зарплату працівника 2");
            }
            else
            {
                Console.WriteLine("Зарплата працівника 1 менша за зарплату працівника 2");
            }
            employee1 += 63000;
            Console.WriteLine("employee1 salary +63000");
            Console.WriteLine("1 працівник  " + employee1.Name + " age " + employee1.Age + " " + employee1.Salary);
            Console.WriteLine("2 працівник  " + employee2.Name + " age" + employee2.Age + " " + employee2.Salary);
            if (employee1 == employee2)
            {
                Console.WriteLine("Зарплати працівників рівні");
            }
            else if (employee1 > employee2)
            {
                Console.WriteLine("Зарплата працівника 1 більша за зарплату працівника 2");
            }
            else if (employee1 < employee2)
            {
                Console.WriteLine("Зарплата працівника 1 менша за зарплату працівника 2");
            }
            else
            {
                Console.WriteLine("Зарплата працівника 1 менша за зарплату працівника 2");
            }

            //2
            Matrix m1 = new Matrix(2, 2);
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;

            Matrix m2 = new Matrix(2, 2);
            m2[0, 0] = 5;
            m2[0, 1] = 6;
            m2[1, 0] = 7;
            m2[1, 1] = 8;

            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;
            Matrix m5 = m1 * m2;
            Matrix m6 = m1 * 2;
            Matrix m7 = m1 / m2;
            Matrix m8 = m1 / 2;


            Console.WriteLine(" m1[0, 0] = 1;\r\n            m1[0, 1] = 2;\r\n            m1[1, 0] = 3;\r\n            m1[1, 1] = 4;");
            Console.WriteLine("m2[0, 0] = 5;\r\n            m2[0, 1] = 6;\r\n            m2[1, 0] = 7;\r\n            m2[1, 1] = 8;");
            Console.WriteLine("m1:");
            Matrix.PrintMatrix(m1);
            Console.WriteLine("m2:");
            Matrix.PrintMatrix(m2);
            Console.WriteLine("m1 + m2:");
            Matrix.PrintMatrix(m3);
            Console.WriteLine("m1 - m2:");
            Matrix.PrintMatrix(m4);
            Console.WriteLine("m1 * m2:");
            Matrix.PrintMatrix(m5);
            Console.WriteLine("m1 * 2:");
            Matrix.PrintMatrix(m6);
            Console.WriteLine("m1 / m2:");
            Matrix.PrintMatrix(m7);
            Console.WriteLine("m1 / 2:");
            Matrix.PrintMatrix(m8);

            //3
            City City1 = new City("Laos",3000000);
            City City2 = new City("Ottava", 2400000);

            Console.WriteLine("1 city Laos 3mln ");
            Console.WriteLine("2 city Ottava 2,4mln " );
            if (City1 == City2)
            {
                Console.WriteLine("У містах однаково людей");
            }
            else if (City1 > City2)
            {
                Console.WriteLine("У 1 місті більше людей ніж у 2");
            }
            else if (City1 < City2)
            {
                Console.WriteLine("У 1 місті менше людей ніж у 2");
            }
           
            City2 += 5000000;
            Console.WriteLine(" City1  Population = 5000000;");

            if (City1 == City2)
            {
                Console.WriteLine("У містах однаково людей");
            }
            else if (City1 > City2)
            {
                Console.WriteLine("У 1 місті більше людей ніж у 2");
            }
            else if (City1 < City2)
            {
                Console.WriteLine("У 1 місті менше людей ніж у 2");
            }
            //4
            
          CreditCard card = new CreditCard("1234 5678 9012 3456",  123, 1000);
          Console.WriteLine("card = "+card.CardNumber+" Cvc=  "+card.CvcCode+" Balance= "+card.Balance);

          card +=4500;
          Console.WriteLine("Balanse +4500");
          Console.WriteLine("card = " + card.CardNumber + " Cvc=  " + card.CvcCode + " Balanse=  " + card.Balance);

          Console.Write("enter Cvc: ");
          string input = Console.ReadLine(); // считываем строку с клавиатуры
          int number = int.Parse(input);
          if (card.CvcCode == number)
          {
              Console.WriteLine("CVC = "+number);
          }
          else
          {
              Console.WriteLine("CVC !="+ number);
          }


          if (card.Balance < 1000)
          {
              Console.WriteLine("sum money < 1000");
          }
          else
          {
              Console.WriteLine("sum money >1000");
          }
         





        }
    }
}