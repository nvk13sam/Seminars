// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты

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
	for (int i = 0; i < matrix.GetLength(0); i++)// matrix.GetLength(0) - считает количество строк
	{
		for (int j = 0; j < matrix.GetLength(1); j++)    //matrix.GetLength(1) - считает количество столбцов
		{
			System.Console.Write($"{matrix[i,j]}" +"\t");
		}
		System.Console.WriteLine();
	}
}
int rows = SetNumber("m");
int column = SetNumber("n");
int[,] matrix = GetRandomMatrix (rows, column, 10, 0);
PrintMatrix(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		if(i%2 == 0 && j%2 == 0)
		{
			matrix[i,j] = matrix[i,j] * matrix[i,j];
		}
	}
}
System.Console.WriteLine();
PrintMatrix(matrix);

