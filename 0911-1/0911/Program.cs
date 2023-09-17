internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("請輸入一個整數ｎ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                Console.WriteLine($"{i,2}*{j,2}={i * j,2}");
            }
            Console.WriteLine();


        }

    }
}