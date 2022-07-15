/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (num <= 0)
{
    Console.WriteLine("Вы ввели неправильное число");
}

else if (num / 100 < 1) Console.WriteLine($"{num} -> третьей цифры нет");
else
{
    result = ShowMeThirdDigit(num);
    Console.WriteLine($"{num} -> {result}");
}
// Думаю, что в другом случае также правильно было бы ынутри метода проверять, поступило ли в него число с нужным количеством разрядов, 
// но в данном случае проверка реализована ранее, не стал дублировать.

int ShowMeThirdDigit(int number)
{
    int tempNum = num;
    int count = 0;
    while (tempNum > 0)
    {
        count++;
        tempNum = tempNum / 10;
    }
// чтобы не реализовывать цикл возведения в степень, решил обратиться к более короткому способу
    result = (num / Convert.ToInt32(Math.Pow(10, count - 3))) % 10;

    return result;
}

