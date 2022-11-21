// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int numA = SetNumber("A");
//можно записать также string str = "B";
//или string str = "Sum"
//тогда пишем int nunSum = SetNumber(str);
int count = GetCountNumbers(numA); // string str запрашивает данные из строки,
                           // которую вводит юзер {str} в 13 строке   
Print(count);

int SetNumber(string str)	
{                              			
	System.Console.WriteLine($"Enter {str} numbers");// можно вместо "Enter numbers {str}" писать "sum" или "N"
	int num = int.Parse(Console.ReadLine());
	return num;
}

int GetCountNumbers(int numA)
{
      int count = 0;
      while (numA > 0)
      {
            count++;          // 9951/10 = 995
            numA = numA/10;   // 995/10  = 99
      }                       // 99/10 = 9
      return count;           // 9/10 = 0
}

void Print(int count)				//3. Выводит на консоль
{
	System.Console.WriteLine($"Количество цифр в числе {numA} - {count}");
}