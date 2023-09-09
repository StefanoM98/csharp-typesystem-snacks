using System.Xml.Linq;
using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] giochiDisponibili = { "Il più grande vince", "La parola vincente", "La grande somma", "La somma e la media", "Pari o dispari", "Sono nella lista?", "Solo dispari", "Somma dei dispari", "La stampa dell'array - 50", "La grande stampa" };
            int giocoScelto;
            Console.WriteLine("Benvenuto nella sala giochi!!");

            Console.WriteLine("Quale gioco vuoi giocare?");
            for (int i = 0; i < giochiDisponibili.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {giochiDisponibili[i]}");
            }

            giocoScelto = int.Parse(Console.ReadLine());
            switch (giocoScelto)
            {
                case 1:
                    Console.WriteLine("L’utente inserisce due numeri in successione. Il software stampa il maggiore");
                    int first;
                    int second;
                    Console.WriteLine("Scegli due numeri");
                    first = int.Parse(Console.ReadLine());
                    second = int.Parse(Console.ReadLine());
                    
                    if (first > second)
                    {
                        Console.WriteLine("Il numero più grande è il primo: " + first);
                    } else if (second > first)
                    {
                        Console.WriteLine("Il numero più grande è il secondo: " + second);
                    }else
                    {
                        Console.WriteLine("I numeri scelti sono uguali.");
                    }

                    break;
                case 2:
                    Console.WriteLine("L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.");
                    string firstWord;
                    string secondWord;
                    Console.WriteLine("Scrivi la prima parola");
                    firstWord = Console.ReadLine();
                    Console.WriteLine("Scrivi ora la seconda parola");
                    secondWord = Console.ReadLine();
                    if (firstWord.Length < secondWord.Length)
                    {
                        Console.WriteLine($"La parola piu piccola è {firstWord}");
                    } else if(secondWord.Length < firstWord.Length)
                    {
                        Console.WriteLine($"La parola più piccola è {secondWord}");
                    }else
                    {
                        Console.WriteLine("Le due parole hanno gli stessi caratteri");
                    }

                    break;
                case 3:
                    Console.WriteLine("Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.");
                    int sommaTotale = 0;
                    Console.WriteLine("Scrivi ora i dieci numeri che hai scelto");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Scrivi ora il {i + 1}° numero");
                        sommaTotale = sommaTotale + int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine($"La somma dei numeri che hai inserito è {sommaTotale}");
                    break;
                case 4:
                    Console.WriteLine("Calcola la somma e la media dei numeri da 2 a 10.");
                    break;
                case 5:
                    Console.WriteLine("Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.");
                    break;
                case 6:
                    Console.WriteLine("In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.");
                    break;
                case 7:
                    Console.WriteLine("Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.");
                    break;
                case 8:
                    Console.WriteLine("Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.");
                    break;
                case 9:
                    Console.WriteLine("Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.");
                    break;
                case 10:
                    Console.WriteLine("Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.");
                    break;
            }
        }
    }
}