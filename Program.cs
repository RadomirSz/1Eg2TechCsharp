//tablica - zmienna (kolekcja) do trzymania wielu zmiennych
/*int a = 4;
int b = 7;
int d = 3;
int c = 1;
int e;*/
/*int[] T = new int[4];
T[0] = 1;
T[1] = 6;
T[2] = 4;
T[3] = 7;

Console.WriteLine(T[1]+ " " + T[3]);
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(T[i]);
}*/
/*
int[] K = new int[] { 6, 4, 7, 2, 3, 1, 5, 9, 8 };
for (int i = 0; i < K.Length; i++)
{
    Console.Write($"{K[i]}");
}*/
/*int[] L = new int[6]{4, 5, 8, 9, 7, 6};
int maks = L[0];
for (int i = 0; i < L.Length; i++)
{
    if (L[i] > maks)
    {
        maks = L[i];
    }
}
Console.WriteLine(maks);
*/
//znajdź mini wartość w tablicy (6,2,1,4,9,5)
int[]G = new int[6] {6,2,1,4,9,5};
int mini = int.MaxValue;
for (int i = 0; i < G.Length; i++)
{
    if (G[i] < mini)
    {
        mini = G[i];
    }
}
Console.WriteLine(mini);