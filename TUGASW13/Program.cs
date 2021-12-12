using System;
using System.Collections.Generic;
using System.Linq;

namespace TUGASW13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            int StatusPembuka = 0;
            while (StatusPembuka == 0)
            {
                Console.Write("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll \nChoose what to do: ");
                int Pilihan = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                if (Pilihan == 1)
                {
                    Console.WriteLine("Scroll to learn list: ");
                    foreach (var ScrollBaru in Scrolls)
                    {
                        Console.WriteLine("Scroll " + (Scrolls.FindIndex(a => a.Contains(ScrollBaru)) + 1) + " : " + ScrollBaru);
                    }
                }
                else if (Pilihan == 2)
                {
                    Console.Write("How many scroll to add: ");
                    int BanyakScroll = Convert.ToInt16(Console.ReadLine());
                    Console.Write("In what number of queue: ");
                    int LetakScroll = Convert.ToInt16(Console.ReadLine());
                    for (int baru = 0; baru < BanyakScroll; baru++)
                    {
                        Console.Write("Scroll " + (baru + 1) + " name: ");
                        string BukuBaru = Console.ReadLine();
                        Scrolls.Insert((LetakScroll) - 1, BukuBaru);
                        LetakScroll += 1;
                    }
                }
                else if (Pilihan == 3)
                {
                    Console.Write("Insert scroll name : ");
                    string Tambahan = Console.ReadLine();

                    if (Scrolls.Contains(Tambahan, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.Write("Book found. Queue number: " + Scrolls.FindIndex(a => a.Equals(Tambahan, StringComparison.OrdinalIgnoreCase)) + 1);
                    }
                    else
                    {
                        Console.WriteLine("Book not found");
                    }
                    Console.WriteLine();
                }
                else if (Pilihan == 4)
                {
                    Console.Write("Remove from list by scroll name? Y/N : ");
                    string PilihanHapus = Console.ReadLine();
                    while (PilihanHapus != "Y" && PilihanHapus != "N" && PilihanHapus != "y" && PilihanHapus != "n")
                    {
                        Console.WriteLine("Wrong selection. Choose again : ");
                        Console.Write("Remove from list by scroll name? Y/N : ");
                        string PilihanHapuss = Console.ReadLine();
                        PilihanHapus = PilihanHapuss;
                    }

                    if(PilihanHapus == "Y" || PilihanHapus == "y")
                    {
                        Console.Write("input scroll name : ");
                        string HapusNama = Console.ReadLine();
                        if (Scrolls.Contains(HapusNama, StringComparer.OrdinalIgnoreCase))
                        {
                            Scrolls.RemoveAll(a => a.Equals(HapusNama, StringComparison.OrdinalIgnoreCase));
                            Console.WriteLine("Book Removed!");
                        }
                        else
                        {
                            Console.WriteLine("Book not found");
                        }
                    }
                    else
                    {
                        Console.Write("input scroll queue : ");
                        int HapusAngka = Convert.ToInt16(Console.ReadLine());
                        while (HapusAngka <= 0 || HapusAngka > Scrolls.Count)
                        {
                            Console.WriteLine("Queue not found. insert scroll queue:");
                            int HapusAngkaa = Convert.ToInt32(Console.ReadLine());
                            HapusAngka = HapusAngkaa;
                        }
                        Scrolls.RemoveAt(HapusAngka-1);
                        Console.Write("Book removed!");


                    }
                }
                else
                {
                    StatusPembuka = 0;
                }
                Console.WriteLine();
            }
        }
    }
}
