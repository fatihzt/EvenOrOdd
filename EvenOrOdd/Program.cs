using System;
Console.WriteLine("EvenOrOdd Check Program");

Console.Write("Please enter an integer:");
var value1 = Console.ReadLine();

if (string.IsNullOrEmpty(value1))
{
    Console.WriteLine("Please!! enter an integer.");
    return;
}

if(int.TryParse(value1, out int x))
{
    Console.WriteLine(" ");
}
else
{
    Console.WriteLine("its not integer");
    return;
}

int number1 = Convert.ToInt32(value1);
if (number1 % 2 == 0)
{
    Console.WriteLine(" is Even Numeber");
}
else if (number1 == 0)
{
    Console.WriteLine(" is Even Number.");
}
else
{
    Console.WriteLine(" is Odd Number.");
}