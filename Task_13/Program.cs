Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 100) >= 1)
{
    int buffer = number;
    
    while ((buffer / 100) >= 10)
    {
        buffer /= 10;
    }

    int result = buffer % 10;
    Console.WriteLine($"Третья цифра в числе {number} это: {result}.");
}
else
{
    Console.WriteLine($"В числе {number} меньше трех символов.");
}