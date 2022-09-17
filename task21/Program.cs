/*
Задача 21: Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними 
в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координату x первой точки: ");
int userX1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y первой точки: ");
int userY1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки: ");
int userX2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y второй точки: ");
int userY2 = Convert.ToInt32(Console.ReadLine());

double segment = Math.Sqrt((userY2-userY1)*(userY2-userY1)+(userX2-userX1)*(userX2-userX1));
segment = Math.Round(segment, 3);
Console.WriteLine($"Расстояние между точками равно: {segment}");