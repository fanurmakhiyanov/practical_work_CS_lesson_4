// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    Console.Write(message);
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}
int number = Prompt("Введите число: ");

int Sum(int maxNumber)
{
    int result = 0;
    for (int i = 0; i <= maxNumber; i++)
    {
        result = result + i;
    }
    return result;
}
System.Console.WriteLine($"Сумма цифр в числе {number} равняется {Sum(number)}");