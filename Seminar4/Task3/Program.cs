// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int numN = SetNumber("N");
int sum = SumNumbers(numN);
Print(sum);

int SetNumber(string str)	
{                              			
	System.Console.WriteLine($"Enter {str} numbers");// можно вместо "Enter numbers {str}" писать "sum" или "N"
	int num = int.Parse(Console.ReadLine());
	return num;
}
int SumNumbers(int numN)
{int sum = 1;  
      for (int i = 1; i <= numN; i++)
  	{
        	sum *= i;      
  	}
      return sum;           
}
void Print(int sum)				//3. Выводит на консоль
{
	System.Console.WriteLine($"Произведение чисел от 1 до {numN} = {sum}");
}
