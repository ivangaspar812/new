/*
69. Напишите программу, которая на вход принимапт два числа 
А и В, и возводит число А в целую степень В с помощью рекурсии.
*/

Console.Clear();

int Step(int digit, int square)
{
    if (square == 1)
    {
        return digit;
    }
    else
    {
        return digit * Step(digit, square-1);
    }
}

int result = Step(3, 2);
System.Console.WriteLine(result);