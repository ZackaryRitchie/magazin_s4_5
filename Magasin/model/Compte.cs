using System;
using System.Collections.Generic;
using System.Text;

namespace Magasin.model
{
    public class Compte
    {
        public int Solde {get ; set; }
    


    public Compte()
        {
            Solde = 0;
        }
    public Compte(int solde)
        {
            Solde = solde;       
        } 

    public void Depot(int argent)
        {
            Solde+= argent;
        }

    public void Retrait(int argent)
        {
            Solde -= argent;
        }



        public override string ToString()
        {
            return $"le solde est {Solde}";
        }
    }
}
