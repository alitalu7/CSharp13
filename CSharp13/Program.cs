Console.WriteLine("Bir sayı giriniz...");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine(Fibo(i));
}

static int Fibo(int x)
{
    if (x == 0)
    {
        return 0;
    }
    else if (x == 1)
    {
        return 1;
    }
    return Fibo(x - 1) + Fibo(x - 2);
}


