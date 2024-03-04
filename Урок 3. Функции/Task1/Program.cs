double CalculateFormula(int a, int b, int c, int d)
{
    int numenate = a * b;
    int denomenate = c + d;
    double result = numenate / denomenate;

    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);