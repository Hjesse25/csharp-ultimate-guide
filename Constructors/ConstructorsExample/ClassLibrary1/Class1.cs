public class Employee
{
    //fields
    public int empID;
    public string empName;
    public string job;

    //static field
    public static string companyName;

    //instance constructor
    public Employee(int empID, string empName, string job)
    {
        this.empID = empID;
        this.empName = empName;
        this.job = job;
    }

    public Employee(int empID, string empName)
    {
        this.empID = empID;
        this.empName = empName;
    }

    public Employee()
    {
        empID = 1;
    }

    //static constructor
    static Employee()
    {
        companyName = "ABC Industries";
    }
}