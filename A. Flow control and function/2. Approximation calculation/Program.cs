

int n;
Console.Write("Enter an integer n: ");// Nhập giá trị số nguyên dương cho n

while (!int.TryParse(Console.ReadLine(), out n) || n < 0)// Lặp cho đến khi người dùng nhập đúng số nguyên dương
{
    Console.WriteLine("Please enter a non-negative integer:"); // Thông báo nhập lại nếu giá trị không hợp lệ
}

Console.Write("Enter the desired accuracy (epsilon): ");
double epsilon;

while (!double.TryParse(Console.ReadLine(), out epsilon) || epsilon <= 0)
{
    Console.Write("Invalid input. Please enter a positive number for epsilon: ");
}

//=========================================== ApproximatePi ===========================
double ApproximatePi(double epsilon)
{
    double term = 1.0;
    double sum = 0.0;
    int n = 0;

    while (Math.Abs(term) > epsilon)
    {
        sum += term;
        n++;
        term = Math.Pow(-1, n) / (2 * n + 1);
    }

    return sum * 4;
}
//======================================== ApproximateSin ==================================
double Factorial(int n)
{
    double result = 1.0;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
double ApproximateSin(double x, double epsilon)
{
    double term = x;
    double sum = 0.0;
    int i = 1;

    while (Math.Abs(term) > epsilon)
    {
        sum += term;
        i++;
        term = Math.Pow(-1, i - 1) * Math.Pow(x, 2 * i - 1) / Factorial (2 * i - 1);
    }

    return sum;
}



Console.WriteLine("Approximations with epsilon = " + epsilon);
Console.WriteLine("Pi: " + ApproximatePi(epsilon));
Console.WriteLine("sin(n): " + ApproximateSin(n, epsilon));