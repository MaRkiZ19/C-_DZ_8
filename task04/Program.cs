// .Сформируйте трёхмерный массив из случайных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2



int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int n = Num("n столбцов");
int m = Num("m строк");
int q = Num("q глубину");

int[,,] matrix = new int[m,n,q];

void FillArray (int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           for (int q = 0; q < matr.GetLength(2); q++)
           {
              matr[i,j,q]=new Random().Next(1,100);
           }
        }
    }
}






System.Console.WriteLine();
FillArray(matrix);



