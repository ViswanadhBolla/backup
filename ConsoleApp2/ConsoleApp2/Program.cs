
namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Employee employee = new Employee();
            employee.AcceptDetails();
            employee.DisplayDetails();
            Employee employee1 = new Employee(20000);
            employee1.DisplayDetails();
            GC.Collect();
        }
    }
}