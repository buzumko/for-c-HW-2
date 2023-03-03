// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным

Console.Write("Введите цифру (1-7), обозначающую день недели: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

//////

if ((userNumber == 6) ^ (userNumber == 7))
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}

