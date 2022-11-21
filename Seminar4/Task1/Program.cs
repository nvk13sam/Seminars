// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int numA = SetNumber("A");			//Чтобы каждый раз его не прописывать,
				//его можно вызвать по имени SetNumber и аргументу A
int sum = GetSumAllNumbersToNumberA(numA);  		//здесь мы получаем результат

Print(sum);

int SetNumber(string str)				//1. Это кусок кода, который часто требуется	
{                              			//чтобы запросить от юзера ввести число
	System.Console.WriteLine($"Enter number {str}");           // - "Enter number A" напишет консоль, т.к. аргумент A в 6 строке
	int num  = int.Parse(Console.ReadLine());
	return num;
}

int GetSumAllNumbersToNumberA(int numA)			//2. Этот кусок кода суммирует числа от 1 до А
{
	int sum = 0;
	for (int i = 1; i <= numA; i++)
	{
		sum += i;
	}
	return sum;
}

void Print(int num)				//3. Выводит на консоль
{
	System.Console.WriteLine($"Сумма чисел от 1 до {numA} = {num}");
}