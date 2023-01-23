// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int num = new Random().Next();
int temp = num;
int reverseNum = 0;

while (temp > 0)
{
    reverseNum = (reverseNum * 10) + (temp % 10);
    temp = temp / 10;
}
if (reverseNum == num)
{
    System.Console.WriteLine($"{num} -> да");
}
else
{
    System.Console.WriteLine($"{num} -> нет");
}