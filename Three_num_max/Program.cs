//Задача о выдаче максимального числа из трёх
Console.Clear();
Console.WriteLine("Введите три числа и получите максимальное: ");
int numberA = int.Parse(Console.ReadLine()); 
int numberB = int.Parse(Console.ReadLine()); 
int numberC = int.Parse(Console.ReadLine()); 

int max = numberA;

if(numberB > max)
{
    max = numberB;
}
else
{
    if(numberC > max)

    {
        max = numberC;
    }
}

Console.WriteLine($"{numberA}, {numberB}, {numberC} -> {max}");