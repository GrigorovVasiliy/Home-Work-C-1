Console.Clear();
Console.Write("Веедите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

   while (n >= 100)
     {
        n /= 10;
    }
    int n2 = n % 10;
Console.WriteLine($"Вторая цифра числа: {n2}.");
    