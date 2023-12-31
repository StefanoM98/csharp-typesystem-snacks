﻿using System.Xml.Linq;
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
                    int primo;
                    int secondo;
                    Console.WriteLine("Scegli due numeri");
                    primo = int.Parse(Console.ReadLine());
                    secondo = int.Parse(Console.ReadLine());
                    
                    if (primo > secondo)
                    {
                        Console.WriteLine("Il numero più grande è il primo: " + primo);
                    } else if (secondo > primo)
                    {
                        Console.WriteLine("Il numero più grande è il secondo: " + secondo);
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
                    float mediaNumeri;
                    int totaleSomma = 0;
                    int numeroMinimo = 2;
                    int numeroMaximo = 10;
                    int numeriTotali = 1;

                    for (int i = numeroMinimo; i<=numeroMaximo; i++)
                    {
                        totaleSomma = totaleSomma + i;
                        numeriTotali++;
                    }

                    mediaNumeri = (float)totaleSomma / (float)numeriTotali;
                    Console.WriteLine($"La somma dei numeri è {totaleSomma}");
                    Console.WriteLine($"Mentre la media di questo numero è {mediaNumeri}");
                    break;
                case 5:
                    Console.WriteLine("Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.");
                    int numeroUtente;
                    Console.WriteLine("Scrivi ora un numero.");
                    numeroUtente = int.Parse(Console.ReadLine());
                    if (numeroUtente % 2 == 0)
                    {
                        Console.WriteLine($"Il tuo numero è pari: {numeroUtente}");
                    }
                    else
                    {
                        Console.WriteLine($"Ci dispiace, i numeri dispari non sono ammessi per questo ti stampo un numero pari cioè {numeroUtente + 1}");
                    }
                    break;

                case 6:
                    Console.WriteLine("In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.");
                    string[] invitatiAllaFesta = {"Stefano", "Giulia", "Ilaria", "Antonio", "Alessandra"};
                    string nomeInvitato;
                    Console.WriteLine("Dimmi il tuo nome, controllo se è in lista");
                    nomeInvitato = Console.ReadLine();
                    bool exist = Array.Exists(invitatiAllaFesta, element => element == nomeInvitato);
                    if (exist)
                    {
                        Console.WriteLine("Prego può entrare");
                    } else
                    {
                        Console.WriteLine("Non puoi mi spiace");
                    }
                   
                    break;
                case 7:
                    Console.WriteLine("Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.");
                    int[] numeri = new int[6];
                    int posizione = 0;
                    for (int i = 0; i < numeri.Length; i++)
                    {
                        Console.WriteLine($"Inserisci {numeri.Length} numeri. {i + 1}°");
                        int numeriScelti = int.Parse(Console.ReadLine());
                        
                        if (numeriScelti % 2 == 1){
                            numeri[posizione] = numeriScelti;
                            posizione++;
                        }
                    }

                    Console.WriteLine($"Ecco i tuoi numeri dispari");
                    for (int i = 0; i < numeri.Length; i++)
                    {
                        Console.WriteLine(numeri[i]);
                    }

                    break;
                case 8:
                    Console.WriteLine("Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.");
                    int[] array = { 1, 2, 3, 4, 5, 6 };
                    int dispari = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i % 2 == 1)
                            dispari += array[i];
 
                    }

                    Console.WriteLine($"La somma dei numeri i posizione pari è {dispari} ");

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