/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пяти значное:");
int numbers = int.Parse(Console.ReadLine());
int[] num = new int[5];
num[0] = numbers / 10000;
num[1] = numbers % 10000 / 1000;
num[2] = numbers % 1000 / 100;
num[3] = numbers % 100 / 10;
num[4] = numbers % 10;

bool isPalindrome = true;
for (int i = 0; i < num.Length / 2; i++)
{
    if (num[i] != num[num.Length - 1 - i])
    {
        isPalindrome = false;
        break;
    }
}
if (isPalindrome)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
Console.ReadKey();

