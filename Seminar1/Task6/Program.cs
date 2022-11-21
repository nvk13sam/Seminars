// Задача №5. Напишите программу, которая на вход
// принимает одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


// V 1.0
// Console.WriteLine("Введите положительное число N");
//  int num = Convert.ToInt32(Console.ReadLine());
//  if(num < 0){Console.WriteLine("Число отрицательное"); return;} // return  не дает замыкать цикл,  break подходит для switch
 
//  int num_minus = -num;
//  while (num_minus != num)
//  {
//                Console.Write(num_minus + ", ");
//                num_minus++; 
//  }
//  Console.WriteLine(num);
//****************************************************
// V 2.0
// Console.WriteLine("Введите положительное число N");
//  int num = Convert.ToInt32(Console.ReadLine());
//  if(num < 0){
//                Console.WriteLine("Число отрицательное");
// } 
//  else{
//                int num_minus = -num;
//                while (num_minus != num)
//                {
//                               Console.Write(num_minus + ", ");
//                               num_minus++; 
//                }
//                Console.WriteLine(num);
//  }

 // V 3.0
 Console.WriteLine("Введите положительное число N");
 int num = Convert.ToInt32(Console.ReadLine());
 int num_minus = -num;

 for (int i = num ; i < num; i++)
 {
               Console.Write(num_minus + ", ");
 }