// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Веедите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n3 = n;

if (n < 100)
    Console.WriteLine($"Число имеет меньше 3-х цифр");
else 
{
    while (n3 > 999) 
    n3 = n3 / 10;
    Console.WriteLine($"Третья цифра числа: { n3 % 10}.");
}