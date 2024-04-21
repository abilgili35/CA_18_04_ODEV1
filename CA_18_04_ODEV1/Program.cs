using BussinessLogic.Services;
using DataAccess.Models;

namespace CA_18_04_ODEV1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            BaseService<Product> productService = new BaseService<Product>(context);

            foreach(Product p in productService.GetAll())
            {
                Console.WriteLine($"{p.ProductName} {p.UnitPrice}");
            }

            Console.WriteLine("\n\n");

            BaseService<Employee> employeeService = new BaseService<Employee>(context);

            foreach (Employee e in employeeService.GetAll())
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} {e.Title}");
            }

            Console.Read();
        }
    }
}
