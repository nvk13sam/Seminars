char symbol;
double result = 0;
System.Console.WriteLine("Введите число");
double num1 = int.Parse(Console.ReadLine());
do
{
	System.Console.WriteLine("Введите знак");
	symbol = Console.ReadKey().KeyChar;
	System.Console.WriteLine();
	switch (symbol)
	{
		case '+':
		{
			System.Console.WriteLine("Введите число");
			double num2 = int.Parse(Console.ReadLine());
			result = num1 + num2;
			Console.WriteLine("Итог: "+result);
			num1 = result;
		}
		break;
	case '-':
	{
		System.Console.WriteLine("Введите число");
		double num2 = int.Parse(Console.ReadLine());
		result = num1 - num2;
		Console.WriteLine("Итог: "+result);
		num1 = result;
	}
		break;
	case '*':
	{
		System.Console.WriteLine("Введите число");
		double num2 = int.Parse(Console.ReadLine());
		result = num1 * num2;
		Console.WriteLine("Итог: "+result);
		num1 = result;
	}
		break;
	case '/':
	{
		System.Console.WriteLine("Введите число");
		double num2 = int.Parse(Console.ReadLine());
		result = num1 / num2;
		Console.WriteLine("Итог: "+result);
		num1 = result;
	}
		break;
	case '=':
	{
		Console.WriteLine("Итог: "+result);
		num1 = result;
	}
		break;
	case 'q':
	case 'Q':
	System.Console.WriteLine("Калькулятор выключен");
	continue;   // Прекращает действие цикла и возвращает в проверку условий
	default:
	{
		System.Console.WriteLine("Введите допустимый знак!");
		break;
	}
	}
}
while (symbol != 'q' && symbol != 'Q');
