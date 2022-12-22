/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    int result;

while (true)
{
       if (int.TryParse(Console.ReadLine(), out result))
       {
        break;
       }
    else
    {
        Console.WriteLine("Это не число. Введите число.");
    }
    }
    return result;
}

int result = GetNumberFromConsole("Введите число");
int number = Math.Abs(result);

if (number>99) 
{
    Console.WriteLine(number.ToString()[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}