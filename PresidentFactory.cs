using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Factory
{
    class PresidentFactory
    {

        public static President GetPresident(string caract)
        {
            President result = null;
            switch (caract.ToLower())
            {
                
                case "venal":
                    result = new LREM();
                    break;
                case "indecis ":
                    result = new Centre();
                    break;
                case "fou":
                    result = new Extrem_Gauche();
                    break;
                case "vegetarien":
                    result = new Ecologiste();
                    break;
                case "profiteur":
                    result = new Gauche();
                    break;
                case "psychopathe ":
                    result = new Droite();
                    break;
                case "xenophobe ":
                    result = new Extrem_Droite();
                    break;
            }
            return result;
        }

    }
}
