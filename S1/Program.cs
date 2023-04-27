/*
_________________________________________________________________________________________________________________
 НП, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти

void PossibleValue (int num)
{
    if (num == 1)
        Console.WriteLine(1ST QUATER X  0, Y  0);
    else if (num == 2)
        Console.WriteLine(2nd QUATER X  0, Y  0);
    else if (num == 3)
        Console.WriteLine(3nd QUATER X  0, Y  0);
    else
        Console.WriteLine(4nd QUATER X  0, Y  0);
}

Console.WriteLine (Input number of quater );
int numQuater = Convert.ToInt32(Console.ReadLine());

if (numQuater = 1 && numQuater = 4)
    PossibleValue(numQuater);
else Console.WriteLine(Its not number of quater! );

 НП, которая принимает координаты 2х точек и находит расстояние между ними в 2D пространстве
 A(x1, y1)
 B(x2,y2)
 Math.Sqrt() - извлечение квадратного корня

 _________________________________________
(x1 - x2)(x1 - x2) + (y1 - y2)(y1 - y2) 3-я координата при 3D пространстве


______________________________________________________________________________________________________

double LongLine (int x1, int x2, int y1, int y2)
{
    double lengthAB = Math.Sqrt((x1 - x2)(x1 - x2) + (y1 - y2)(y1 - y2));
     double LenthAB1 = Math.Round (LengthAB, 2);
    return lengthAB;
}

Console.WriteLine (Input X cordinate of A );
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (Input Y cordinate of A );
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Input X cordinate of B );
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (Input Y cordinate of B );
int yCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xCoordA, xCoordB, yCoordA, yCoordB );

Console.WriteLine($Distance AB is {distf3});  выводим 3 знака после запятой


_______________________________________________________________________________________________________

 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 - 1, 4, 9, 16, 25.
2 - 1,4

 без аргумента

void SquarFinder ()
{
    Console.WriteLine( Input number );
    int numberN = Convert.ToInt32(Console.ReadLine());

    if(numberN  0)
    {
        int current_i = 1;
        while (current_i = numberN)
        {
            int res = current_icurrent_i;  Math.Pow(current_i,2);
            Console.Write(${resf0}, );
            current_i++;
        }
        Console.WriteLine(bb.); косметика
    }
    else отрицательные
    {
        int current_i = 1;
        while (current_i = numberN)
        {
            Console.Write(current_icurrent_i + , );
            current_i--;
        }
    }
}

SquarFinder();

с аргументами
*/