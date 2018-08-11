using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeBuzzinessTest
{
    class Nombre
    {
        
        private string ligne1="";
        private string ligne2 ="";
        private string ligne3 ="";

        public Nombre()
        {
        }

        public void GetNombre(char chiffre)
        {
            switch (chiffre)
            {
                case '1':
                    ligne1 = ligne1 + "    ";
                    ligne2 = ligne2 + "   |";
                    ligne3 = ligne3 + "   |";
                    break;
                case '2':
                    ligne1 = ligne1 + "  _ ";
                    ligne2 = ligne2 + "  _|";
                    ligne3 = ligne3 + " |_ ";
                    break;
                case '3':
                    ligne1 = ligne1 + "  _ ";
                    ligne2 = ligne2 + "  _|";
                    ligne3 = ligne3 + "  _|";
                    break;
                case '4':
                    ligne1 = ligne1 + "    ";
                    ligne2 = ligne2 + " |_|";
                    ligne3 = ligne3 + "   |";
                    break;
                case '5':
                    ligne1 = ligne1 + "  _ ";
                    ligne2 = ligne2 + " |_ ";
                    ligne3 = ligne3 + "  _|";
                    break;
                case '6':
                    ligne1 = ligne1 + "  _ ";
                    ligne2 = ligne2 + " |_ ";
                    ligne3 = ligne3 + " |_|";
                    break;
                case '7':
                    ligne1 = ligne1 + "  _ ";
                    ligne2 = ligne2 + "   |";
                    ligne3 = ligne3 + "   |";
                    break;
                case '8':
                    ligne1 = ligne1 + "  _ ";
                    ligne2 = ligne2 + " [_|";
                    ligne3 = ligne3 + " |_|";
                    break;
                case '9':
                    ligne1 = ligne1 + "  _ ";
                    ligne2 = ligne2 + " |_|";
                    ligne3 = ligne3 + "   |";
                    break;
                case '0':
                    ligne1 = ligne1 + "  _ ";
                    ligne2 = ligne2 + " | |";
                    ligne3 = ligne3 + " |_|";
                    break;
            }
        }

        public string GetLigne1()
        {
            return ligne1;
        }
        public string GetLigne2()
        {
            return ligne2;
        }
        public string GetLigne3()
        {
            return ligne3;
        }

    }
}
