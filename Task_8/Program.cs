// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i =0;

if(a % 2 == 0)
{
    while(i<a)
    {
        i += 2;
        Console.WriteLine(i);
 
    }
}
else if(a % 2 == 1)
{
    a = a - 1;
        while(i<a)
         {
             i += 2;
            Console.WriteLine(i);
         }
}