// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] GetArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// int ArrayPositive(int[] array)
// {
//     int positive = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0)
//         {
//             positive++;
//         }


//     }
//     return positive;
// }
// int ArrayLength = 7;
// Console.Write($"Введите {ArrayLength} чисел: ");
// int[] result = GetArray(7, -1000, 1000);
// int positive = ArrayPositive(result);
// Console.Write($"{positive} чисел больше 0 ввел пользователь");