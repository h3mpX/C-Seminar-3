//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

void Cubs(int n)
{
    int cur = 1;
    if (cur <= n)
    {
        while (cur <= n)
        {
            Console.Write(Math.Pow(cur, 3) + " ");
            cur++;
        }
    }
    else
    {
        while (cur >= n)
        {
            Console.Write(Math.Pow(cur, 3) + " ");
            cur--;
        }
    }
}

    Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Список кубов от 1 до {n}:");
    Cubs(n);
    
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве


/*


double Cord(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double x = x1 - x2;
    double y = y1 - x2;
    double z = z1 - z2;
    return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
}

Console.WriteLine("Введите Х:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Z2:");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Точка А: {x1}, {y1}, {z1}. Точка Б: {x2}, {y2}, {z2}. Расстояние между точками: {Cord(x1, y1, z1, x2, y2, z2)}");


*/

bool Palindrome(int number)
{
    int mirror = 0;
    int number1 = number;

    while (number > 0)
    {
        mirror = mirror * 10 + number % 10;
        number /= 10;
    }
    if (mirror == number1)
    {
        return true;
    }

    else
    {
        return false;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Palindrome(number)) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");




