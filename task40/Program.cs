/* Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины
*/

Console.WriteLine("Введите длину первой стороны треугольника: ");
int firstSide = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину второй стороны треугольника: ");
int secondSide = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину третьей стороны треугольника: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

if(firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)
{
    Console.WriteLine($"Треугольник со сторонами {firstSide}, {secondSide}, {thirdSide} существует");
}
else
{
     Console.WriteLine($"Треугольника со сторонами {firstSide}, {secondSide}, {thirdSide} НЕ существует");
}