Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a == b || a == c || b == c)
{
    Console.WriteLine("Вероятно вы ввели одинаковые числа, попробуйте ввести разные числа");
    Console.WriteLine("Введите первое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    c = Convert.ToInt32(Console.ReadLine());
}
if (a > b)
    {
        max = a;
    }
else
    {
        max = b;
    }
if(max > c)
    {
        max = max;
    }
else
    {
        max = c;
    }
Console.WriteLine($"Max: {max}");