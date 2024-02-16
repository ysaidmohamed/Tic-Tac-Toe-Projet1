using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Projet1
{
    public class Partie
    {
        private int nbrTour;
        private bool isOngoing;
        private bool tourjoueurA;

        public Partie(int unNbrTour,bool unOngoing , bool unTourJoueurA)
        {
            unNbrTour = nbrTour;
            unOngoing = isOngoing;
            unTourJoueurA = tourjoueurA;
        }

        public int NbrTour { get => nbrTour; set => nbrTour = value; }
        public bool IsOngoing { get => isOngoing; set => isOngoing = value; }
        public bool TourjoueurA { get => tourjoueurA; set => tourjoueurA = value; }
    }
}
