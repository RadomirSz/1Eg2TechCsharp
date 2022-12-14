Console.WriteLine("ta rakieta");
//zad1
/*int x = int.Parse(Console.ReadLine());

*/

//zad2
/*int suma = 0;
for (int i = 100; i < 1000; i++)
{
    if (i % 8 == 0 && i % 16 != 0)
    {
        suma += i;
    }
}
Console.WriteLine(suma);*/
Console.WriteLine();
//zad3
/*int podzielnik = 0;
for (int i = 99; i > 9; i--)
{
    if (i % 7 == 0)
    {
        podzielnik = i;
        break;
    }
}
int suma = 0;
for (int j = 100; j < 1000; j++)
{
    if (j % 8 == 0 && j % 16 != 0)
    {
        suma += j;
    }
}
Console.WriteLine(suma);
*/

//zad4
/*int ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if ((i % 10) * 2 <= i / 10)
    {
        ilosc += 1;
    }    
}
Console.WriteLine(ilosc);*/

//zad5 coś źle
int suma = 0;
int ilość = 0;
for (int j = 100; j < 1000; j++)
{
    if (j / 100 > j % 10 + (j/10  - j%10))
    {
        suma += j;
        ilość++;
    }
}
Console.WriteLine(ilość);
Console.WriteLine(suma);



//zad 7
