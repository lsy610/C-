using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Drink> drinks = new List<Drink>();

            //Drink drink1 = new Drink() { Name = "紅茶", Size = "大杯", Price = 50 };
            //drinks.Add(drink1);

            drinks.Add(new Drink() { Name = "紅茶", Size = "大杯", Price = 50 });
            drinks.Add(new Drink() { Name = "紅茶", Size = "小杯", Price = 30 });
            drinks.Add(new Drink() { Name = "綠茶", Size = "大杯", Price = 50 });
            drinks.Add(new Drink() { Name = "綠茶", Size = "大杯", Price = 30 });
            drinks.Add(new Drink() { Name = "咖啡", Size = "大杯", Price = 70 });
            drinks.Add(new Drink() { Name = "咖啡", Size = "大杯", Price = 50 });

            //for (int i = 0; i<drinks.Count; i++)
            //{
            //    Console.WriteLine($"{drinks[i].Name}  {drinks[i].Size}  {drinks[i].Price}");
            //}

            foreach (Drink drink in drinks)
            {
                Console.WriteLine($"{drink.Name,-5}{drink.Size,-3}{drink.Price,5:C0}");
            }
        }
    }
}