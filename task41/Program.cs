// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

void FillArray(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"Введите {arg.Length - i} число: ");
        arg[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Positive(int[] arg)
{
    int pos = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] > 0) pos++;
    }
    return pos;
}
Console.Write($"Введите  количество цифр: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

FillArray(array);

Console.WriteLine(Positive(array));

