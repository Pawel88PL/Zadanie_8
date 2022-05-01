using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie nr 8
            // Program sortuje wprowadzane z klawiatury liczby całkowite rosnąco.
            // Program pyta użytkownika o liczbę elementów do wprowadzenia <1,10>,
            // weryfikuje wprowadzoną liczbę i wyprowadza posortowane elementy.
            // Dodatkowo obsługuje wyjątki.
            int[] sortowanie(int[] tablica)
            {
                if (tablica.Length == 0 || tablica.Length > 10) throw new ArgumentException();
                int[] kopia = (int[]) tablica.Clone();
                for (int i = 0; i < tablica.Length; i++)
                {
                    kopia[i] = tablica[i];
                }
                for (int i = 0; i < kopia.Length; i++)
                {
                    for (int j = i + 1; j < kopia.Length; j++)
                    {
                        if (kopia[i] > kopia[j])
                        {
                            int magazyn = kopia[j];
                            kopia[j] = kopia[i];
                            kopia[i] = magazyn;
                        }
                    }
                }
                return kopia;
            }
            
            do
            {
                Console.Write("Wprowadź liczbę elementów do posortowania <1 .... 10>: ");
                if (int.TryParse(Console.ReadLine(), out int rozmiar) && rozmiar >= 1 && rozmiar <= 10)
                {
                    int[] tablica = new int[rozmiar];
                    for (int i = 0; i < rozmiar; i++)
                    {
                        tablica[i] = int.Parse(Console.ReadLine());
                    }
                    try
                    {
                        int[] tablica_posortowana = sortowanie(tablica);
                        Console.WriteLine("Tablica posortowana: ");
                        for (int i = 0; i < rozmiar; i++)
                        {
                            Console.WriteLine(tablica_posortowana[i]);
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Rozmiar tablicy poza przedziałem <1, 10>.");
                    }
                    Console.WriteLine("Tablica nieposortowana: ");
                    for (int i = 0; i < rozmiar; i++)
                    {
                        Console.WriteLine(tablica[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Zła liczba spróbuj ponownie ...");
                }

            }
            while (true);

        }
    }
}
