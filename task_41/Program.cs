// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter the required number of numbers");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int countPositivNumber = 0;
for (int i = 0; i < number; i++)
{
    Console.WriteLine("Enter the next number");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) countPositivNumber++;
}
Console.WriteLine($"number of positive numbers: {countPositivNumber}");