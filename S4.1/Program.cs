
// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

/*
void MetFindSum (int a)
{
    int sum = 0;
    for (int current = 1; current <= a; current++)
    {
        sum += current;
    }
    Console.WriteLine($"Summ of elements from 1to {a} is {sum}") ;
}

Console.WriteLine ("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine()) ;

if (user_num >= 1)
{
    MetFindSum(user_num);
}
else
    Console.WriteLine("Impossible val");
    */

// Напишите программу, которая принимает на вход число и вадает количество цифр в числе.

/*
int CountofDigits (int number)
{
    int countDigits = 1;
    while(number>=10)
    {
        number = number/10;
        countDigits ++  ;
    }   
    return(countDigits);  
}    
Console.WriteLine ("Input your num: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int count;
if (user_num >= 0)
{
    count = CountofDigits(user_num);
}
else
{
    int num = (-1)*user_num;
    count = CountofDigits(num);
}

Console.WriteLine(count);
*/

//  Создание метода, который возвращает массив:

int [] CreatNewArray (int size, int min, int max)
{
    int [] array = new int [size] ;
    for (int i = 0; i < size; i ++)
        array[i] = new Random().Next(min, max + 1) ;
    return(array);
}

void ShowArray (int [] array)
{
    for (int i = 0 ; i < array.Length ; i ++)
        Console.Write(array[i] + " ");
}

Console.WriteLine ("Enter count of elements: ");
int countOfElem = Convert.ToInt32(Console.ReadLine());
int minVal = 0 ;
int maxVal = 1 ;

int [] array1 = CreatNewArray (countOfElem, minVal, maxVal);
ShowArray(array1);

