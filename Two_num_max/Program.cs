//Задача о выдаче максимального числа из двух
Console.Clear();
Console.Write("a = "); 
int numberA = int.Parse(Console.ReadLine());
Console.Write("b = ");
int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}

else
{
    Console.WriteLine($"max = {numberB}");
}
