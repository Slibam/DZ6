//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
void Zadanie36()
{
    Console.WriteLine("Укажите колисество строк массива (m)");
    int stroc = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите колисество столбцов массива(n)");
    int stolb = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[stroc, stolb];
    FilArray(numbers);
    PrintArrayMas(numbers);
}
void FilArray(int[,] numbers)
{
    Random rand = new Random();
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            numbers[i, j] = rand.Next(-1000, 1000);
        }
    }
}
void PrintArrayMas(int[,] numbers)
{
    int stroc = numbers.GetLength(0);
    int stolb = numbers.GetLength(1);
    double Y=0;
    double X=0;
    for (int i = 0; i < stroc; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            X = numbers[i, j];
            Y = X / 10;
            Console.Write($"{Y:0.0}\t");
        }
        Console.WriteLine();
    }
}
Zadanie36();
