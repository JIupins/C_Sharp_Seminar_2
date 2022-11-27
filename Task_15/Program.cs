Console.Clear();

Console.Write("Введите день недели (в виде числа от 1 до 7): ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 & day <= 7)
{
    if (day == 6 | day == 7)
    {
        Console.WriteLine($"{day}-й день недели это выходной день!");
    }

    else
    {
        Console.WriteLine($"{day}-й день недели не является выходным днем!");
    }
}

else
{
    Console.WriteLine($"Введеное число {day} не может являеться днем недели!");
}