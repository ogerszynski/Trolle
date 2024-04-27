using System;
using System.Text.RegularExpressions; //wyrazenia regularne

class Program
{
    //logika programu
    static void Main()
    {
        Console.WriteLine("Wprowadź tekst:");
        string input = Console.ReadLine(); // pobierz tekst
        string result = RemoveVowels(input); // wywolanie funkcji usuwania samoglosek
        Console.WriteLine("Wynik: " + result); // pokaz wynik
    }
// funkcja usuwania samoglosek
    static string RemoveVowels(string input)
    {
        // tworzenie wyrazenia regularnego
        Regex regex = new Regex("[aąeęioóuyAĄEĘIOÓUY]");
        
        // zastapienie pustym znakiem
        string result = regex.Replace(input, "");
        
        // wynik
        return result; 
    }
}
