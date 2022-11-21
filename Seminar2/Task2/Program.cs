// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// V 1.0
// var random = new Random();
// int num = random.Next(100,1000);
// System.Console.WriteLine($"Число {num}");
// int numFirst = num / 100;//564/100=5
// int numThird = num % 10;
// int result = numFirst * 10 + numThird;
// System.Console.WriteLine($"Новое число, которое состоит из сотен и единиц первого числа {result}"); */


// V 2.0
int num = new Random().Next(100,1000);
System.Console.WriteLine($"Число {num}");
int numFirst = num / 100;//564/100=5
int numThird = num % 10; // возвращает остаток от деления, т.е. последнюю цифру
int result = numFirst * 10 + numThird;

System.Console.WriteLine($"Новое число, которое состоит из сотен и единиц первого числа {result}"); 