// See https://aka.ms/new-console-template for more information

static double CalculateAverage(int[] values)
{
    return values.Sum() / values.Length;
}

int[] numbers = {1, 2, 3, 4, 5};

Console.WriteLine(CalculateAverage(numbers));

static double CalculateMax(int[] values)
{
    return values.Sum() / values.Length;
}

public static int CalculateMin(int[] values) 
{
    return values.Min(); 
}