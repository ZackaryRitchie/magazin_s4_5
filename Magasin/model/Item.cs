using System;
using System.Collections.Generic;
using System.Text;

namespace Magasin.model
{
    public class Item
    {
        public string Nom {  get; set; }
        public int Id { get; set; }
        public string Desc { get; set; }
        public double Prix { get; set; }
        public string Type { get; set; }
        public int Quantite { get; set; }



        public Item(string nom, int id, string desc, double prix, string type, int quantite)
        {
            Nom = nom;
            Id = id;
            Desc = desc;
            Prix = prix;
            Type = type;
            Quantite = quantite;
        }






        public void modifier(string proprety, string changement)
        {
            switch (proprety)
            {
                case "nom":
                    Nom = changement;
                    break;
                case "id":
                    if (int.TryParse(changement, out int resultatID) == true)
                    {
                        Id = resultatID;
                    }
                    break;
                case "desc":
                    Desc = changement;
                    break;
                case "prix":
                    if (int.TryParse(changement, out int resultatPrix) == true)
                    { Prix = resultatPrix; }
                    break;
                case "type":
                    Type = changement;
                    break;
                case "quantité":
                    if (int.TryParse(changement, out int resultatQuan) == true)
                    {
                        Quantite = resultatQuan;
                    }
                    break;
            }
        }
        public override string ToString()
        {
            return $"{Nom}, {Id}, {Prix}, {Type}, {Quantite}";
        }
    }
}
