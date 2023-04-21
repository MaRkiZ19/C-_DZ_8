/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrix1 = new int[2,2];
int[,] matrix2 = new int[2,2];
int[,] matrix3 = new int[2,2];

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=new Random().Next(1,10);
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

FillArray(matrix1);
FillArray(matrix2);
PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);
System.Console.WriteLine();

matrix3[0,0] = matrix1[0,0] * matrix2[0,0] + matrix1[0,1] * matrix2[1,0];
matrix3[0,1] = matrix1[0,0] * matrix2[0,1] + matrix1[0,1] * matrix2[1,1];
matrix3[1,0] = matrix1[1,0] * matrix2[0,0] + matrix1[1,1] * matrix2[1,0];
matrix3[1,1] = matrix1[1,0] * matrix2[0,1] + matrix1[1,1] * matrix2[1,1];

PrintArray(matrix3);


