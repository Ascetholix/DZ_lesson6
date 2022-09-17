// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Программа по формеле y = k1 * x + b1 и y = k2 * x + b2 ");
Console.WriteLine("Для нахождения пересечения");

int[] k = new int[2];
int[] b = new int[2];

for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите отрезки K{1 + i}: ");
    k[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите отрезки B{1 + i}: ");
    b[i] = Convert.ToInt32(Console.ReadLine());
}
double B = b[0] - b[1];
double K = k[1] - k[0];

Console.WriteLine($"{K}");
Console.WriteLine($"{B}");
Console.WriteLine($"{B/K}");
