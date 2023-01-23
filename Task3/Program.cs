// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

int num = new Random().Next(1, 21);
System.Console.Write($"{num} -> 1");

for (int i = 2; i <= num; i++)
{
    double result = Math.Pow(i, 3);
    System.Console.Write($", {result}");
}