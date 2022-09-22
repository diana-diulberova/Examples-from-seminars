/*
: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
тоже самое что с суммой, только умножение
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int GetComNums(int number)
{
    int com = 1;
    int i = 1;
    while(i <= number)
    {
        com = com*i;
        Console.Write($"{i}");
        i++;
    }
    return com;
}

Console.WriteLine($" Произведение чисел от 1 до {userNumber} = {GetComNums(userNumber)}");