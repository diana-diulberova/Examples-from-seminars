/*Задача 22 Дополнительная: По данному натуральному числу n
найдите сумму чисел 1+1/1!+1/2!+1/3!+...+1/n!.
Количество должно быть пропорционально n.
Напишите программу, которая считывает значение n и выводит результат
в виде действительного числа.
*/

Console.WriteLine("Введите число N: ");
int nNumber = Convert.ToInt32(Console.ReadLine());
double f = 1;
double cNum = 1;

for (int i = 1; i <= nNumber; i++)
{
    f = f*i;
    cNum = cNum + (1 / f);
}
Console.WriteLine($"{Math.Round(cNum, 5)}");