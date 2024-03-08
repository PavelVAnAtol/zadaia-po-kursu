//Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
static int FMax(int a, int b, int c)
{
    int max = a;
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    return max;

}
Console.WriteLine("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите третье  число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = FMax(a, b, c);
Console.WriteLine($" максимальное число {max} ");