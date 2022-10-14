//Задача о выдаче максимального числа из двух
Console.Clear();
Console.WriteLine("Введите два числа: "); 
int numberA = int.Parse(Console.ReadLine()); 
int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine($"a = {numberA}, b = {numberB}, -> max = {numberA}");
}

else
{
    Console.WriteLine($"a = {numberA}, b = {numberB}, -> max = {numberB}");
}
