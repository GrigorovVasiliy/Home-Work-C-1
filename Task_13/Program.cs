// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введи любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
string a2 = Convert.ToString(a);
    if(a2.Length > 2)
        Console.WriteLine(a2[2]);
    else
        Console.WriteLine("Нет 3-й цифры");