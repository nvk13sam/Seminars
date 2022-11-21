// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int num = SetNumber("num");

int SetNumber(string str)
{
    System.Console.WriteLine($"Enter number {str}");
    int num = int.Parse(Console.ReadLine());
    return num;
}
int[] fib = new int[num];
int i = 2;
fib[0] = 1;
fib[1] = 1;
while (i < num)
{
    fib[i] = fib[i - 1] + fib[i - 2];
    i++;
}
for (int j = 0; j < num; j++)
{
    Console.Write(fib[j] + ", ");
}

