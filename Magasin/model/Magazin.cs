using System;
using System.Collections.Generic;
using System.Text;

namespace Magasin.model
{
    public class Magazin
    {
        public Compte Compte
        { get;  set; }
        public Inventaire Inv {  get; set; }
        public List <Utilisateur> Users { get; set; }


        public  Magazin(Compte compte,Inventaire inv, List<Utilisateur> ListeUti)
        {
            Compte= compte;
            Inv= inv;
            Users = ListeUti;
        }



        public void AjoutUtilisateur(Utilisateur user)
        {
            Users.Add(user);
        }

        public Utilisateur GetUtilisateur(Utilisateur user)
        {
            if (Users.Contains(user) == true)
            {
                
                Console.WriteLine(Users+"est dans les utilisateur");
                Utilisateur user1 = Users.Find(user => user.Nom == user.Nom);
                return user1;
            }
            else
            {
                Console.WriteLine(Users + "n'est pas dans les utilisateur");
                return null;
            }
        }

        public void VendreItem(Item item)
        {
            if (!Inv.ListItems.Contains(item) || item.Quantite<=0)
            {
                throw new InvalidDataException("l'item n'existe pas dans l'inventaire");
            }
            item.Quantite--;
        }



    }
}
