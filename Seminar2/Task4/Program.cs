// 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int result1 = num % 7;
int result2 = num % 23;

if (result1 == 0 && result2 == 0){
        Console.WriteLine($"Число кратно 7 и 23 одновременно");       
}
else
{
        Console.WriteLine($"Число не кратно 7 и 23 одновременно");    
}