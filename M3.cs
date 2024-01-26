using System;

class S_Massiv
{
    private int[][] j_array;
    
    public int[][] MySMassiv
    {
        get
        {
            return j_array;
        }
    }
    
    public int[][] InputArray(int N, bool not_random = false)
    {
        if (not_random == true)
        {
            j_array = new int[N][];
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Ââåäèòå äëèíó {i+1} ñòðîêè: ");
                int len = int.Parse(Console.ReadLine());
                j_array[i] = new int[len];
                for (int j = 0; j < len; j++)
                {
                    Console.Write($"Ýëåìåíò [{i},{j}]: ");
                    j_array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return j_array;
        }
        else
        {
            return RandomArray(N);
        }
    }
    
    public int[][] RandomArray(int N)
    {
        j_array = new int[N][];
        Random rnd = new Random();
        for (int i = 0; i < N; i++)
        {
            int len = rnd.Next(1, 11);
            j_array[i] = new int[len];
            for (int j = 0; j < len; j++)
            {
                int value = rnd.Next(0, 101);
                j_array[i][j] = value;
            }
        }
        return j_array;
    }
    
    public void ShowArray()
    {
        for (int i = 0; i<j_array.Length;i++)
        {
            for (int j = 0; j < j_array[i].Length; j++)
            {
                if(j == j_array[i].Length-1)
                {
                    Console.WriteLine(j_array[i][j]);
                }
                else
                {
                    Console.Write(j_array[i][j]);
                    Console.Write(" ");
                }
            }
        }
    }
    
    public int SredZnachArray()
    {
        int sum = 0;
        for (int i = 0; i<j_array.Length;i++)
        {
            for (int j = 0; j < j_array[i].Length; j++)
            {
                sum += j_array[i][j];
            }
        }
        int SredznAr = sum / j_array.Length;
        return SredznAr;
    }
    
    public int[] SredZnachArrayStr()
    {
        int[] SredznAr = new int[j_array.Length];
        for (int i = 0; i<j_array.Length;i++)
        {
            int sum = 0;
            for (int j = 0; j < j_array[i].Length; j++)
            {
                sum += j_array[i][j];
            }
            int sred = sum / j_array[i].Length;
            SredznAr[i] = sred;
        }
        for (int i = 0; i<SredznAr.Length;i++)
        {
            Console.WriteLine(SredznAr[i]);
        }
        return SredznAr;
    }
    
    public int[][] EditMass()
    {
        for (int i = 0; i<j_array.Length;i++)
        {
            for (int j = 0; j < j_array[i].Length; j++)
            {
                if (j_array[i][j] % 2 == 0)
                {
                    j_array[i][j] = i*j;
                }
            }
        }
        return j_array;
    }
}
