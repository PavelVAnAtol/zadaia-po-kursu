//Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.
void PrintEvenNumbers(int number)
{
    int i = 1;
    while (i <= number)
    {
        if (i % 2 == 0)
        {
            Console.Write($" {i }" );
        }
        i++;
    }
}
Console.WriteLine(" Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
PrintEvenNumbers(number);