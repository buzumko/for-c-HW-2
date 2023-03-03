// Задача 10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите целое трёхзначное число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

///////

int secondDigit = ((userNumber - userNumber % 10) % 100) / 10;
Console.Write(secondDigit);
