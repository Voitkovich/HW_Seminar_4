// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Заполнение массива производит пользователь.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

Console.WriteLine(array.Length);

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под номером {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
 
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
} 