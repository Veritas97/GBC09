Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());

int SumNatural(int num1, int num2)
{
    if (num1 == num2) return num2;
    return num2 + SumNatural(num1, num2 -1);
}

Console.Write($"{SumNatural(numN,numM)}");