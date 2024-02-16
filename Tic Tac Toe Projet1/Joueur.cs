using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Projet1
{
    public class Joueur
    {
        private string nomJoueur;
        private int pointsJoueur;

        public Joueur(string unNomJoueur, int lesPointsJoueur)
        {
            unNomJoueur = NomJoueur;
            lesPointsJoueur = PointsJoueur;
        }

        public string NomJoueur { get => nomJoueur; set => nomJoueur = value; }
        public int PointsJoueur { get => pointsJoueur; set => pointsJoueur = value; }
    }
    

}
