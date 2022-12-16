internal class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int count50, count20, count11, count5, count2, count1, count;
        count50 = count20 = count11 = count5 = count2 = count1 = count = 0;
        while (n / 5000 > 0 || n / 2000 > 0 || n / 1000 > 0 || n / 500 > 0 || n / 200 > 0 || n / 100 > 0 || n / 50 > 0)
        {
            while (n / 5000 > 0)
            {
                n = n - 5000;
                count50 = count50 + 1;
            }
            while (n / 2000 > 0)
            {
                n = n - 2000;
                count20 = count20 + 1;
            }
            while (n / 1000 > 0)
            {
                n = n - 1000;
                count11 = count11 + 1;
            }
            while (n / 500 > 0)
            {
                n = n - 500;
                count5 = count5 + 1;
            }
            while (n / 200 > 0)
            {
                n = n - 200;
                count2 = count2 + 1;
            }
            while (n / 100 > 0)
            {
                n = n - 100;
                count1 = count1 + 1;
            }
            while (n / 50 > 0)
            {
                n = n - 50;
                count = count + 1;
            }
        }
        if (n != 0)
        {
            Console.WriteLine("Error");
        }
        else 
        {
            if (count50 > 0) Console.WriteLine($"Купюра 5000={count50}");
            if (count20 > 0) Console.WriteLine($"Купюра 2000={count20}");
            if (count11 > 0) Console.WriteLine($"Купюра 1000={count11}");
            if (count5 > 0) Console.WriteLine($"Купюра 500={count5}");
            if (count2 > 0) Console.WriteLine($"Купюра 200={count2}");
            if (count1 > 0) Console.WriteLine($"Купюра 100={count1}");
            if (count > 0) Console.WriteLine($"Купюра 50={count}"); 
        }
    }
}