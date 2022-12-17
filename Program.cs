// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

// int n = 0;

// Console.Write("Введите натуральное число: ");
// bool boolN = int.TryParse(Console.ReadLine(), out int numberN);

// //Проверяем на число
// if (!boolN)
// {
//     Console.WriteLine("Введено неверное значение!");
//     return;
// }
// else
// {
//     n = numberN;
// }


// //Рекурсия 
// void printAllNaturalNumbers(int m)
// {
//     if (m == 1)
//     {
//         Console.Write(1);
//         return;
//     }
//     else
//     {
//         Console.Write(m + ", ");
//         printAllNaturalNumbers(m - 1);
//     }
// }

// printAllNaturalNumbers(n);

// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// int M = InputNumbers("Введите M: ");
// int N = InputNumbers("Введите N: "); 
// int temp = M; 
// if (M > N) 
// {
//   M = N; 
//   N = temp; 
// PrintSummRange(M, N, temp=0); 

// int InputNumbers(string input) 
// {
//   Console.Write(input); 
//   int output = Convert.ToInt32(Console.ReadLine()); 
//   return output; 
// } 

// void PrintSummRange(int M, int N, int summ) 
//   summ = summ + N; 
//   if (N <= M) 
//   {
//     Console.Write($"Сумма элементов= {summ} "); 
//     return; // повтор
//   }
//   PrintSummRange(M, N - 1, summ); 
// }