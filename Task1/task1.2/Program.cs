System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    System.Console.WriteLine("Число трехзначное! ");

    int left = num / 100;
    int rig = num % 10;
    int sum = left + rig;
    System.Console.WriteLine(num + " => " + sum);
}
else
{
    System.Console.WriteLine("число не трехзначное");
}