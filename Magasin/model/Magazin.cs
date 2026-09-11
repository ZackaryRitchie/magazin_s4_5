using System;
using System.Collections.Generic;
using System.Text;

namespace Magasin.model
{
    public class Magazin
    {
        public Compte compte
        { get;  set; }
        public Inventaire Inv {  get; set; }
        public List <Utilisateur> users { get; set; }


        public void AjoutUtilisateur(Utilisateur user)
        {
            users.Add(user);
        }
        public Utilisateur GetUtilisateur(Utilisateur user)
        {
            if (users.Contains(user) == true)
            {
                
                Console.WriteLine(users+"est dans les utilisateur");
                return users.Find(u => u.Nom==user);
            }
            else
            {
                Console.WriteLine(users + "n'est pas dans les utilisateur");
                return null;
            }
        }

        public void VendreItem()
        {
            Inv;
        }

    }
}
