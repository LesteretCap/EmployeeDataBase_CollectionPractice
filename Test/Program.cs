using System;
using System.Collections;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList employeeList = new MyList();
            
            foreach (CollectionList employee in employeeList)
            {
                Console.WriteLine("Name {0}, Post {1}, Age {2}, Sallary {3}", employee.Name, employee.Post, employee.Age, employee.Salary);
            }

            FindEmployee(employeeList);
            InputDataEmployee(employeeList);
            FindEmployee(employeeList);
        }

        static void FindEmployee(MyList employeeList)
        {
            Console.WriteLine(new string('-', 50));
            int inputEmployee = 0;
            Console.Write("Enter the number employee: ");

            inputEmployee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(employeeList[inputEmployee]);
        }

        static void InputDataEmployee(MyList employeeList)
        {
            string nameEmployee = null;
            string postEmployee = null;
            int ageEmployee = 0;
            decimal salaryEmployee = 0;

            Console.Write("Enter the name: ");
            nameEmployee = Console.ReadLine();

            Console.Write("Enter the post: ");
            postEmployee = Console.ReadLine();

            Console.Write("Enter the age: ");
            ageEmployee = int.Parse(Console.ReadLine());

            Console.Write("Enter the salary: ");
            salaryEmployee = decimal.Parse(Console.ReadLine());

            employeeList.AddEmployee(nameEmployee, postEmployee, ageEmployee, salaryEmployee);
        }
    }
}
