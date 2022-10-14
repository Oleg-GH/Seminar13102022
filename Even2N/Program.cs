// Задача выдачи всех четных чисел от 1 до N по введенному N 
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = 2;

Console.Write($"{number} -> ");

while(result < (number + 1))
{
    if(result < (number - 1))
    {
        Console.Write($"{result}, ");
        result = result + 2;
    }
    else 
    {
        Console.WriteLine($"{result} ");
        result = result + 2;
    }
}
