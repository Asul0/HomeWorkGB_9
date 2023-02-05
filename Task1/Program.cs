// Задача 64: Напишите программу, которая реализует рекурсивный
// метод вывода всех натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using static System.Console;
Clear();

WriteLine("Введите число N: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] rename = Array.ConvertAll(parameters, Convert.ToInt32);

string result = GetNumbers(rename[0]);
WriteLine(result);

string GetNumbers(int num)
{
   if (num == 1) return num.ToString();
   else return $"{num},{GetNumbers(num - 1)}";
}