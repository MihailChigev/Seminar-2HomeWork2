//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.WriteLine("Введите 3-х значное число:   ");
int number = int.Parse(Console.ReadLine());
int digit = (number / 10) % 10;
Console.WriteLine(" -> " + digit);