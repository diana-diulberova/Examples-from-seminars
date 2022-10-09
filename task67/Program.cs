﻿/*Задача 67: Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SumRec(int userNumber)
{
    if(userNumber == 0) return 0;
    else return userNumber % 10 + SumRec(userNumber / 10);
}

Console.WriteLine(SumRec(userNumber));