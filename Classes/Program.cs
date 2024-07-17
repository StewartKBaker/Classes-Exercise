namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Car() { Make = "Mercedes-Benz", Model = "GLE", Year = "2024" };
            Console.WriteLine($"My latest cars is a {mercedes.Year} {mercedes.Make} {mercedes.Model}");
        }
    }
}
