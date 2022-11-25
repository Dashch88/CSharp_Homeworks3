// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Clear();

Console.WriteLine("Введите координату x 1-й точки:");
double XA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y 1-й точки:");
double YA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z 1-й точки:");
double ZA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x 2-й точки:");
double XB = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y 2-й точки:");
double YB = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z 2-й точки:");
double ZB = double.Parse(Console.ReadLine());

double distAB = Math.Sqrt(Math.Pow(XB - XA, 2) + Math.Pow(YB - YA, 2) + Math.Pow(ZB - ZA, 2));

Console.WriteLine();
Console.WriteLine("Расстояние между двух точек: " + distAB);