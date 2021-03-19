using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseBatiment.Classes
{
    class Entrepot : Batiment
    {
        private string _revetementExterieur;

        private int _capaciteMaximale;

        public Entrepot(string adresse, string revetementExterieur, int capaciteMaximale) : base(adresse)
        {
            _revetementExterieur = revetementExterieur;
            _capaciteMaximale = capaciteMaximale;
        }
        public void SetRevetementExterieur(string revetementExterieur)
        {
            _revetementExterieur = revetementExterieur;
        }

        public string GetRevetementExterieur()
        {
            return _revetementExterieur;
        }
        public void SetCapaciteMaximale(int capaciteMaximale)
        {
            _capaciteMaximale = capaciteMaximale;
        }

        public int GetCapaciteMaximale()
        {
            return _capaciteMaximale;
        }
        
        public override string ToString()
        {
            return base.ToString() + " |Type de revêtement extérieur : " + _revetementExterieur + " |Capacité maximale (en tonnes) : " + _capaciteMaximale;
        }
    }
}
