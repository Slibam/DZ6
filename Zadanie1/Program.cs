﻿//Напишите программу, которая на вход принимает индексы элемента в двумерном массиве
//и возвращает значение этого элемента или же указание, что такого элемента нет.
void Zadanie36()
{
    int stroc = 3;
    int stolb = 4;
    int[,] numbers = new int[stroc, stolb];
    FilArray(numbers);
    Poick2mer(numbers);
    Array(numbers);
}
void FilArray(int[,] numbers, int minRazmer = 0, int maxRazmer = 9)
{
    maxRazmer++;
    Random rand = new Random();
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            numbers[i, j] = rand.Next(minRazmer, maxRazmer);
        }
    }
}

void Array(int[,] numbers, int minRazmer = 0, int maxRazmer = 9)
{
    maxRazmer++;
    Random rand = new Random();
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            Console.WriteLine($"A[{i}, {j}] = {numbers[i, j]}");

        }
    }
}

void Poick2mer(int[,] numbers, int minRazmer = 0, int maxRazmer = 9)
{
    Console.Write("Какое число будем искать: ");
    int N = Convert.ToInt32(Console.ReadLine());
    bool flag = false;
    string h = null;
    maxRazmer++;
    Random rand = new Random();
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb && !flag; j++)
        {
            flag = numbers[i, j] == N;
            if (numbers[i, j] == N)
                h = ($"A[{i}, {j}]");
        }
    }
    if (flag)
    {
        Console.WriteLine();
        Console.WriteLine($"В массиве число {N} присутствует!");
        Console.WriteLine($"Находится в {h}");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"В массиве числа {N} нет!");
    }
}
Zadanie36();
