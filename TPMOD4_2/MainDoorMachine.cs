using TPMOD4_2;

class MainDoorMachine
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine();

        while (true)
        {
            Console.Write("\nMasukkan perintah (Buka/Kunci/Keluar): ");
            string input = Console.ReadLine().ToLower();

            if (input == "buka")
            {
                pintu.BukaPintu();
            }
            else if (input == "kunci")
            {
                pintu.KunciPintu();
            }
            else if (input == "keluar")
            {
                Console.WriteLine("Program selesai.");
                break;
            }
            else
            {
                Console.WriteLine("Perintah tidak dikenali!");
            }
        }
    }
}