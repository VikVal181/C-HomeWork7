// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] FellArray(int m, int n) {
    int [,] TmpArray = new int[m, n];
    Random rand = new Random ();   
    
    for (int i = 0; i < m; ++i) {
        for (int j = 0; j < n; ++j) {
            TmpArray[i, j] = rand.Next(-99,100); 
        }
    }

    return TmpArray;
}

void PrintArray(int[,] Array) {
    for (int i = 0; i < Array.GetLength(0); ++i) {
        for (int j = 0; j < Array.GetLength(1); ++j) {
            if (j != 0) Console.Write(" ");
            Console.Write($"{Array[i,j]}");
        }
        Console.WriteLine($"");
    }
}

void PrintPosition(int[,] Array, int PosM, int PosN){
    if (PosM > Array.GetLength(0) || PosN > Array.GetLength(1))
        Console.WriteLine("Позиция больше размера массива");
    else
        Console.WriteLine($"{Array[PosM-1,PosN-1]}");
}

Console.Clear();
Console.WriteLine("Введте размерность массива");
Console.WriteLine("Введте m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Array = FellArray(m, n);

PrintArray(Array);

Console.WriteLine("Введте позицию");
Console.WriteLine("Введте M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте N:");
int N = Convert.ToInt32(Console.ReadLine());

PrintPosition(Array, M, N);