﻿// Задача 39: Напишите программу, 
// которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// size - размер массива, мин - мин. число в рандоме, макс - максимальное
// int[] GetArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // Только нули
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// // PascalCase
// void PrintArray(int[] arr)
// {
//     // [ 10    20 ]
//     // arr[i] = item
//     // item = arr[0].
//     // foreach(int item in arr)
//     // {
//     //     Console.Write(item + "  "); // "\t" - расстояние между эл. массива в 1 Таб
//     // }
//     Console.Write("[  ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "  "); // "\t" - расстояние между эл. массива в 1 Таб
//     }
//     Console.Write("]");
// }

// int[] result = GetArray(9, 0, 15); // Массив на 9 элементов, числа от 0 до 15 вкл-но
// PrintArray(result);
// Console.WriteLine();
// PrintArray(CopyArray(result)); // Без создания массива для хранения "перевертыша"
// // 1. Запись в новый массив 
// int[] CopyArray(int[] array)
// {
//     int[] copyArray = new int[array.Length];
//     int size = array.Length;
//     //start - 0 элемент, end - индекс последнего элемента
//     for (int start = 0, end = size - 1; start < size; start++, end--)
//     {
//         copyArray[start] = array[end];
//         // copyArray[0] = 40
//         // copyArray[1] = array[2]; copyArray[1] = 30
//         // copyArray[2] = array[1]; copyArray[2] = 20
//         // copyArray[3] = array[0]; copyArray[3] = 10
//     }
//     return copyArray;
// }

// // 2. Меняю элементы в текущем массиве
// void ReverseArray(int[] array)
// {
//     int size = array.Length; // size - 1
//     for (int i = 0, j = size - 1; i < size / 2; i++, j--)
//     {
//         int temp = array[i];// [10,40,30,20,50], temp = 10
//         array[i] = array[j]; // [50,40,30,20,50]
//         array[j] = temp; // [50,40,30,20,temp]; // [50,40,30,20,10]

//     }
// }
// Console.WriteLine();
// ReverseArray(result); // Берется массив result и он сразу меняется
// PrintArray(result);

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// int a = 100;
// int b = 4;
// int c = 5;

// bool IsTriangle(int a, int b, int c)
// {
//     return (((a + b) > c) && ((b + c) > a) && ((a + c) > b));
// }
// Console.WriteLine(IsTriangle(a, b, c));
// if (IsTriangle(a, b, c))  // IsTriangle(a,b,c) == true
// {
//     Console.WriteLine("Треугольник существует");
// }
// else
// {
//     Console.WriteLine("Треугольник НЕ существует");
// }

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 2)
// {
//     return;
// }
// int[] fibonacci = new int[N];
// fibonacci[0] = 0;
// fibonacci[1] = 1;
// for (int i = 2; i < N; i++)
// {
//     fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
// }

// Console.WriteLine($"Массив: {string.Join("; ", fibonacci)}");
