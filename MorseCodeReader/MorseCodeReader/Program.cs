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
            porukaOriginal = porukaOriginal.ToUpper();
            //Prijevod poruke
            char porukaZnak = ' ';
            string morseZnak = "";
            string porukaMorse = "";
            int n = porukaOriginal.Length;
            for(int i=0; i<n; i++)
            {
                porukaZnak = porukaOriginal[i];

                //Popis slova
                if (porukaZnak == 'A') morseZnak = ".-";
                else if (porukaZnak == 'B') morseZnak = "-...";
                else if (porukaZnak == 'C') morseZnak = "-.-.";
                else if (porukaZnak == 'D') morseZnak = "-..";
                else if (porukaZnak == 'E') morseZnak = ".";
                else if (porukaZnak == 'F') morseZnak = "..-.";
                else if (porukaZnak == 'G') morseZnak = "--.";
                else if (porukaZnak == 'H') morseZnak = "....";
                else if (porukaZnak == 'I') morseZnak = "..";
                else if (porukaZnak == 'J') morseZnak = ".---";
                else if (porukaZnak == 'K') morseZnak = "-.-";
                else if (porukaZnak == 'L') morseZnak = ".-..";
                else if (porukaZnak == 'M') morseZnak = "--";
                else if (porukaZnak == 'N') morseZnak = "-.";
                else if (porukaZnak == 'O') morseZnak = "---";
                else if (porukaZnak == 'P') morseZnak = ".--.";
                else if (porukaZnak == 'Q') morseZnak = "--.-";
                else if (porukaZnak == 'R') morseZnak = ".-.";
                else if (porukaZnak == 'S') morseZnak = "...";
                else if (porukaZnak == 'T') morseZnak = "-";
                else if (porukaZnak == 'U') morseZnak = "..-";
                else if (porukaZnak == 'V') morseZnak = "...-";
                else if (porukaZnak == 'W') morseZnak = ".--";
                else if (porukaZnak == 'X') morseZnak = "-..-";
                else if (porukaZnak == 'Y') morseZnak = "-.--";
                else if (porukaZnak == 'Z') morseZnak = "--..";

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

                porukaMorse +=morseZnak + " ";
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
                    else if (porukaMorse[j] == ' ' || porukaMorse[j] == '/') Thread.Sleep(400);
                    Thread.Sleep(100);
                }
                Console.WriteLine("\nMessage ended!");
            }

            Console.ReadLine();
        }
    }
}
