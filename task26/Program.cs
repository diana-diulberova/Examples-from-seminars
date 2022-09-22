/*
Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
Нужно запустить цикл со счетчиком, который будет делить на 10 
пока число не будет меньше 9
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int num = userNumber;
int i = 1;

while(num > 9)
{
    num = num/10;
    i++;
}

Console.WriteLine($"В числе {userNumber} {i} цифр.: ");

/*Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num} имеет {num.ToString().Length} цифр(ы)");
*/