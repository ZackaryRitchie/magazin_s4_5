using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;


/*help of microsoft ingnite*/

namespace Magasin.model
{
    public class Authentification
    {
        public static Dictionary<string, string> ListeCompte =
            new Dictionary<string, string>();


        public void AjouteMP(string nom,string MotDePass)
        {
            ListeCompte.Add(nom, MotDePass);
        }




        public bool Verification(string nom, string password)
        {
            if (ListeCompte[nom]==password)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
