//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int NumEnter(string str)
{
      System.Console.WriteLine(str);
      int num = int.Parse(Console.ReadLine());
      return num;
}

int[,] GetRandomMatrix(int rows, int columns, int maxValue = 100, int minValue = -100)
{
      int[,] matrix = new int[rows, columns];
      Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                  for (int j = 0; j < columns; j++)
                  {
                        matrix[i, j] = random.Next(minValue, maxValue + 1);
                  }
            }
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			System.Console.Write($"{matrix[i, j]}" + "\t");
		}
		System.Console.WriteLine();
	}
}

static int[,] SwapRow(int [,] matrix)
{
	int rows = matrix.GetLength(0)-1;

		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			int temp = matrix[0, j];
			matrix[0, j] = matrix[rows, j];
			matrix[rows, j] = temp;
		}
	return matrix;
}

int[,] matrix = new int[3,3];
int rows = NumEnter("Введите число строк m");
int column = NumEnter("Введите число столбцов n");
matrix = GetRandomMatrix (rows, column);
PrintMatrix(matrix);

Console.WriteLine();
SwapRow(matrix);   // или можно записать так: 
PrintMatrix(matrix);// PrintMatrix(SwapRow(matrix)); вместо 2-х строк

