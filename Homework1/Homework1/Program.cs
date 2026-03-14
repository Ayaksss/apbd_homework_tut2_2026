// See https://aka.ms/new-console-template for more information

static double CalculateAverage(int[] values)
{
    return values.Sum() / values.Length;
}

int[] numbers = {1, 2, 3, 4, 5};

Console.WriteLine(CalculateAverage(numbers));

static double CalculateMax(int[] values)
{
    Console.WriteLine("(feature-conflict second try) Max is: " + values.Max());
    return values.Max();
}

public static int CalculateMin(int[] values) 
{
    Console.WriteLine("Min is: " + values.Min());
    return values.Min(); 
}