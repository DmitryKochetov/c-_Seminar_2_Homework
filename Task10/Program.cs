/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int num = new Random().Next(100, 1000);
int result;

Console.Clear();

result = ShowMeSecondDigit(num);

Console.WriteLine($"{num} -> {result}");

int ShowMeSecondDigit(int number)
{
    result = num % 100;
    return result / 10;
}