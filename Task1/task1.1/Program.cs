System.Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());

int i = -N;
while (i <= N)
{
    System.Console.Write(i + " ");
    i++;
}
