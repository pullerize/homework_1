/*  // Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5    /   782 -> 8    /   918 -> 1 

int Method_name(int number_1)
{
    int ed = number_1 % 100;
    int dec = number_1 / 100;

    int second_number = ed / 10;
    return second_number;
}

int rand_number = new Random().Next(100,1000);
int final_number = Method_name(rand_number);

Console.Write($"Вторым числом из числа- {rand_number}, является: {final_number}");
*/

/*  // Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5  /   78 -> третьей цифры нет /   32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string number_text = Convert.ToString(number);
if (number_text.Length > 2)
{
    Console.WriteLine("Третья цифра " + number_text[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
*/

/*  // Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да    /    7 -> да    /    1 -> нет

void Method_name(int days_number_1)
{
    if (days_number_1 == 6)
    {
        Console.Write("Да, этот день выходной");
    }
    else if (days_number_1 == 7)
    {
        Console.Write("Да, этот день выходной");
    }
    else if (days_number_1 > 7)
    {
        Console.Write("Этот день не является днем недели");
    }
    else
    {
        Console.Write("Этот день не является выходным");
    }
}

Console.Write("Введи цифру, обозначающую день недели: ");
int day_number_1 = Convert.ToInt32(Console.ReadLine());

Method_name (day_number_1);
*/