// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"{number} -> "); 
if (number < 0)
{
    number = number * -1;
}
int SumNum (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number % 10);
        //Console.WriteLine (sum);
        number = number / 10;
    }
    return sum;
}
Console.Write($"{SumNum (number)} "); 