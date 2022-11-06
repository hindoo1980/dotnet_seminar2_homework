// See https://aka.ms/new-console-template for more information

bool CheckWeekend (int InputDigit)
{
   
    if (InputDigit == 6 || InputDigit == 7)
    {
        return  true;
    }
    else
    {
        return  false;
    }   
}

Console.WriteLine("Input day of week from 1 to 7: ");
int dayofweek = Convert.ToInt32(Console.ReadLine());

if (CheckWeekend(dayofweek ))
{
Console.WriteLine($"{dayofweek} is a day off ");
}
else
{
Console.WriteLine($"{dayofweek} is not a day off ");
}
