// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int checkNum (int num)
{
    int res1 = num / 10;
    int res = res1 % 10;
    return res;
}

Console.Write("Input the integer number from 100 to 999: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = checkNum (num);

Console.WriteLine($"The second number of number {num} is {res}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void threeDigitNum (int num)
{
    string str = num.ToString();
    
    if (str.Length<3)
        Console.WriteLine($"The number {num} dont have the third digit");
    else  
        Console.WriteLine($"The third digit of the {num} is {str[2]}");
 }

Console.Write("Input the integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

threeDigitNum (num);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool weekDay(int num)
{
    if (num < 6)
    return false;
    else 
    return true;
}

Console.Write("Input the integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = weekDay (num);

if ((num<1)|(num>7))

Console.WriteLine("This is not a day of week");

else 
    if (res)
    Console.WriteLine("This is a weekend!");
    else 
    Console.WriteLine("This is not a weekend");

*/




