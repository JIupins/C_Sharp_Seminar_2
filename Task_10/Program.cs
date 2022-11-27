Console.Clear();

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 100) >= 1 & (number / 100) < 10)
{
    int result = (number / 10) % 10;
    Console.WriteLine ($"Вторая цифра в трехзначном числе {number} это: {result}.");
}
else
{
    Console.WriteLine ($"Введеное число {number} не является трехзначным.");
}