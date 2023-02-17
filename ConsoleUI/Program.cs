using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var item in carManager.GetAll())
        {
            Console.WriteLine(item.Id);
        }
        Console.WriteLine("Hello, World!");
    }
}