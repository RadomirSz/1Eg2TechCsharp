int sumap = 0;
int suman = 0;
int[] T = new int[100];
Random r = new Random();
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(10, 100);
}
for (int i = 0; i < T.Length; i++)
{
    if (T[i] % 2 == 0)
    {
        sumap = sumap + T[i];
    }
    else
    {
        suman = suman + T[i];
    }    
}
Console.WriteLine(sumap +" "+suman);