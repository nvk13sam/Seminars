// double count = 0;
// double distance = 10000;
// double FirstFriendSpeed = 1;
// double SecondFriendSpeed = 2;
// double DogSpeed = 5;
// double friend = 2;
// double time = 0;

//  while (distance > 1)
//     {
//         if (friend == 1)
//         {
//             time = distance / (FirstFriendSpeed + DogSpeed);
//             friend = 2;
//         }
//         if (friend == 2)
//         {
//             time = distance / (SecondFriendSpeed + DogSpeed);
//             friend = 1;
//         }
//     distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
//     count = count + 1;
//     }        
// System.Console.WriteLine($"Собака пробежит {count} раз");

int [] numbers = {1, 8, 3, 2, 6, 48, 34, 56, 10, 98, 7};
int size = 11;
int first = numbers[0];
int second = numbers[0];
if(numbers[1] > first)
{
      first = numbers[1];
}
else
{
      second = numbers[1];
}
int current_index = 1;
while(current_index < size)
{
	if(numbers[current_index] > first)
      {
            second = first;
            first = numbers[current_index];                        
      }
      else
      {
            if (numbers[current_index] > second)
            {
                  second = numbers[current_index];
            }
	}	
	current_index++;
      
}
System.Console.WriteLine(second);