/*
Задача 18: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек 
в этой четверти (x и y).
*/

Console.WriteLine("Введите номер четверти");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber == 1)
{
    Console.WriteLine("Диапазон значений x (0, +бесконечность), а y (0, +бесконечность)");
}

else if(userNumber == 2)
{
    Console.WriteLine("Диапазон значений x (0, +бесконечность), а y (0, -бесконечность)");
}

else if(userNumber == 3)
{
    Console.WriteLine("Диапазон значений x (0, -бесконечность), а y (0, -бесконечность)");
}

else if(userNumber == 4)
{
    Console.WriteLine("Диапазон значений x (0, -бесконечность), а y (0, +бесконечность)");
}

else
{
    Console.WriteLine("Такой четверти не существует");
}