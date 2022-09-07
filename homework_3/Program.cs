/* Задача 1.    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14232 -> нет    /   12821 -> да    /    23432 -> да 
// Вариант 1
void Palindrome (int num_1)
{
    int a = num_1 / 10000; // 1 Первая цифра
    int b = num_1 % 10; // 2 Пятая цифра
    int c = num_1 / 1000 % 10; // 4 Вторая цифра
    int d = num_1 % 100 / 10; // 3 Чертвертая цифра

    if (a == b && c == d )
    {
        Console.Write($"Это число является палиндромом");
    }
    else Console.Write($"Это число не является палиндромом");
}

Console.Write("Введите пятизначное число и нажмите Enter: ");
int palindrome_number = Convert.ToInt32(Console.ReadLine());
Palindrome(palindrome_number);

// Вариант 2

void Palindrome(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number!.Length == 5)
{
    Palindrome(number);
}
else Console.WriteLine($"Введите правильное число");
*/




/* Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
*/




/* Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27   /   5 -> 1, 8, 27, 64, 125 

void Сube(int num_1)
{
    int count = 1;
    while (count <= num_1)
    {
        Console.WriteLine($"Куб числа {count} равен : {count * count * count}");
        count ++;
    }
}

Console.Write("Введите число, которое хотите возвести в куб: ");
int number = Convert.ToInt32(Console.ReadLine());
Сube(number);
*/