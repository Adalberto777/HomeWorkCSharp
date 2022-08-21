Console.WriteLine("Программа для определения четности числа");

Console.WriteLine("Enter an integer");
int number1 = int.Parse(Console.ReadLine());

if(number1 % 2 ==0) Console.Write($" {number1} - четное число");
else Console.Write($" {number1} - не четное число");