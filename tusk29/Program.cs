// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int [] array = new int[8];

void Rand(int [] arr)
{
    int length = arr.Length;
    int index = 0;
    while (index < length-1)
    {
        arr[index] = new Random().Next(0,100);
        Console.Write($"{arr[index]}, ");
        index++;  
    }
        Console.Write($"{arr[index]} ->");
        Console.Write(" [");
        index = 0;
         while (index < length-1)
    {
        Console.Write($"{arr[index]}, ");
        index++;  
    }
        Console.Write($"{arr[index]}");

    Console.Write("]");
}
Rand(array);