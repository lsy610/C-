using _0911_2;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Drink> drinks = new List<Drink>();
            List<Orderitem> orders = new List<Orderitem>();
            //新增飲料品項
            AddNewDrink(drinks);
            //顯示所有飲料菜單
            DisplayDrinkMenu(drinks);
            //訂購飲料
            PlaceOrder(orders,drinks);
            //計算售價
            CalculatePrice(drinks,drinks);
            
        }

        private static void CalculatePrice(List<Drink> drinks1, List<Drink> drinks2)
        {
            Console.WriteLine("");
        }

        private static void PlaceOrder(List<Orderitem> orders, List<Drink> drinks)
        {
            Console.WriteLine("開始訂購飲料");
        }

        private static void DisplayDrinkMenu(List<Drink> myDrinks)
        {
            //for (int i = 0; i<drinks.Count; i++)
            //{
            //    Console.WriteLine($"{drinks[i].Name}  {drinks[i].Size}  {drinks[i].Price}");
            //}

            Console.WriteLine("飲料清單");
            Console.WriteLine("--------------------------------");
            int i = 0;
            Console.WriteLine(String.Format("{0,-4}{1,-5}{2,2}{3,7}", "編號", "品名","大小","價格"));
            Console.WriteLine("--------------------------------");
            foreach (Drink drink in myDrinks)
            {
                Console.WriteLine($"{i,-6}{drink.Name,-5}{drink.Size,-5}{drink.Price,7:C0}");
                i++;
            }
            Console.WriteLine("--------------------------------");

        }

        private static void AddNewDrink(List<Drink> myDrinks)
        {
            //Drink drink1 = new Drink() { Name = "紅茶", Size = "大杯", Price = 50 };
            //drinks.Add(drink1);

            myDrinks.Add(new Drink() { Name = "紅茶", Size = "大杯", Price = 50 });
            myDrinks.Add(new Drink() { Name = "紅茶", Size = "小杯", Price = 30 });
            myDrinks.Add(new Drink() { Name = "綠茶", Size = "大杯", Price = 50 });
            myDrinks.Add(new Drink() { Name = "綠茶", Size = "大杯", Price = 30 });
            myDrinks.Add(new Drink() { Name = "咖啡", Size = "大杯", Price = 70 });
            myDrinks.Add(new Drink() { Name = "咖啡", Size = "大杯", Price = 50 });
        }
    }
}