// Написать программу которое из случайного числа от 10 до 99) показывает наибольщую цифру в этом числе

/*
int Ch(int num)
{
    int firstD = num % 10;
    int secondD = num / 10;
    if (firstD > secondD)
        Console.WriteLine($"наибольшая цифра числа {num} - {firstD}");
    else
        Console.WriteLine($"наибольшая цифра числа {num} - {secondD}");
    return num;
}
int randNum = new Random().Next(10, 100);
int Digit = Ch(randNum);
// Написать программу которая принимает на вход число и проверяет кратно ли оно одновременно А и Б


int kratno(int N)
{
    Console.Write("Введите число A:");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число B:");
    int b = Convert.ToInt32(Console.ReadLine());
    
    if (N % a == 0 && N % b == 0)
    Console.WriteLine($"Число {N} кратно числам {a} и {b}");
    else 
    Console.WriteLine($"Число {N} НЕ кратно числам {a} и {b}!!");
    return N;
}

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int kr = kratno(num);

*/


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. Bool

bool kvadrat(int a, int b)
{
    if (a * a == b || b * b == a)
        return true;
    else
        return false;
}

Console.Write("Введите число: a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: b = ");
int b = Convert.ToInt32(Console.ReadLine());

bool result = kvadrat(a, b);
Console.WriteLine(($"Являяется ли одно из чисел квадратом другого? = {result}"));






