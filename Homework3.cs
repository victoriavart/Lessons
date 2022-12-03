// See https://aka.ms/new-console-template for more information
/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да
*/







/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

double result = GetDistanceBetweenPoints(x1, x2, y1, y2, z1, z2);
Console.WriteLine(result);

double GetDistanceBetweenPoints(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 3) + Math.Pow(y2 - y1, 3) + Math.Pow(z2 - z1, 3)), 3);
}
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int num = InputInt();
int[] CubesTable = GetCubesTable (num);
PrintArray(CubesTable);

int InputInt ()

{
    Console.WriteLine("Введите целое число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum) 
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}



int[] GetCubesTable (int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = (int)((Math.Pow(i+1,3)));
    }
    return arr;
}




void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
