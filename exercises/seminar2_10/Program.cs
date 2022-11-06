//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindMiddleDigit (int InputDigit)
{
return (InputDigit / 10) % 10;
}
Console.WriteLine("Input three-digit number: ");
int threedigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"middle digit of {threedigit} is {FindMiddleDigit(threedigit)} ");