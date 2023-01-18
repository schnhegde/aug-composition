using CompoExample;

public class Program
{
    public static void Main()
    {
        var employee1 = new Employee("e101", new Person("Alex", "Smith"));
        var employee2 = new EmployeeExtended("Bernie", "Sanders", "e102");

        Console.WriteLine(employee1.getFullName());
        Console.WriteLine(employee2.getFullName());
    }
}