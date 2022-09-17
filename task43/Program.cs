// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Программа по формеле y = k1 * x + b1 и y = k2 * x + b2 ");
Console.WriteLine("Для нахождения пересечения");

double[] k = new double[2];
double[] b = new double[2];

for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите отрезки k{1 + i}: ");
    k[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите отрезки b{1 + i}: ");
    b[i] = Convert.ToInt32(Console.ReadLine());
}
double x = (b[0] - b[1]) / (k[1] - k[0]);                 // формула x = (b1-b2)/(k2-k1)
double y = (k[1] * b[0] - k[0] * b[1]) / (k[1] - k[0]);   //         y = (k2*b1-k1*b2)/(k2-k1)

Console.WriteLine($"X = {x}");
Console.WriteLine($"Y = {y}");

