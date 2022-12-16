Console.Write("Введите натуральное число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int RecSumExpo(int num1, int num2)
{
    if (num2 == 0) return 1;
    return RecSumExpo(num1, num2 - 1) * num1;
}

Console.WriteLine($"{RecSumExpo(numA,numB)}");