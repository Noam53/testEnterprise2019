/**
 * Feu routier : utilisation char (à 3 valeurs)
 * Author : EMILIEN NOAM
 * Date : 22/10/2024
 */

using System;

namespace testEnterprise2019
{
    class Program
    {
        static void Main(string[] args)
        {
            char feu;

            do
            {
                Console.Write("Couleur du feu (R/O/V) = ");
                feu = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (feu != 'R' && feu != 'r' && feu != 'O' && feu != 'o' && feu != 'V' && feu != 'v');

            if (feu == 'R' || feu == 'r')
            {
                Console.WriteLine("S'arrêter");
            }
            else if (feu == 'O' || feu == 'o') 
            {
                Console.WriteLine("Ralentir");
            }
            else  
            {
                Console.WriteLine("Avancer");
            }
            Console.ReadLine();
        }
    }
}
