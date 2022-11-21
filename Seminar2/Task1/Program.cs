// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8        12-> 2       85 -> 8
// V 1.0
// var random = new Random();   
// int num = random.Next(10, 100);
// //int num = new Random.Next(10, 100); - это тоже самое, что и 2 строки выше
// Console.WriteLine(num);
// int numFirst = num / 10; // 46 -> 4
// int numSecond = num % 10; // 46 -> 6
// int max = numFirst;
// if(max < numSecond)
// {
// 	max = numSecond;
// }
//  Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");
// V 2.0
var random = new Random();   
int num = random.Next(10, 100);
//int num = new Random.Next(10, 100); - это тоже самое, что и 2 строки выше
Console.WriteLine(num);
int numFirst = num / 10; // 46 -> 4
int numSecond = num % 10; // 46 -> 6
int max = 0;
if(numFirst < numSecond)
{
	max = numSecond;
}
else
{
	max = numFirst;
}
Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");
