namespace CompanyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
       ItEmployees employees = new JuniorDeveloper("Bruno Bueno","Male", 27);
            Console.WriteLine($"{employees.AllItEmployees[0].FullName}");
        }
    }
}