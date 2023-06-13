// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа 
// от 1 до N.
Console.WriteLine ("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= number - 2)
{
    current = current + 1;
    if (current%2 == 0)
{
    Console.Write(current + ", ");
}
}
