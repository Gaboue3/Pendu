using System;

namespace Labo3_exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finale = false;
            while (finale == false)
            {
                string[] tabNom = { "league", "noob", "champion", "summoner", "spell", "item", "lagging", "kills", "dragon", "nashor" };
                Random choixmot = new Random();
                int choixmots = choixmot.Next(0, 10);
                string word = tabNom[choixmots];
                char lettresaisi = ' ';
                char[] tabword = new char[6];
                bool saisi = true;
                int pos = 0;
                int erreur = 0;
                char[] tabAffichage = new char[word.Length];
                for (int i = 0; i < tabAffichage.Length; i++)
                {
                    tabAffichage[i] = '_';
                }
                for (int i = 0; i < tabword.Length; i++)
                {
                    tabword[i] = '_';
                }
                int compteur = 0;
                while (saisi == true)
                {
                    //affichage
                    Console.Clear();
                    Console.WriteLine(" ");
                    switch (erreur)
                    {

                        case 0:
                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   "); break;
                        case 1:
                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   "); break;
                        case 2:
                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("    /|  |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   "); break;
                        case 3:
                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("    /|\\ |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   "); break;
                        case 4:
                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("    /|\\ |     ");
                            Console.WriteLine("     -  |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   "); break;
                        case 5:
                            Console.WriteLine("     |--|     ");
                            Console.WriteLine("     O  |     ");
                            Console.WriteLine("    /|\\ |     ");
                            Console.WriteLine("     -  |     ");
                            Console.WriteLine("    / \\ |     ");
                            Console.WriteLine("        |     ");
                            Console.WriteLine("     ------   "); break;

                    }

                    int fin = 0;
                    Console.WriteLine("Saisir une lettre:");
                    Console.WriteLine(tabAffichage);
                    Console.WriteLine("Vos erreurs: " + erreur);
                    Console.WriteLine("Vos lettres mauvaises: ");
                    Console.WriteLine(tabword);
                    lettresaisi = Convert.ToChar(Console.ReadLine());

                    for (int i = 0; i < word.Length; i++)
                    {

                        if (lettresaisi == word[i])
                        {
                            if (tabAffichage[i] == '_')
                            {
                                tabAffichage[i] = lettresaisi;
                                pos = i;

                            }
                        }

                    }
                    if (lettresaisi != word[pos])
                    {
                        erreur += 1;
                        tabword[compteur] = lettresaisi;
                        compteur++;
                    }
                    for (int e = 0; e < word.Length; e++)
                    {
                        if (tabAffichage[e] != '_')
                        {
                            fin += 1;
                        }
                    }

                    if (fin == word.Length)
                    {
                        Console.Clear();
                        Console.WriteLine("Le mot est: ");
                        Console.WriteLine(tabAffichage);
                        Console.WriteLine("VOUS AVEZ GAGNEZ!");
                        saisi = false;
                    }

                    if (erreur == 6)
                    {
                        Console.WriteLine("Vous avez perdu.");
                        saisi = false;
                    }
                }
                Console.WriteLine("Voulez-vous rejouer?");
                int choix3 = 0;
                choix3 = Convert.ToInt32(Console.ReadLine());
                if (choix3 == 1)
                {
                    finale = false;
                }

                else if (choix3 == 2)
                {
                    finale = true;
                }
            }
        }
    }
}

