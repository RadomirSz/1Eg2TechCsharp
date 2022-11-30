using System.Runtime.CompilerServices;

int n = 10;
int p = 1;
int k = 20;
int[] T = new int[n];
Random r = new Random();
for (int i = 0; i < n; i++) 
{
    T[i] = r.Next(p, k);
}
for (int i = 0; i < n; i++)
{
    Console.Write(T[i] + " ");
}
Console.WriteLine();
//zad1 najwieksza
/*int maks = T[0];
for (int i = 0; i < n; i++)
{
    if (maks < T[i])
        {
        maks = T[i];
        }
}
Console.WriteLine(maks);
*/
//zad2
/*int mini = T[0];
for (int i = 0; i < n; i++)
{
    if (mini < T[i])
    {
        mini = T[i];
    }
}
Console.WriteLine(mini);
*/
//zad3

//zad5
/*int mini = T[0];
int maks = T[0];
for (int i = 0; i < n; i++)
{
    if (maks < T[i])
    {
        maks = T[i];
    }
    if (mini > T[i])
    {
        mini = T[i];
    }
}
Console.Write("różnica: ");
Console.Write(maks - mini);*/
//zad6
/*int suma = 0;
for (int i = 0; i < n; i++)
{
    suma = suma + T[i];
}
Console.WriteLine(suma);
*/
//zad7
/*double suma = 0;
for (int i = 0; i < n; i++)
{
    suma = suma + T[i];
}
Console.WriteLine(suma);
Console.WriteLine(suma/n);
*/
//zad8
/*int pa = 0;
int np = 0;
for (int i = 0; i < n; i++)
{
    if (T[i] % 2 == 0)
    { pa = pa + 1; }
    else
    { np = np + 1; }
}
Console.WriteLine(pa);
Console.WriteLine(np);*/
//ZAD9 źle
/*int pierwsze = 0;
int suma = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 1; j < T[i]; j++)
    {
        if (T[i] % j == 0)
        {
            suma = suma + 1;
        }
    }
    if (suma > 2)
    {
        pierwsze = pierwsze + 1;
    }
    suma = 0;
}
Console.WriteLine(pierwsze);*/



//zad10 też źle
int maks = p;
for (int i = 0; i < n; i++)
{
    if (maks < T[i])
    {
        maks = T[i];
    }
}
Console.WriteLine(maks);

int mini = p;
for (int i = 0; i < n; i++)
{
    if (mini < T[i])
    {
        mini = T[i];
    }
}
Console.WriteLine(mini);

int vmaks = p;
for (int i = 0; i < n; i++)
{
    if (vmaks < T[i] && T[i] < maks)
    {
        vmaks = T[i];
    }
}
Console.WriteLine(vmaks);

int vmini = p;
for (int i = 0; i < n; i++)
{
    if (vmini < T[i] && T[i]>mini)
    {
        vmini = T[i];
    }
}
Console.WriteLine(vmini);