//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
void Zadanie36()
{
    int stroc = 3;
    int stolb = 4;
    int[,] numbers = new int[stroc, stolb];
    FilArray(numbers);
    PrintArrayMas(numbers);
    CredArefStolb(numbers);
}
void FilArray(int[,] numbers, int minRazmer = 0, int maxRazmer = 10)
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
void PrintArrayMas(int[,] numbers)
{
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void CredArefStolb(int[,] numbers)
{
    Console.WriteLine();
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    Double Sum = 0;
    Double Sred = 0;
    for (int j = 0; j < stolb; j++)
    {
        for (int i = 0; i < stroc; i++)
        {
            Sum += numbers[i, j];
        }
        Sred = Sum / stroc;
        Console.Write($"Столбец {j + 1}: ");
        Console.Write($"Сумма столбца = {Sum}, ");
        Console.Write($" Среднее арифметическое элементов столбца = {Sred:0.00}");
        Console.WriteLine();
        Console.WriteLine();
        Sum = 0;
    }
}
Zadanie36();