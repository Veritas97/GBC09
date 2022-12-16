Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());

void NaturalNum(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num2} ");
        NaturalNum(num1, num2 + 1);
    }
    
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNum(num1 + 1, num2);
    }
    
    if (num1 == num2)
    {
        Console.Write($"{num2} ");
    }
}

NaturalNum(numN, numM);