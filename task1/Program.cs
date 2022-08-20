Console.WriteLine("Enter a first integer");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a second integer");
int number2 = int.Parse(Console.ReadLine());
int max = 0;

if(number1 > number2)  max = number1;
if(number1 < number2)  max = number2;

Console.Write($"из двух чисел {number1} и {number2} большее {max}");