//  Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести  сообщение для пользователя.

int SetNumber(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int columns, int maxVal = 100, int minVal = -100)
{
    int[,] matrix = new int[rows, columns];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(minVal, maxVal + 1);
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
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

static int[,] SwapRowOnColumn(int[,] matrix)
{
	int rows = matrix.GetLength(0);
	int columns = matrix.GetLength(1);
	int [,] temp = new int [columns,rows];
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			temp[j, i] = matrix[i, j];
		}
	}
	return temp;
}

//int[,] matrix = GetRandomMatrix(4,4);
int rows = SetNumber("Enter rows value: ");
int columns = SetNumber("Enter columns value: ");
int[,] matrix = GetRandomMatrix(rows, columns);
PrintMatrix(matrix);

System.Console.WriteLine();
PrintMatrix(SwapRowOnColumn(matrix));
// еще какой-то метод
// static int[,] SwapRow(int[,] matrix)
// {
//     int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)]; //int rows = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // которая заменяет строки на столбцы.
//         {
//             matrix2[j, i] = matrix[i, j];
//         }
//     }
//     return matrix2;
// }

// //PrintMatrix(SwapRow(matrix));
