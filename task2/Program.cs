Console.WriteLine("Программа для сравнения трех чисел");

Console.WriteLine("Enter a first integer");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a second integer");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a thid integer");
int number3 = int.Parse(Console.ReadLine());
int max = number1;

if(max < number2)  max = number2;
if(max < number3)  max = number3;

Console.Write($"из трех чисел {number1}, {number2} и {number3} большее {max}");