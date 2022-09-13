// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int expand = int.Parse(Console.ReadLine());

Console.Write($"{number}, {expand} -> "); 

int GetMultiplyed (int number)
{
    int number1 = number;
    for (int count = 1; count < expand; count++)
    {
        number = number1 * number;
        //Console.WriteLine(number);
    }
    return number;

}

Console.Write($"{GetMultiplyed(number)}");