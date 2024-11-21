namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using default constructor
            Employee emp1 = new Employee();
            emp1.Display();
            // Using name and salary constructor
            Employee emp2 = new Employee("Ahmed", 7000);
            emp2.Display();
            // Using name, salary, and id constructor
            Employee emp3 = new Employee("Mohamed", 8000, "EMP001");
            emp3.Display();
            // Using name, salary, id, and phone constructor
            Employee emp4 = new Employee("Ali", 9000, "EMP002", "01012345678");
            emp4.Display();
            // Using full constructor
            Employee emp5 = new Employee("Omar", 10000, "EMP003", "01112345678", "123 Main St");

            emp5.Display();

            Employee[] employees = new Employee[4];
            employees[0] = emp1;
            employees[1] = emp2;
            employees[2] = emp3;
            employees[3] = emp4;
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"************** employee{i} *******************");
                employees[i].Display();
              
            }


        }
    }
}
