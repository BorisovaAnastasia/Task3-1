using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array type. odnomern, dvumern, stupench ");
        string tip = Console.ReadLine();
        if(tip == "odnomern")
        {
            Console.Write("Enter the length of the array ");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("Fill the array manually? true/false or skip? ");
            bool x = bool.TryParse(Console.ReadLine(), out bool not_rnd);
            
            OdnomernMassiv mass = new OdnomernMassiv();

            mass.Mass(N, not_rnd);
            mass.ShowMass();
            mass.GetMassWoDubs();
            mass.ShowMass();
            mass.sort();
            mass.ShowMass();
            Console.WriteLine(mass.MyMassiv[0]);
        }
        if(tip == "dvumern")
        {
            Console.Write("Enter number of lines ");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("Enter number of columns ");
            int K = Int32.Parse(Console.ReadLine());
            Console.Write("Fill the array manually? true/false or skip? ");
            bool y = bool.TryParse(Console.ReadLine(), out bool not_rnd);
           
            D_Massiv massiv = new D_Massiv();

            massiv.MassD(N, K, not_rnd);
            massiv.ShowMassD();
            massiv.SredZnach();
            massiv.ShowMassD();
            massiv.Pokaz_Rev();
            Console.WriteLine(massiv.MyDMassiv[5, 2]);
        }
        if(tip == "stupench")
        {
            Console.Write("Enter number of lines ");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("Fill the array manually? true/false or skip? ");
            bool z = bool.TryParse(Console.ReadLine(), out bool not_rnd);
           
            S_Massiv massiv = new S_Massiv();
            
            massiv.InputArray(N, not_rnd);
            massiv.ShowArray();
            Console.WriteLine(massiv.MySMassiv[2][0]);
            Console.WriteLine(massiv.SredZnachArray());
            massiv.SredZnachArrayStr();
            massiv.EditMass();
            massiv.ShowArray();
        }
    }
}