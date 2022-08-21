Console.WriteLine("Программа вывода положительных четных чисел");

Console.WriteLine("Enter a positive integer");
int number = int.Parse(Console.ReadLine());
int count = 2;

if(number < 2) Console.Write($" {number} - не содержит положительных целых чисел");

while(count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;
}