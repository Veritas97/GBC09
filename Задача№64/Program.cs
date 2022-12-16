Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

void NaturalNum(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNum(num - 1);
}

NaturalNum(numN);