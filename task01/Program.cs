/* Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
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
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,100);
        }
    }
}

void PrintArray(int [,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++) 
{  
    for (int j = 0; j < matr.GetLength(1); j++)   
    {
        System.Console.Write($"{matr[i,j]}; "); 
    }
    System.Console.WriteLine();
}
}

void Sort(int [,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int a = 0; a < matr.GetLength(1)-1; a++)
            {
                if (matr[i, a] > matr[i, a+1])
                {
                    int z = matr[i, a];
                    matr[i, a] = matr[i, a+1];
                    matr[i, a+1] = z;
                }
            }
        }
        System.Console.WriteLine();
    }
}


System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Sort(matrix);
PrintArray(matrix);
