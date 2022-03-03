using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MorseCodeReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Poruka dobrodošlice
            Console.WriteLine("MorseCodeReader v1.0");
            Console.WriteLine("by: Luka Grubić");
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
            Console.Clear();

            //Unos poruke
            Console.WriteLine("Write message to translate in MORSE CODE:");
            string porukaOriginal = Console.ReadLine();

            //Prijevod poruke
            char porukaZnak = ' ';
            string morseZnak = "";
            string porukaMorse = "";
            int n = porukaOriginal.Length;
            for(int i=0; i<n; i++)
            {
                porukaZnak = porukaOriginal[i];

                //Popis slova
                if (porukaZnak == 'a' || porukaZnak == 'A') morseZnak = ".-";
                else if (porukaZnak == 'b' || porukaZnak == 'B') morseZnak = "-...";
                else if (porukaZnak == 'c' || porukaZnak == 'C') morseZnak = "-.-.";
                else if (porukaZnak == 'd' || porukaZnak == 'D') morseZnak = "-..";
                else if (porukaZnak == 'e' || porukaZnak == 'E') morseZnak = ".";
                else if (porukaZnak == 'f' || porukaZnak == 'F') morseZnak = "..-.";
                else if (porukaZnak == 'g' || porukaZnak == 'G') morseZnak = "--.";
                else if (porukaZnak == 'h' || porukaZnak == 'H') morseZnak = "....";
                else if (porukaZnak == 'i' || porukaZnak == 'I') morseZnak = "..";
                else if (porukaZnak == 'j' || porukaZnak == 'J') morseZnak = ".---";
                else if (porukaZnak == 'k' || porukaZnak == 'K') morseZnak = "-.-";
                else if (porukaZnak == 'l' || porukaZnak == 'L') morseZnak = ".-..";
                else if (porukaZnak == 'm' || porukaZnak == 'M') morseZnak = "--";
                else if (porukaZnak == 'n' || porukaZnak == 'N') morseZnak = "-.";
                else if (porukaZnak == 'o' || porukaZnak == 'O') morseZnak = "---";
                else if (porukaZnak == 'p' || porukaZnak == 'P') morseZnak = ".--.";
                else if (porukaZnak == 'q' || porukaZnak == 'Q') morseZnak = "--.-";
                else if (porukaZnak == 'r' || porukaZnak == 'R') morseZnak = ".-.";
                else if (porukaZnak == 's' || porukaZnak == 'S') morseZnak = "...";
                else if (porukaZnak == 't' || porukaZnak == 'T') morseZnak = "-";
                else if (porukaZnak == 'u' || porukaZnak == 'U') morseZnak = "..-";
                else if (porukaZnak == 'v' || porukaZnak == 'V') morseZnak = "...-";
                else if (porukaZnak == 'w' || porukaZnak == 'W') morseZnak = ".--";
                else if (porukaZnak == 'x' || porukaZnak == 'X') morseZnak = "-..-";
                else if (porukaZnak == 'y' || porukaZnak == 'Y') morseZnak = "-.--";
                else if (porukaZnak == 'z' || porukaZnak == 'Z') morseZnak = "--..";

                //Popis brojeva
                else if (porukaZnak == '0') morseZnak = "-----";
                else if (porukaZnak == '1') morseZnak = ".----";
                else if (porukaZnak == '2') morseZnak = "..---";
                else if (porukaZnak == '3') morseZnak = "...--";
                else if (porukaZnak == '4') morseZnak = "....-";
                else if (porukaZnak == '5') morseZnak = ".....";
                else if (porukaZnak == '6') morseZnak = "-....";
                else if (porukaZnak == '7') morseZnak = "--...";
                else if (porukaZnak == '8') morseZnak = "---..";
                else if (porukaZnak == '9') morseZnak = "----.";

                //Znakovi
                else if (porukaZnak == ' ') morseZnak = "/";
                else if (porukaZnak == '.' || porukaZnak == '.' || porukaZnak == '!' || porukaZnak == '?') morseZnak = "//";

                porukaMorse = porukaMorse + " " + morseZnak;
            }

            //Ispis poruka
            Console.Clear();
            Console.WriteLine("Original message: ");
            Console.WriteLine(porukaOriginal+"\n");
            Console.WriteLine("Message in Morse Code: ");
            Console.WriteLine(porukaMorse+"\n");

            //Reprodukcija poruke
            Console.Write("Play message (y/n)? ");
            string play = Console.ReadLine();

            if (play == "Y" || play == "y")
            {
                int m = porukaMorse.Length;
                for(int j = 0; j<m; j++)
                {
                    if (porukaMorse[j] == '.') Console.Beep(800, 400);
                    else if (porukaMorse[j] == '-') Console.Beep(800, 800);
                    else if (porukaMorse[j] == ' ') Thread.Sleep(150);
                    else if (porukaMorse[j] == '/') Thread.Sleep(200);
                    Thread.Sleep(100);
                }
                Console.WriteLine("\nMessage ended!");
            }

            Console.ReadLine();
        }
    }
}
