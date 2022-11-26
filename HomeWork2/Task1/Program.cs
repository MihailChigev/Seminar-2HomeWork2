// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.WriteLine("Введите цифру от 1  до 7");
int Digit = int.Parse(Console.ReadLine());
if (Digit <= 5)
{
    Console.WriteLine(" нет ");
}
else
{
    Console.WriteLine(" да ");
}