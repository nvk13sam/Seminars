// Инфо про TryParse и out int
// 	Console.WriteLine("Hello world!");
// 	int a;
// 	if(Int32.TryParse(Console.ReadLine(), out int a))
// 	{
// 	Console.WriteLine(a);
// 	}
// *****************************************************
// Console.WriteLine("Hello world!");
// 	int num = 0;
// 	if(Int32.TryParse(Console.ReadLine(),out num))
// 	{
// 	      Console.WriteLine(num);
// 	}
// //********************************************************
 //Задача 46: Задайте двумерный массив размера m на n, заполненный случайными 
// целыми числами. Выведите полученный массив на экран.


int rows = SetNumber("m");
int column = SetNumber("n");
int[,] matrix = GetRandomMatrix (rows, column, 99, 10);// int[,] matrix = GetRandomMatrix (rows, column, int minValue, int maxValue)

PrintMatrix(matrix);

int SetNumber(string name)	
{     
	string[] arr = name.Split(""); 			
	System.Console.WriteLine($"Enter number {name}");
	int num  = int.Parse(Console.ReadLine());
	return num;
}
int[,] GetRandomMatrix(int rows, int column, int maxValue = 100, int minValue = -100)
{
	int[,] matrix = new int[rows,column];
	var random = new Random();
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < column; j++)
		{
			matrix[i,j] = random.Next(minValue, maxValue + 1);	
		}
	}
	return matrix;
}
void PrintMatrix(int[,] matrix) 
{
	for (int i = 0; i < matrix.GetLength(0); i++)// GetLength(0) - считает количество строк
	{
		for (int j = 0; j < matrix.GetLength(1); j++)    // GetLength(1) - считает количество столбцов
		{
			System.Console.Write($"{matrix[i,j]}  ");
		}
		System.Console.WriteLine();
	}
}

 