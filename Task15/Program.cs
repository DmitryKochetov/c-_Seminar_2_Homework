/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Clear();

Console.WriteLine("Введите целое положительное число, обозначающее день недели, а я проверю, выходной ли он");
int day = Convert.ToInt32(Console.ReadLine());

if (day <= 0 || day > 7)
{
    Console.WriteLine("Вы ввели неправильное число");
}

else if (day < 6) Console.WriteLine($"{day} -> нет");
else
{
    Console.WriteLine($"{day} -> да");
}
