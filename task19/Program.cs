// ДЗ. Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

// Вариант 1 (через string)

Console.WriteLine("Вариант 1. Введите пятизначное число: ");
string num = Convert.ToString(Console.ReadLine());
int len = num.ToString().Length;

if (len == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine(num + " - палиндром");
    }
    else
    {
        Console.WriteLine(num + " - не является палиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}


// Вариант 2 (через int)

Console.WriteLine("Вариант 2. Введите пятизначное число: ");
int five = Convert.ToInt32(Console.ReadLine());
while (five < 10000 || five > 99999) //Проверяем правильность введения числа
    {
        Console.WriteLine("Вы ввели неверное число. Введите пятизначное число: ");
        five = Convert.ToInt32(Console.ReadLine());
    }
if ((five / 10000) % 10 != five % 10 | (five / 1000) % 10 != (five / 10) % 10)
    {
        Console.WriteLine(five + " - не является палиндромом");
    }
    else if ((five / 1000) % 10 != (five / 10) % 10)
    {
        Console.WriteLine(five + " - не является палиндромом");
    }
else 
    {
        Console.WriteLine(five + " - палиндром");
    }


// 3 Вариант с циклом for внутри метода, для числа любой длины

string palindrom (int number) // Создаем метод
{ 
    int len = number.ToString().Length;
    string newNum = Convert.ToString(number);
    for (int i = 0; i < len/2; i++) // Цикл для проверки зеркальных значений
        {
            if (newNum[i] != newNum[len - 1 - i]) return " - не палиндром";
        }
    return " - палиндром";
}

Console.WriteLine("Вариант 3. Введите число для проверки на палиндром: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number + palindrom(number));

// Вариант 3 мне больше нравится