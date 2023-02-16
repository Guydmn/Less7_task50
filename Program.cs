// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите длинну массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] doubleArray = new double [m, n];
Random rnd = new Random();

for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        doubleArray[i, j] = rnd.Next(0, 100);
        Console.Write($"{doubleArray[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Введите проверяемое число на наличие его в массиве: ");
int f = Convert.ToInt32(Console.ReadLine());
string abc = ($"{f} - такого числа в массиве нет");

for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        if(doubleArray[i, j] == f)
        {
            abc = ($"{f} - такое число есть в массиве ");
        }
    }
}
Console.Write(abc);
