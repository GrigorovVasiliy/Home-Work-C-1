﻿Console.WriteLine("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

while(a == b)
{
    Console.WriteLine("Числа равны, попробуцте внести разные числа");
    Console.WriteLine("Введите первое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    b = Convert.ToInt32(Console.ReadLine());
}

if (a > b)
Console.WriteLine($"Max: {a}");
else
Console.WriteLine($"Max: {b}");