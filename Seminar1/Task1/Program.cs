// Найти сумму всех четных чисел от 1 до 15
// int startNumber = 1;

// while (startNumber <= 15)
// {
//        if(startNumber % 2 == 0)
//        {
//                sum = sum + startNumber;
//        }        
//        startNumber += 1;
// }
// Console.WriteLine(sum);

// V 2.0
int sum = 0;
int startNumber = 2;

while (startNumber <= 15)
{
       sum = sum + startNumber;        
       startNumber += 2;
} 
Console.WriteLine(sum);


