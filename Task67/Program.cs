Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int SumDig(int num)
{
    if (num != 0)
    {
        return num % 10 + SumDig(num / 10);
    }
    return 0;
}

Console.WriteLine($"{SumDig(numN)}");