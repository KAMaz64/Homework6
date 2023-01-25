/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

Console.Clear();

Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());


double[] GetIntersectionPoint(double b01, double k01, double b02, double k02)
{
    double[] point = new double[2];
    point[0] = (b02 - b01)/(k01 - k02);
    point[0] = Math.Round(point[0], 4);
    point[1] = k01*point[0] + b01;
    point[1] = Math.Round(point[1], 4);
    return point;
}

Console.WriteLine($"Прямые пересекаются в точке: ({String.Join("; ", (GetIntersectionPoint(b1, k1, b2, k2)))})");