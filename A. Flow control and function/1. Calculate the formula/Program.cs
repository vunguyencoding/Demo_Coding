
int n;
Console.Write("Enter an integer value for n: ");// Nhập giá trị số nguyên dương cho n

while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)// Lặp cho đến khi người dùng nhập đúng số nguyên dương
{
    Console.WriteLine("Please enter a positive integer:"); // Thông báo nhập lại nếu giá trị không hợp lệ
}

//============================================= Caculate the formula S1 ========================================================
double CalculateS1(int n) // Gọi hàm tính toán S1 và in kết quả
{
    double S1 = 1.0;
    double sumOfSquares = 0.0;

    for (int i = 1; i <= n; i++)
    {

        sumOfSquares += Math.Pow(i, 2);

        S1 += Math.Pow(-1, i) / sumOfSquares;
    }

    return S1;
}


//============================================= Caculate the formula S2 =========================================================

double Factorial(int n) //hàm đệ quy tính giai thừa của một số nguyên n:
{
    if (n == 0)//Nếu n = 0, trả về 1, vì  0!= 1 theo định nghĩa.
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1); //Nếu n > 0, trả về n * Factorial(n - 1).Hàm tự gọi lại chính nó với giá trị n - 1
    }
}
double CalculateS2(int n)
{
    double S2 = 1.0;
    for (int i = 1; i <= n; i++)
    {
        S2 += Math.Pow(-2, i) / Factorial(i);//Math.Pow(-2, i), nghĩa là −2 lũy thừa với i.
        
    }
    return S2;
}


//============================================ Caculate the formula S5 ==========================================================


double CalculateS5(int n)
{
    double S5 = 0.0;
    for (int i = 1; i <= n; i++)
    {
        S5 += Math.Pow(-1, i + 1) * (1.0 / (2 * i));
    }
    return S5;
}
//=========================================== Caculate the formula S6 ===========================================================


double CalculateS6(int n)
{
    double S6 = 1.0;
    for (int i = 1; i <= n; i++)
    {
        double sum = 0.0;
        for (int j = 1; j <= i; j++)
        {
            sum += j;
        }
        S6 += Math.Pow(-1, i + 1) * (1.0 / sum);//Nếu i là số lẻ, i + 1 là số chẵn, Math.Pow(-1, i + 1) sẽ bằng 1 và ngược lại sẽ bằng -1.
                                                //1.0 / sum: Tính nghịch đảo của tổng sum
    }
    return S6;
}
//=========================================== Caculate the formula S7 ==========================================================
double Factorial2(int n)
{
    double result = 1.0;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
double CalculateS7(int n)
{
    double S7 = 1.0;
    for (int i = 1; i <= n; i++)
    {
        S7 += Math.Pow(2, i) / Factorial(i);
    }
    return S7;
}


double S1 = CalculateS1(n);
double S2 = CalculateS2(n);
double S5 = CalculateS5(n);
double S6 = CalculateS6(n);
double S7 = CalculateS7(n);

Console.WriteLine("The value of S1 = " + S1);
Console.WriteLine("The value of S2 = " + S2);
Console.WriteLine("The value of S5 = " + S5);
Console.WriteLine("The value of S6 = " + S6);
Console.WriteLine("The value of S7 = " + S7);