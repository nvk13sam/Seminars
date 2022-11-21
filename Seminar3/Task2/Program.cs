// Задача №18. Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// V 1.0
// System.Console.WriteLine("Введите номер четверти от 1 до 4");
// int enter = int.Parse(Console.ReadLine());
// if(enter == 1)
// {Console.WriteLine($"X = от 0 до + бесконечности. Y = от 0 до + бесконечности");}
// if(enter == 2)
// {Console.WriteLine($"X = от - бесконечности до 0. Y = от 0 до + бесконечности");}
// if(enter == 3)
// {Console.WriteLine($"X = от - бесконечности до 0. Y = от - бесконечности до 0");}
// if(enter == 4)
// {Console.WriteLine($"X = от 0 до + бесконечности. Y = от - бесконечности до 0");}
// // else {Console.WriteLine($"нет четверти");}


Console.WriteLine ("Введите номер четверти от 1 до 4 ");

int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{Console.WriteLine ("x > 0; y > 0");}

else if (num == 2)
{Console.WriteLine ("x < 0; y > 0");}

else if(num == 3)
{Console.WriteLine ("x < 0; y < 0");}

else if (num == 4)
{Console.WriteLine ("x > 0; y < 0");}

else {Console.WriteLine ("нет четверти");}
