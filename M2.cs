using System;

class D_Massiv
{
    private int[,] massiv;
    
    public int[,] MyDMassiv
    {
        get
        {
            return massiv;
        }
    }
    
    public int[,] MassD(int N, int K, bool not_random = false)
    {
        massiv = new int[N, K];
        if (not_random == true)
        {
            for (int i=0; i < N; i+=1)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Ýëåìåíò[{i},{j}]:");
                    massiv[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return massiv;
        }
        else
        {
            return RandomMassD(N, K);
        }
    } 
    
    private int[,] RandomMassD(int N, int K)
    {
        massiv = new int[N, K];
        Random rnd = new Random();
        for (int i=0; i < N; i+=1)
        {
            for (int j = 0; j < K; j++)
            {
                int value = rnd.Next(0, 101);
                massiv[i,j] = value;
            }
        }
        return massiv;
    }

    public int SredZnach()
    {
        int sum = 0;
        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                sum += massiv[i, j];
            }
        }
        int sredzn = sum / massiv.Length;
        Console.WriteLine(sredzn);
        Console.WriteLine(" ");
        return sredzn;
    }
    
    public void ShowMassD()
    {
        for (int i=0; i < massiv.GetLength(0); i+=1)
        {
            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                if(j == massiv.GetLength(1)-1)
                {
                    Console.WriteLine(massiv[i,j]);
                }
                else
                {
                    Console.Write(massiv[i,j]);
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine(" ");
    }
 
    public void Pokaz_Rev()
    {
        for (int i=0; i < massiv.GetLength(0); i+=1)
        {
            if (i%2 != 0)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    if(j == massiv.GetLength(1)-1)
                    {
                        Console.WriteLine(massiv[i,j]);
                    }
                    else
                    {
                        Console.Write(massiv[i,j]);
                        Console.Write(" ");
                    }
                }
            }
            else
            {
                for (int j = massiv.GetLength(1)-1; j >= 0; j= j - 1)
                {
                    if(j == 0)
                    {
                        Console.WriteLine(massiv[i,j]);
                    }
                    else
                    {
                        Console.Write(massiv[i,j]);
                        Console.Write(" ");
                    }
                }
            }
        }
        Console.WriteLine(" ");
    }
}
