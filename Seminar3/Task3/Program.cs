// Задача №21. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите 1X, 1Y");
double num1X = double.Parse(Console.ReadLine());
double num1Y = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите 2X, 2Y");
double num2X = double.Parse(Console.ReadLine());
double num2Y = double.Parse(Console.ReadLine());

double distantions = Math.Sqrt(Math.Pow((num2X - num1X),2) + Math.Pow((num2Y-num1Y),2));

Console.WriteLine($"Расстояние между точками равно {Math.Round(distantions, 2)}");