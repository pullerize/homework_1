/*
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7   /   a = 2 b = 10 -> max = 10  /   a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
    Console.Write("Число " + number_1 + " больше числа " + number_2 );
}
else 
{
    Console.Write("Число " + number_1 + " меньше числа " + number_2 );
}
*/



/*
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7   /   44 5 78 -> 78   /   22 3 9 -> 22

Console.Write("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_3 = Convert.ToInt32(Console.ReadLine());
int max = number_1;

if (max < number_2)
{
    max = number_2;
}

if (max < number_3)
{
    max = number_3;
}

Console.WriteLine("Максимальное число " + max);
*/


/*
// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да  /   -3 -> нет   /   7 -> нет

Console.Write("Введите число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());


if (number_1 % 2 == 0)
{
    Console.Write("Это число является четным");
}
else
{    
    Console.Write("Это число является Не четным");
}
*/



//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4   /   8 -> 2, 4, 6, 8   

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int current = 1;current <= number; current++)       
    if ( current % 2 == 0) 
    {           
        Console.WriteLine(current);
    }
    