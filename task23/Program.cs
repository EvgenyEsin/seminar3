// ДЗ 23. Напишите программу, которая принимает на вход число (N)
//  и выдает таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}