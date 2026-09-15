using System;
using System.Collections.Generic;
using System.Text;

namespace Magasin.model
{
    public class Inventaire
    {
        public List<Item> ListItems { get; set; } = new List<Item>();


        public Inventaire(){
            new Item("douche",212331,"une douche en bois",2599.99,"1",20);
            new Item("porche 911",412331,"porche 911 avec aucun moteur balenciaga",59.99,"2",2);
            new Item("banana",212331,"image_une_banane.png",5999.99,"3",6000000);
        }


        public void AjoutItem(Item item)
        {
            ListItems.Add(item);
        }

        public void AjoutItems(List<Item> item)
        {
            ListItems.AddRange(item);
        }


        public void RetraitItem(Item item)
        {
            ListItems.Remove(item);
        }


        public void Contains(Item item)
        {  
            if (ListItems.Contains(item)==true)
            {
                Console.WriteLine(item.Nom + "est dans l'inventaire");
            }
            else
            {
                Console.WriteLine(item.Nom + "n'est pas dans l'inventaire");
            }
        }

        public void Rechercher(Item item)
        {
            if (ListItems.Contains(item) == true)
            {
                Console.WriteLine(item.ToString()+item.Desc);
            }
            else
            {
                Console.WriteLine(item.Nom + "n'est pas dans l'inventaire");
            }
        }

        /*fichier json*/
        public void ExporterInv()
        {

        }
        public void ImporterInv()
        {

        }


        public override string ToString()
        {
            return $"{ListItems}";
        }
    }
}
