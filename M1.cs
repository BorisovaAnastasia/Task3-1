using System;

class OdnomernMassiv
{
    private int[] massiv;
    
    public int[] MyMassiv
    {
        get
        {
            return massiv;
        }
    }

    public int[] Mass(int N, bool not_random = false)
    {
        if (not_random == true)
        {
            massiv = new int[N];
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                massiv[i] = x;
            }
            return massiv;
        }
        else
        {
            return RandomMass(N);
        }
    }
    
    public void ShowMass()
    {
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine(massiv[i]);
        }
        Console.WriteLine(" ");
    }

    
    private int[] RandomMass(int N)
    {
        massiv = new int[N];
        Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                int value = rnd.Next(101);
                int x = value;
                massiv[i] = x;
            }
            return massiv;
    }
    
    public int SredZnach(int[] massiv)
    {
        int sum = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            sum += massiv[i];
        }
        int sredzn = sum / massiv.Length;
        return sredzn;
    }

    public int[] sort()
    {
        int count = 0;
        
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 100 && massiv[i]*(-1)<100)
            {
                count += 1;
            }
        }
        int[] mas = new int[count];
            
        int x = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 100 && massiv[i]*(-1)<100)
            {
                mas[x] = massiv[i];
                x += 1;
            }
        }
        massiv = mas;
        return massiv;
    }
    
    public int[] GetMassWoDubs()
    {
        int newMassLength = massiv.Length;
        for(int i = 0; i < massiv.Length; i++)
        {
            for(int j = i; j < massiv.Length; j++)
            {
                if(massiv[i] == massiv[j] && i != j)
                {
                    newMassLength--;
                    break;
                }
            }
        }
        int[] NewMass = new int[newMassLength];
        for(int i = 0; i < NewMass.Length; i++)
        {
            NewMass[i] = int.MinValue;
        }
        int c = 0;
        for(int i = 0; i < massiv.Length; i++)
        {
            if(!Ex(massiv[i], NewMass))
            {
                NewMass[c] = massiv[i];
                c++;
            }
        }
        massiv = NewMass;
        return massiv;
    }
    
    private static bool Ex(int val, int[] mass)
    {
        for(int i=0; i < mass.Length; i++)
        {
            if (mass[i] == val)
            {
                return true;
            }
        }
        return false;
    }
}
