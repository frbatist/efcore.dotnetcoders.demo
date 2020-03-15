using Microsoft.EntityFrameworkCore;    
using System;
using System.Threading.Tasks;

namespace efcore.dotnetcoders.demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = DatabaseData.GetContext();
            await context.Database.MigrateAsync();
            //await Seed(context);
            
            Console.WriteLine("Hello World!");
        }

        private static async Task Seed(Context context)
        {
            var set = context.Set<StockRecord>();
            var random = new Random();
            for (int i = 0; i < 15; i++)
            {
                string product = random.Next(999, 999999).ToString();
                for (int j = 0; j < 10; j++)
                {
                    string address = random.Next(999, 999999).ToString();
                    for (int l = 0; l < 1000; l++)
                    {
                        var quantity = random.Next(1, 999);
                        var stockRecord = new StockRecord(product, address, quantity);
                        await set.AddAsync(stockRecord);
                    }
                }
            }
            await context.SaveChangesAsync();
        }
    }
}
