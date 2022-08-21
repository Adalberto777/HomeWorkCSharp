Console.WriteLine("Программа вывода положительных четных чисел");

Console.WriteLine("Enter a positive integer");
int number = int.Parse(Console.ReadLine());
int count = 2;
if(number < 1) Console.Write($" {number} - не положительное целое число");

while(count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;
}