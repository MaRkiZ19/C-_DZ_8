/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int n = Num("n столбцов");
int m = Num("m строк");

int[,] matrix = new int[m,n];

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,10);
        }
    }
}

void PrintArray(int [,] matr)
{
for (int i = 0; i < matrix.GetLength(0); i++) 
{  
    for (int j = 0; j < matrix.GetLength(1); j++)   
    {
        System.Console.Write($"{matrix[i,j]}; "); 
    }
    System.Console.WriteLine();
}
}

void Sum(int [,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i,j];
        }
        matr[i,0] = sum;
        System.Console.WriteLine();
    }
}

void Min(int [,]matr)
{
    int min = 0;
    int IndMin = 0;
     min = matr[0,0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (/*matr[i,0] < matr[i+1, 0] ||*/ matr[i,0] < min) 
        {
            min = matr[i,0];
            IndMin = i+1;
        } 
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"{IndMin}");
}

System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Sum(matrix);
PrintArray(matrix);
Min(matrix);
