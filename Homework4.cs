//Задача 25: Напишите программу, которая принимает на вход два числа
//(A и B) и метод который возводит число A в натуральную степень B.


/*
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int a_b=1;
for (int i = 0; i < b; i++)
{
    a_b*=a;
}
Console.WriteLine("{0} ^ {1} = {2}", a, b, a_b);
return 0;
*/

/*Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*int n = int.Parse(Console.ReadLine());
int sum = 0;

while (n != 0)
{
    sum = sum + n % 10;
    n = n / 10;
}
Console.WriteLine(sum);
*/

/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*Random rnd = new Random();
bool isInt = int.TryParse(Console.ReadLine(), out int num);

if (!isInt)
{
    Console.Write("Числое введено неверно");
}
else
{
    int userLength = num;

int[] userArray = ArrayFilling(userLength);
PrintArr(userArray);

int[] ArrayFilling(int userLength)
{
    int[] arr = new int[userLength];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 99);
    
    }
    return arr;
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
}
*/