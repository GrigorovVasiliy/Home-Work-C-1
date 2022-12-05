// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.Write("Введи трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string a2 = Convert.ToString(a);
Console.WriteLine(a2[1]);
