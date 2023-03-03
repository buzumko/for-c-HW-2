// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
string userString = Console.ReadLine() ?? "";
int stringLenght = userString.Length;
int userNumber = int.Parse(userString);

///////
if (stringLenght < 3)
{
    Console.Write("третьей цифры нет");
}
else
{
    int[] dijits = new int[stringLenght];
    int intermediateNumber = userNumber;
    for (int index = 0; index < stringLenght; index++)
    {
       dijits[index] = intermediateNumber % 10;
        intermediateNumber = (intermediateNumber -  dijits[index]) / 10;
    }
    Console.Write(dijits[stringLenght - 3]);
}
