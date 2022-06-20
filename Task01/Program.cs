// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    Console.Write(message);
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);
    return number;
}
int value = Prompt("Введите первое число (A): ");
int power = Prompt("Введите второе число (B): ");

Console.WriteLine($"Число {value} (А) в степени {power} (B) будет равно = {Math.Pow(value, power):N0}");
