using System;
using TPMOD4;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();
        Console.WriteLine($"Kode Pos {kelurahan}: {KodePos.GetKodePos(kelurahan)}");

        Console.WriteLine("\n---\n");
    }
}