// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2");
double k2 = Convert.ToDouble(Console.ReadLine());
if (k1 != k2 && k1 != 0)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"the x coordinate of the intersection point of the lines {x}");
    Console.WriteLine($"the y coordinate of the intersection point of the lines {y}");
}
else Console.WriteLine("straight lines don't intersect");


