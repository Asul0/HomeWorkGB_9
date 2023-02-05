// Задача 66: Напишите программу, которая реализует рекурсивный 
//метод нахождения суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using static System.Console;
Clear();

WriteLine("Введите первое число:");
int num = Convert.ToInt32(ReadLine());

WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(ReadLine());


void GapNumberSum(int num, int num2, int sum)
{
   if (num > num2)
   {
      WriteLine($"Сумма натуральных элементов в промежутке от первого до второго числа = {sum}");
      return;
   }
   sum = sum + (num2--);
   GapNumberSum(num, num2, sum);
}

GapNumberSum(num, num2, 0);
