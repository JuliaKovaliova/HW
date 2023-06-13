// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine ("input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine ($"Max number: {number1}, Min number: {number2}");
}
else 
{
    Console.WriteLine ($"Max number: {number2}, Min number: {number1}");
}
