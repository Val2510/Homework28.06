//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[num];

void Arr(int number)
{
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Pos(int[] Array)
{
    int index = 0;
    int sum = 0;
    while (index < Array.Length)
    {
        if (Array[index] > 0)
            sum = sum + 1;
        index++;
    }
    return sum;
}

Arr(num);
Console.Write($"Положительных чисел: {Pos(Array)}");
*/



//Задача 43: Напишите программу, 
//которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}
double b1 = InputNum("Введите b1: ");
double k1 = InputNum("Введите k1: ");
double b2 = InputNum("Введите b2: ");
double k2 = InputNum("Введите k2: ");

string Intersection(double num1, double num2, double num3, double num4)
{
    double x;
    double y;
    if ((k1 == k2) && (b1 == b2)) return "Прямые совпадают";
    else if (k1 == k2) return "Прямые параллельные";
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    }
    return $"Координаты пересечения прямых: x={x}, y={y}";
}

string res = Intersection(b1,b2,k1,k2);
Console.WriteLine(res);