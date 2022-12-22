/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    int result;

while (true)
{
       if (int.TryParse(Console.ReadLine(), out result) && result >99 && result <1000)
       {
        break;
       }
    else
    {
        Console.WriteLine("Это не трехзначное число. Введите трехзначное число.");
    }
    }
    return result;
}

int result = GetNumberFromConsole("Введите трехзначное число");
int number = ((result / 10) % 10);
Console.WriteLine($"{number}");