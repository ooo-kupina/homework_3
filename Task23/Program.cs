// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;
if (number > 0)
{
    while (i <= number)
    {
        int cube = i * i * i;
        Console.WriteLine($"{i}    {cube}");
        i++;
    }
}
else
    Console.WriteLine("Некорректный ввод данных. Повторите ввод.");

