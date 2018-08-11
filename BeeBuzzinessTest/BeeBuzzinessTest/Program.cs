using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeBuzzinessTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = true;
            while (ok)
            {
                Console.WriteLine("Veuillez saisir un nombre et valider avec la touche \"Entrée\" ou juste appuyer sur \"Entrée\" pour sortir");
                string saisie = Console.ReadLine();
                if (saisie != "")
                {
                    if (VerifSaisie(saisie) == true)
                    {
                        Nombre unNombre = Traitement(saisie);
                        Console.WriteLine(unNombre.GetLigne1());
                        Console.WriteLine(unNombre.GetLigne2());
                        Console.WriteLine(unNombre.GetLigne3());
                    }
                }
                else { ok = false; }
            }
        }

        private static Nombre Traitement(string nombre)
        {
            Nombre unNombre = new Nombre();
            for(int i = 0; i < nombre.Length; i++)
            {
                unNombre.GetNombre(nombre[i]);
            }
            return unNombre;
        }

        private static bool VerifSaisie(string saisie)
        {
            bool ok= true;
            for (int i = 0; i < saisie.Length; i++)
            { 
                try
                {
                    int nombre =  Int32.Parse(saisie[i].ToString());
                }
                catch (Exception ex)
                {
                    ok = false;
                }
            }
            return ok;
        }
    }
}
