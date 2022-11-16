//zad 1
int i = 0;
while (i < 10)
{
    Console.WriteLine(Math.Pow(i, 3) + 3);
    i++;
}
Console.WriteLine();
Console.WriteLine();
//zad2
int a = 100;
while (a < 1000)
{
    if (a % 15 == 0)
    { Console.WriteLine(a); }
    a++;
}
Console.WriteLine();
Console.WriteLine();
//zad3
int x = int.Parse(Console.ReadLine());
int p = 1;
while (p < x + 1)
{
    if (x % p == 0)
    {
        Console.WriteLine(p);
    }
    p++;
}
Console.WriteLine();
Console.WriteLine();
//zad4
int suma = 0;
int f = 10;
while (f < 100)
{
    suma += f;
    f++;
}
Console.WriteLine(suma);
Console.WriteLine();
//zad 5
int x;
int n = int.Parse(Console.ReadLine());
int i = 0;
int suma = n * (n + 1) / 2;
while(i<n-1)
{
    x = int.Parse(Console.ReadLine());
    suma = suma - x;
    i++;
}
Console.WriteLine(suma);
//zad 6
int l = int.Parse(Console.ReadLine());
int m = 0;
int v = 0;
int b = 1;
int temp;
Console.WriteLine(v);
Console.WriteLine(b);
while (m < l)
{
    temp = v;
    v = b;
    b = temp + b;
    Console.WriteLine(b + " ");
    m++;
}

//zad na while
//oblicz sumę cyfr zadanej liczby n
int n = int.Parse(Console.ReadLine());
int suma = 0;
while(n>0)
{
    suma = suma + n%10;
    n = n/10;
}
Console.WriteLine(suma);
