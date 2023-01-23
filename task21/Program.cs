// ДЗ. 21. Напишите программу, которая принимает на вход координаты
//  координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2,1,-7) -> 15,84  A (7,-5,0); B(1,-1,9) -> 11,53


// Вариант 1
double distance3D () // Метод, который выдает результат
{
string [,] array = {{"x1", "y1", "z1"}, {"x2", "y2", "z2"}};
int [,] coordin = new int [2, 3];
for (int i = 0; i < 2; i++)
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Введите " + array[i, j]);
        coordin [i, j] = Convert.ToInt32(Console.ReadLine()); // Запоминаем координаты
    }
double result = Math.Sqrt(Math.Pow((coordin [0, 0]-coordin [1, 0]), 2) + Math.Pow((coordin [0, 1]-coordin [1, 1]), 2) + Math.Pow((coordin [0, 2]-coordin [1, 2]), 2));
return result;
}

double result = distance3D();
Console.WriteLine("Расстояние между точками = " + result);



// Вариант 2

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result2 = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
Console.WriteLine("Расстояние между точками = " + result2);