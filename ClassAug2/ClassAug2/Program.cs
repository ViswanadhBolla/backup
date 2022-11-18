
namespace ClassAug2
{

    internal class Program
    {
        public static Employee e2 = new Employee(102, "Ram");

        
        public static void Main(string[] args)
        {
            Console.WriteLine(Employee.count);
           

            Employee e1 = new Employee(101, "Ravi");
            Console.WriteLine(Employee.count);
            e1.getDetails();


            e2.getDetails();
            Console.WriteLine(Employee.count);

            Employee e3 = new Employee();
            e3.Id = 103;
            e3.Name = "robert";

            Console.Write($"{e3.Id}");



        }
    }
}