// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Для решения задания использование цикла for является обязательным условием
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int summa)
{
   string NewSum = Math.Abs(summa).ToString();
   int [] array = new int[NewSum.Length];

    int sum = 0;
     for (int i = 0; i < NewSum.Length; i++)
     {
        array[i] = int.Parse(NewSum[i].ToString());
        sum = sum + array[i];
     }
     return sum;
}

Console.WriteLine("Введите число: ");
int summa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе: {GetSum(summa)}");