Console.Clear();
Console.Write("Введите 5-ти значное число: ");
string n = Convert.ToString(Console.ReadLine());

if(n[0]==n[4] && n[1]==n[3])
System.Console.WriteLine("Число является ПАЛИНДРОМОМ");
else
System.Console.WriteLine("Число НЕ является ПАЛИНДРОМОМ");

