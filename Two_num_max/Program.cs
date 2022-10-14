//Задача о выдаче максимального числа из двух
Console.Clear();
Console.Write("Введите первое число: "); 
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}

else
{
    Console.WriteLine($"max = {numberB}");
}
