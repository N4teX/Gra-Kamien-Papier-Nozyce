class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int wyborPc = rand.Next(3);

        Console.WriteLine("Witaj w grze Kamien Papier Nozyce! Zmierz sie z naszym komputerem");
        Console.Write("Co wybierasz: kamien (k), papier (p), nozyce (n): "); string wyborUser = Console.ReadLine();
        int wyborUserInt;

        switch (wyborUser)
        {
            case "k": { wyborUserInt = 0; break; }
            case "p": { wyborUserInt = 1; break; }
            case "n": { wyborUserInt = 2; break; }
            default: { Console.WriteLine("Nie ma takiego wyboru"); break; }
        }

        //if (wyborUser == "k") { wyborUserInt = 0; }
        //else if (wyborUser == "p") { wyborUserInt = 1; }
        //else if (wyborUser == "n") { wyborUserInt = 2; }
        //else { Console.WriteLine("Zly wybor"); }
    }
}