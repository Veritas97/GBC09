Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

void NaturalNum(int num)
{
    if (num == 0) return;
    NaturalNum(num - 1);
    Console.Write($"{num} ");
}

NaturalNum(numN);