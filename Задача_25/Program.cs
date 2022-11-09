// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// Для решения задания использование цикла for является обязательным условием. 
// Не использовать встроенный метод возведения в степень.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetDegree(int num, int degree)
{
    int Degree = 0;

    for  (int i = 0; i < degree; i++)
    {
        Degree = num * degree;
    }
    return Degree;
}




Console.WriteLine("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Первое число возведено в натуральную степень второго числа, результат равен: " 
+ GetDegree(num, degree));
