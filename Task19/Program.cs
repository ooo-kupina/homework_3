// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int temp = number; //Объявляем временную переменную со значением исходного числа
int antinumber = 0; //Число перевернутое

while (temp != 0)
{
    antinumber = antinumber * 10 + temp % 10; //Переворачиваем число по цифрам
    temp /= 10; //Отбрасываем последнюю цифру
}

if (number == antinumber)
{
    Console.WriteLine("Данное число - палиндром");
}
else
    Console.WriteLine("Данное число - НЕ палиндром");

return 0;

