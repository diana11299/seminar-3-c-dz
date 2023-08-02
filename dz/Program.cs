//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*

void WriteCube(int num)
{
    int current = 1;
    while(current <= num) 
    {
        //Console.WriteLine($"{current} - {current * current * current}");
        Console.WriteLine($"{current} - {Math.Pow(current , 3)}");
        current++;
    }

}
Console.Write("Imput a num: ");
int num = Convert.ToInt32(Console.ReadLine());

WriteCube(num);
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*

double Distrance (double x1, double y1,double z1, double x2, double y2, double z2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    double deltaZ = z2 - z1;
    return Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ ) , 2);
}

Console.Write("Imput x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Imput z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Distrance (x1, y1, z1, x2, y2, z2));
*/

//Задача 19
//Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

/*попытка через массив
int [] arr = {};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
    Console.WriteLine($"{array[i]}");
    }
}

void Palindromtest(int [] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        int Position1 = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] == array[Position1]);
            return;
        }

    }
}

PrintArray(arr);
*/

bool Palindromtest(int number)
{
    string str = number.ToString();

    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
         {
             return false;
         }
    }
    return true;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (Palindromtest(number))
Console.WriteLine("Введенное число является палиндромом.");
else
Console.WriteLine("Введенное число не является палиндромом.");


