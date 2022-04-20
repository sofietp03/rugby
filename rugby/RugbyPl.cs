using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rugby
{
    internal class RugbyPl
    {
        //laver en public metode så alle kan se den 
        public static  string[] AddRugbyPlayers ()
        {
            //her giver jeg et navn til mit array og siger længden er 5
            string[] rugbyplayers = new string[5];
            //listen på de forskellige spiller og den starter på 0 da arrays altid gør dette 
            rugbyplayers[0] = "Maco Itoje";
            rugbyplayers[1] = "Owen Farrell";
            rugbyplayers[2] = "Faf De Klerk";
            rugbyplayers[3] = "Jonah Lomu ";
            rugbyplayers[4] = "Bundee Aki";
            //returner jeg rugbyplayers 
            return rugbyplayers;
            
        }

    }
}
