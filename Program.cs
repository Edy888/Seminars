// Напишите программу которая принимает на вход точки (X и y), причем x != 0 и y != 0 и выдает номер четверти плоскости, в которой находится эта точка.

void Koords (int x, int y) // x = xCoord, y = yCoord
{
    if(x > 0 && y > 0)
    
        Console.WriteLine ("This point on 1st quarter");
    else if (x < 0 && y > 0)
        Console.WriteLine ("This point on 2st quarter");
    else if (x < 0 && y < 0)
        Console.WriteLine ("This point on 3st quarter");
    else
        Console.WriteLine ("This point on 4st quarter");
}

// блок ввода данных

Console.WriteLine ("Enter your X coordinat: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter your Y coordinat: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

// проверка ограничений из условий задачи

if (xCoord == 0 || yCoord == 0)
    Console.WriteLine ("Its impjs");
else
    Koords(xCoord,yCoord);


// НП, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти

void PossibleValue (int num)
{
    if (num == 1)
        Console.WriteLine("1ST QUATER X > 0, Y > 0");
    else if (num == 2)
        Console.WriteLine("2nd QUATER X < 0, Y > 0");
    else if (num == 3)
        Console.WriteLine("3nd QUATER X < 0, Y < 0");
    else
        Console.WriteLine("4nd QUATER X > 0, Y < 0");
}

Console.WriteLine ("Input number of quater: ");
int numQuater = Convert.ToInt32(Console.ReadLine());

if (numQuater >= 1 && numQuater <= 4)
    PossibleValue(numQuater);
else Console.WriteLine("Its not number of quater! ");
