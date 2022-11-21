// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


class Program // это калсс
{
	
	static void Main(string[] args) // Метод - это именуемая часть кода. вызвать - Main
			 // программа запускается с метода Main
	{
		Console.WriteLine("Введите X");
		int X = int.Parse(Console.ReadLine());

		Console.WriteLine("Введите Y");
		int Y = int.Parse(Console.ReadLine());

		int num = ViewQuarterNumber(X, Y);
		Console.WriteLine($"Точка с введенными координатами находится в {num} четверти");
		System.Console.WriteLine();

		X = X + Y; //если добавить новое условие, то програма посчитает и его
		Y = Y - X;
		
		num = Program.ViewQuarterNumber(X, Y); // здесь метод Main обратится к методу ViewQuarterNumber()
				         // и посчитает X = X + Y и Y = Y - X и покажет в какой четверти результат
		num = ViewQuarterNumber (X, Y);
		Console.WriteLine($" для X = X + Y; Y = Y - X;  {num} четверть");

      	//ViewQuarterNumber();

	}

	static int ViewQuarterNumber(int X, int Y) //здесь вычисляется в какой четверти находится точка 
				//и возвращает номер четверти

	{
		int num = 0;
		if (X > 0 && Y > 0)
		{
			num = 1;
		}
		else if (X < 0 && Y > 0)
		{
			num = 2;
		}
		else if (X < 0 && Y < 0)
		{
			num = 3;
		}
		else if (X > 0 && Y < 0)
		{
			num = 4;
		}
		return num;

	}
}