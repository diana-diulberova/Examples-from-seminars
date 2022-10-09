﻿/*Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int a, int userNumber)
{
    if(a < userNumber)
    { 
        return $"{a} " + NumbersRec(a + 1, userNumber);
    }
    else
    { 
        return $"{userNumber} ";
    }
}

Console.WriteLine(NumbersRec(1, userNumber));