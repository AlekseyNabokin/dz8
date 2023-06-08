// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+" ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Decreasing(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {   
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value array of element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value array of element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Print2DArray(myArray);
// Console.WriteLine();
// Decreasing(myArray);
// Print2DArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+" ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int SumLine(int[,] array, int i)
// {
//     int sum = array[i,0];
//     for (int j = 1; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         return sum;
// }

// int MinSumLine(int[,] array)
// {
//     int minSum = 1;
//     int sum = SumLine(array, 0);
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         if (sum > SumLine(array, i))
//         {
//             sum = SumLine(array, i);
//             minSum = i + 1;
//         }
//     }
//     return minSum;
// }
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value array of element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value array of element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Print2DArray(myArray);
// Console.WriteLine("Min sum line: " + MinSumLine(myArray));


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] Random3dArray( int rows, int columns, int field, int minValue, int maxValue ) 
// { 
//     int[,,] newArray = new int[rows, columns, field]; 
//     for(int i = 0; i < rows; i++) 
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             for(int k = 0; k < field; k++) 
//             { 
//                 newArray[i,j,k] = new Random().Next(minValue, maxValue);
//             } 
//         } 
//     } 
//     return newArray;
// } 

// static int RandomValue(int[,,] newArray, int minValue, int maxValue, int i, int j, int k)
// {
//     int value = default;
//     bool flag = true;
//     while (flag)
//     {
//         bool noStop = true;
//         value = new Random().Next(minValue, maxValue + 1);
//         for (int x = 0; x < newArray.GetLength(0) && noStop; x++)
//         {
//             for (int y = 0; y < newArray.GetLength(1) && noStop; y++)
//             {
//                 for (int z = 0; z < newArray.GetLength(2) && noStop; z++)
//                 {
//                     if (newArray[x, y, z] == value) 
//                         noStop = false; 
//                     if (x == i && y == j && z == k) 
//                         flag = false; 
//                 }
//             }
//         }
//     }
//     return value;
// }    

// void Show3dArray(int[,,] newArray) 
// { 
//     for (int i = 0; i < newArray.GetLength(0); i++) 
//     { 
//         for(int j = 0; j < newArray.GetLength(1); j++) 
//         { 
//             for(int k = 0; k < newArray.GetLength(2); k++) 
//             { 
//                 Console.Write($"{newArray[i, j, k], 1}({i},{j},{k}) \t"); 
//             }
//             Console.WriteLine();
//         }
//     } 
//     Console.WriteLine(); 
// } 

// Console.WriteLine("Input number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of field ");
// int field = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mini value of element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Random3dArray(rows, columns, field, minValue, maxValue);

// Show3dArray(myArray);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] Creat2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
            temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}
Console.WriteLine("Input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Creat2DArray(rows, columns);
Print2DArray(myArray);
