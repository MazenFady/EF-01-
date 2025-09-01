using DBFIRST.Context;  
namespace DBFIRST
{
    public class Program
    {
        public static async Task Main()
        {
             var context = new NorthwindContext() ;

            context.Procedures.DiscontinuedProductsAsync();
            foreach (var item in context.Employees)
            {
                Console.WriteLine(item.FirstName);
            }
            var result = await context.Procedures.SelectAllProductsAsync();

            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            await context.Procedures.DeleteProductByIDAsync(75);

        }
    }
}