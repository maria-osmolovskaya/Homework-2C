/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    int result;

while (true)
{
       if (int.TryParse(Console.ReadLine(), out result) && result < 8 && result > 0)
       {
        break;
       }
    else
    {
        Console.WriteLine("Это не число дня недели. Введите число от 1 до 7.");
    }
    }
    return result;
}

int result = GetNumberFromConsole("Введите число, обозначающее день недели - от 1 до 7.");

if (result>5) 
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}