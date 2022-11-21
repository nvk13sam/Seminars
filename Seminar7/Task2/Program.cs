
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int SetNumber(string name)	
{     
	string[] arr = name.Split(""); 			
	System.Console.WriteLine($"Enter number {name}");
	int num  = int.Parse(Console.ReadLine());
	return num;
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
int rows = SetNumber("m");
int column = SetNumber("n");
int[,] matrix = new int[rows, column];

for (int i = 0; i <  matrix.GetLength(0); i++)
{
	for (int j = 0; j <  matrix.GetLength(1); j++)
	{
		matrix[i,j] = i+j;
	}
}

PrintMatrix(matrix);
