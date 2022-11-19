// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное
// на само себя).
// Например:
// ● 4 -> 16
// ● -3 -> 9
// ● -7 -> 49

Console.WriteLine("Enter number: ");
string strNumber = Console.ReadLine();
// Console.WriteLine(strNumber); - вернет то же число
int num = Convert.ToInt32(strNumber);
// short num = Convert.ToInt16(strNumber);
// long num = Convert.ToInt64(strNumber);
int sqr = num * num;
System.Console.WriteLine($"Number {num} square = {sqr}");
