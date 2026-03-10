// See https://aka.ms/new-console-template for more information

static double CalculateAverage(int[] values)
{
    return values.Sum() / values.Length;
}

int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};

Console.WriteLine(CalculateAverage(numbers));
