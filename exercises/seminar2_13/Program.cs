// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int FindThirdDigit (int InputDigit)
{
    int capacity;
    capacity = Convert.ToInt32(Math.Truncate(Math.Log (InputDigit, 10))+1);
    if (capacity >= 3)
    {
        return  InputDigit / Convert.ToInt32(Math.Pow(10, capacity-3) ) % 10;
    }
else
{
    return -1;
}   
}

Console.WriteLine("Input number: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 100)
{
Console.WriteLine($"{digit} have not third digit ");
}
else
{
Console.WriteLine($"third digit of {digit} is {FindThirdDigit(digit)} ");
}