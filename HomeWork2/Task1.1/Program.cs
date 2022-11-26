// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.WriteLine("Введите цифру от 1  до 7");
int Digit = int.Parse(Console.ReadLine());

int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;
if(Digit == Monday)
{
Console.WriteLine("это понедельник");
}
if (Digit == Tuesday)
{
Console.WriteLine("это вторник ");
}
if(Digit == Wednesday)
{
Console.WriteLine("это среда ");
}
if (Digit == Thursday)
{
Console.WriteLine("это четверг ");
}
if (Digit == Friday)
{
Console.WriteLine("это пятница ");
}
if(Digit == Saturday)
{
Console.WriteLine("это суббота - выходной день ");
}
if (Digit == Sunday)
{
Console.WriteLine("это воскресенье - выходной день ");
}


