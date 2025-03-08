using System;
using TPMOD4;

class Program
{
    static void Main()
    {
        // Tes KodePos
        KodePos kodePos = new KodePos();
        Console.Write("Masukkan nama kota: ");
        string kota = Console.ReadLine();
        Console.WriteLine($"Kode Pos {kota}: {kodePos.GetKodePos(kota)}");

        Console.WriteLine("\n---\n");
    }
}