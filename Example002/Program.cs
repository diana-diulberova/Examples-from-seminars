/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого. a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет
*/
int userNumber = new int();
Console.WriteLine("Введите число: ");
userNumber = Convert.ToInt32(Console.ReadLine());

int userSquare = new int();
Console.WriteLine("Введите возможный квадрат числа: ");
userSquare = Convert.ToInt32(Console.ReadLine());

int result = (userNumber * userNumber);

if (userSquare == result)
{
    Console.WriteLine($"Да, квадрат числа {userNumber} = {result} ");
}

else
{
    Console.WriteLine($"Нет, {userSquare} не квадрат числа {userNumber} ");
}