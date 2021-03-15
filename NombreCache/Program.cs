/**
 * Jeu du nombre caché
 * author : Emds
 * date : 23/05/2020
 */
using System;

namespace NombreCache
{
    class Program
    {

        static int saisie(string message, int borneMin, int borneMax)
        {
            int nombre = 0;
            bool correct = false;
            while (!correct || nombre < borneMin || nombre > borneMax)
            {
                try
                {
                    Console.Write(message + "(entre " + borneMin + " et " + borneMax + ") = ");
                    nombre = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            return nombre;
        }

        static void Main(string[] args)
        {

            // déclaration
            int valeur = 0, essai = 0, nbre = 1;
            int min = 1, max = 100;
            // saisie du nombre à chercher
            valeur = saisie("Entrez le nombre à chercher", min, max);
            Console.Clear();
            // saisie du premier essai
            essai = saisie("Entrez un essai", min, max);
            // boucle sur les essais
            while (essai != valeur)
            {
                // test de l'essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand !");
                }
                else
                {
                    Console.WriteLine(" --> trop petit !");
                }
                // saisie d'un nouvel essai
                essai = saisie("Entrez un essai", min, max);
                // compteur d'essais
                nbre++;
            }
            // valeur trouvée
            Console.WriteLine("Vous avez trouvé en " + nbre + " fois !");
            Console.ReadLine();
        }
    }
}
