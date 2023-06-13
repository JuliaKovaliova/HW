// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine ("input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxNumb = 0;
if (number1 > number2)
{
    maxNumb = number1;
}
else
{
    maxNumb = number2;
}
if (maxNumb < number3)
{
    maxNumb = number3;
}
Console.Write($"Max number: {maxNumb}");