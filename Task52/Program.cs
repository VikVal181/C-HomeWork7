// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintAverage(int[,] Array){
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < Array.GetLength(1); ++i) {
        double average = 0;
        for (int j = 0; j < Array.GetLength(0); ++j) {
            average += Array[j, i];
        }
        average /= Array.GetLength(0);
        Console.Write($"{average} ");
    }
}

Console.Clear();
Console.WriteLine("Введте размерность массива");
Console.WriteLine("Введте m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Array = FellArray(m, n);

PrintArray(Array);

PrintAverage(Array);