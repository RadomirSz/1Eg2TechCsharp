//zad1
for (int i = 1; i < 31; i++)
{
    Console.WriteLine("dzień " + i);
}
//zad2

for (int i = 1; i <= 10; i++)
if (i%2 != 0)
{
     Console.WriteLine(i*i);
}
//zad3
for (int i = 1000; i < 10000; i++)
if(i%379 == 0)
{
    Console.WriteLine(i);
}
//zad4
for(int i=100;i<1000;i++)
if (i%5 == 0 || i%6 == 0 || i%11 == 0)
{
    Console.WriteLine(i);
}
//zad5
int suma = 0;
int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    int x = int.Parse(Console.ReadLine());
    suma += x;
}
Console.WriteLine(suma);
