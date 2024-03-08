//Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
static void CheckIfEven( int number)
{
    if (number % 2==0)
    {
        Console.WriteLine(" Четное ");
    }
    else
    {
        Console.WriteLine(" Нечетное ");
    }
}
 Console.WriteLine(" Введите число");
 int number= Convert.ToInt32(Console.ReadLine());
 CheckIfEven(number);