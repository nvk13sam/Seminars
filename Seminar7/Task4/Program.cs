// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int rows = SetNumber("m");
int column = SetNumber("n");
int[,] matrix = GetRandomMatrix (rows, column, 99, 10);
PrintMatrix(matrix);
Console.WriteLine();
int summa = ReturnSum(matrix);
Console.WriteLine($"Сумма элементов на главной дагонали равна {summa}");

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

int ReturnSum(int[,] matrix)
{
	int summa = 0;
	for (int i = 0; i <  matrix.GetLength(0); i++)
	{
		for (int j = 0; j <  matrix.GetLength(1); j++)
		{
			if(i==j)
			{
				summa+=matrix[i,j];
			}
		}
	}
	return summa;
}

void PrintMatrix(int[,] matrix) 
{
	for (int i = 0; i < matrix.GetLength(0); i++)// matrix.GetLength(0) - считает количество строк
	{
		for (int j = 0; j < matrix.GetLength(1); j++)    //matrix.GetLength(1) - считает количество столбцов
		{
			System.Console.Write($"{matrix[i,j]}  ");
		}
		System.Console.WriteLine();
	}

}

