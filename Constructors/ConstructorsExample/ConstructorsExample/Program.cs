class Program
{
    static void Main()
    {
        //create 3 objects for Employee
        Employee emp1 = new Employee(); //constructor 3
        emp1.empID = 101;
        emp1.empName = "Scott";
        emp1.job = "Manager";
        Employee emp2 = new Employee(102, "Dwight"); //constructor 2
        emp2.job = "Asst. Manager";
        Employee emp3 = new Employee(103, "Pam", "Clerk"); //constructor 1
        Employee emp4 = new Employee() { empName = "Ford", job = "Executive"};

        Console.WriteLine(Employee.companyName);
        Console.WriteLine("\nFirst Employee:");
        Console.WriteLine(emp1.empID);
        Console.WriteLine(emp1.empName);
        Console.WriteLine(emp1.job);
        Console.WriteLine();

        Console.WriteLine("Second Employee:");
        Console.WriteLine(emp2.empID);
        Console.WriteLine(emp2.empName);
        Console.WriteLine(emp2.job);
        Console.WriteLine();

        Console.WriteLine("Third Employee:");
        Console.WriteLine(emp3.empID);
        Console.WriteLine(emp3.empName);
        Console.WriteLine(emp3.job);
        Console.WriteLine();
    }
}
