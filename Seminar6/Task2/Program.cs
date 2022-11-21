// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
int length1 = SetNumber("length1");
int length2 = SetNumber("length2");
int length3 = SetNumber("length3");
int SetNumber(string str)				
{                              			
	System.Console.WriteLine($"Enter {str}");           
	int num  = int.Parse(Console.ReadLine());
	return num;
}
if ((length1 >= length2 + length3) || (length2 >= length1 + length3) || (length3 >= length2 + length1))

{
               Console.WriteLine("Такой треугольник не существует");               
}
else
{
                Console.WriteLine("Такой треугольник существует");      
}
