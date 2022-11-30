/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int digit = 0;
int i = 0;
if (number >= 100 & number <= 999)
{
  digit = number%10;
  Console.WriteLine(digit);
}
  
if (number < 100)
{  
 Console.WriteLine("третьей цифры нет");   
}
if(number > 999);
    
{
    while(number > 1000)
    {
     number = number / 10;
     i++;
    }
    Console.WriteLine(number%10);

}
    
     
    
   
   
