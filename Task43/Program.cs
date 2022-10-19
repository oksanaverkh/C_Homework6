// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = GetNumbers();
double k1 = GetNumbers();
double b2 = GetNumbers();
double k2 = GetNumbers();

Console.WriteLine($"y = {k1}*x + {b1}");
Console.WriteLine($"y = {k2}*x + {b2}");
Console.WriteLine();
FindIntersectionPoint();

double GetNumbers()
{
    Console.WriteLine($"Enter a number: ");
    double number = double.Parse(Console.ReadLine());
    return number;
}

void FindIntersectionPoint()
{
    double x = 0;
    double y = 0;
    x = (b2 - b1)/(k1-k2);
    y = k1 * x + b1;
    if ((k1-k2) == 0) Console.WriteLine("ERROR!");
    else Console.WriteLine($"Intersection point is ({Math.Round(x,2)}; {Math.Round(y,2)})");
}


