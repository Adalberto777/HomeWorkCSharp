Console.WriteLine("Enter an integer");
int number = int.Parse(Console.ReadLine());
int count = 2;
if(number < 2) Console.Write($"в {number} нет четных чисел");
while(count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;
}

 
