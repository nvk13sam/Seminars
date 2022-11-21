// Задача №22. Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

System.Console.WriteLine("Введите число");
double num = double.Parse(Console.ReadLine());
// double result = 0;
for (int i = 1; i <= num; i++)
{
              Console.Write ($"{i*i}, ");
}