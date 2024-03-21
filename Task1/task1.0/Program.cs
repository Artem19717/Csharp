Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    System.Console.WriteLine("a = " + num1 +", b = " + num2 + "=> да");
}
else
{
    System.Console.WriteLine($"a = {num1}, b = {num2} => нет");
}

