/*

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3



int [] RandomArray ()
{
    Console.WriteLine("input count of numbers");
    int m = Convert.ToInt32(Console.ReadLine());
    int size = m;
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-100, 101);
    }
    return randomArray;

}

void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

void Count (int [] countArray)
{
    int count = 0;
    for (int i = 0; i < countArray.Length; i++)
    {
        if (countArray[i] > 0)
            count++;
    }
    Console.WriteLine(count);
}

int [] randomArray = RandomArray();
PrintArray(randomArray);
Count(randomArray);


Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
x = (b2 - b1)/(k1 - k2)

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

void point()
{
    Console.WriteLine("input b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input k2");
    double k2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"({(b2 - b1) / (k1 - k2)}; {k1 * ((b2 - b1) / (k1 - k2)) + b1})");

}

point();
