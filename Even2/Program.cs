// Задача определения четности числа 
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number%2 == 0)
{
    Console.WriteLine($"{number} -> Да");
}
else
{
    Console.WriteLine($"{number} -> Нет");
}
