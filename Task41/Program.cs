/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4 */

Console.Clear();

Console.Write("Введите элементы(через пробел): ");
int[] newArray = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

Console.WriteLine($"Кол-во элементов > 0: {CountPositiveElements(newArray)}");

int CountPositiveElements (int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element > 0) count++;
    }
    return count;
}
 
