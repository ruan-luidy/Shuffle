using System;

class Program
{
    static Random _random = new Random();

    static void Main(string[] args)
    {
        int[] deck = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Deck original:");
        PrintDeck(deck);

        Shuffle(deck);

        Console.WriteLine("\nDeck embaralhado:");
        PrintDeck(deck);
    }

    static void Shuffle<T>(T[] array)
    {
        int n = array.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    static void PrintDeck<T>(T[] deck)
    {
        foreach (var card in deck)
        {
            Console.WriteLine(card + " ");
        }
        Console.WriteLine();
    }
}