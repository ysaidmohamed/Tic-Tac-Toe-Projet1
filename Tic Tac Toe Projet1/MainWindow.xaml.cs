using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tic_Tac_Toe_Projet1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Partie partieEnCours;
        private Joueur joueurActuel1;
        private Joueur joueurActuel2;
        private List<Button> LesBoutons;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Remportez la partie en alignant 3 cases d'une même ligne", "Règles du jeu", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBoxResult startgame;
            string msgdebut ="";
            if (J1.Text != "" && J2.Text != "")
            {
                if (J1.IsReadOnly==true)
                {
                        MessageBox.Show("Une partie est déjà en cours");  
                }
                else
                {
                    msgdebut = "Joueur1 : " + J1.Text + "\nJoueur2 : " + J2.Text;
                    startgame = MessageBox.Show(msgdebut, "Choix des joueurs", MessageBoxButton.OKCancel);
                    J1.IsReadOnly = true;
                    J2.IsReadOnly = true;
                    Joueur joueur1 = new Joueur(J1.Text, 0);
                    Joueur joueur2 = new Joueur(J2.Text, 0);
                    joueurActuel1 = joueur1;
                    joueurActuel2 = joueur2;
                    Partie partie = new Partie(0, true, false);
                    List<Button> nouvBoutons = new List<Button>();
                    nouvBoutons.Add(Case1); nouvBoutons.Add(Case2); nouvBoutons.Add(Case3); nouvBoutons.Add(Case4);
                    nouvBoutons.Add(Case5); nouvBoutons.Add(Case6); nouvBoutons.Add(Case7);nouvBoutons.Add(Case8);
                    nouvBoutons.Add(Case9);
                    LesBoutons = nouvBoutons;
                    partieEnCours = partie;
                    foreach (Button unBouton in LesBoutons)
                    {
                        unBouton.IsEnabled = true;
                        unBouton.Content = "";
                    }

                }
            }
            else
            {
                MessageBox.Show("Il n'y a pas assez de joueurs");
            }    
            
        }

        private void Case1_Click(object sender, RoutedEventArgs e)
        {
            if(partieEnCours.TourjoueurA == false)
            {
                Case1.Content = "O";
                partieEnCours.TourjoueurA = true;
            }
            else
            {
                Case1.Content = "X";
                partieEnCours.TourjoueurA = false;
            }
            Case1.IsEnabled = false;
            partieEnCours.NbrTour++;
            isWin();
        }

        private void Case2_Click(object sender, RoutedEventArgs e)
        {
            if (partieEnCours.TourjoueurA == false)
            {
                Case2.Content = "O";
                partieEnCours.TourjoueurA = true;
            }
            else
            {
                Case2.Content = "X";
                partieEnCours.TourjoueurA = false;
            }
            Case2.IsEnabled = false;
            partieEnCours.NbrTour++;
            isWin();
        }

        private void Case3_Click(object sender, RoutedEventArgs e)
        {
            if (partieEnCours.TourjoueurA == false)
            {
                Case3.Content = "O";
                partieEnCours.TourjoueurA = true;
            }
            else
            {
                Case3.Content = "X";
                partieEnCours.TourjoueurA = false;
            }
            Case3.IsEnabled = false;
            partieEnCours.NbrTour++;
            isWin();
        }

        private void Case4_Click(object sender, RoutedEventArgs e)
        {
            if (partieEnCours.TourjoueurA == false)
            {
                Case4.Content = "O";
                partieEnCours.TourjoueurA = true;
            }
            else
            {
                Case4.Content = "X";
                partieEnCours.TourjoueurA = false;
            }
            Case4.IsEnabled = false;
            partieEnCours.NbrTour++;
            isWin();
        }

        private void Case5_Click(object sender, RoutedEventArgs e)
        {
            if (partieEnCours.TourjoueurA == false)
            {
                Case5.Content = "O";
                partieEnCours.TourjoueurA = true;
            }
            else
            {
                Case5.Content = "X";
                partieEnCours.TourjoueurA = false;
            }
            Case5.IsEnabled = false;
            partieEnCours.NbrTour++;
            isWin();
        }

        private void Case6_Click(object sender, RoutedEventArgs e)
        {
            if (partieEnCours.TourjoueurA == false)
            {
                Case6.Content = "O";
                partieEnCours.TourjoueurA = true;
            }
            else
            {
                Case6.Content = "X";
                partieEnCours.TourjoueurA = false;
            }
            Case6.IsEnabled = false;
            partieEnCours.NbrTour++;
            isWin();
        }

        private void Case7_Click(object sender, RoutedEventArgs e)
        {
            if (partieEnCours.TourjoueurA == false)
            {
                Case7.Content = "O";
                partieEnCours.TourjoueurA = true;
            }
            else
            {
                Case7.Content = "X";
                partieEnCours.TourjoueurA = false;
            }
            Case7.IsEnabled = false;
            partieEnCours.NbrTour++;
            isWin();
        }

        private void Case8_Click(object sender, RoutedEventArgs e)
        {
            if (partieEnCours.TourjoueurA == false)
            {
                Case8.Content = "O";
                partieEnCours.TourjoueurA = true;
            }
            else
            {
                Case8.Content = "X";
                partieEnCours.TourjoueurA = false;
            }
            Case8.IsEnabled = false;
            partieEnCours.NbrTour++;
            isWin();
        }

        private void Case9_Click(object sender, RoutedEventArgs e)
        {
            if (partieEnCours.TourjoueurA == false)
            {
                Case9.Content = "O";
                partieEnCours.TourjoueurA = true;
            }
            else
            {
                Case9.Content = "X";
                partieEnCours.TourjoueurA = false;
            }
            Case9.IsEnabled = false;
            partieEnCours.NbrTour++;
            isWin();
        }

        private void isWin()
        {
            //Compte les cases occupées
            int clicked = 0;
            foreach (Button unBouton in LesBoutons)
            {
                if(unBouton.Content.ToString() != "")
                {
                    clicked++;
                }
            }
            // Le joueur B doit aligner 3 O tandis que le joueur A doit aligner 3 X
            // Combinaisons du joueur 2 :
            if (Case1.Content.ToString() == "O" && Case4.Content.ToString() == "O" && Case7.Content.ToString() == "O" )
            {
                MessageBox.Show("Félicitations " + J2.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel2.PointsJoueur++;
                ScoreJ2.Text = joueurActuel2.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case2.Content.ToString() == "O" && Case5.Content.ToString() == "O" && Case8.Content.ToString() == "O")
            {
                MessageBox.Show("Félicitations " + J2.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel2.PointsJoueur++;
                ScoreJ2.Text = joueurActuel2.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case3.Content.ToString() == "O" && Case6.Content.ToString() == "O" && Case9.Content.ToString() == "O")
            {
                MessageBox.Show("Félicitations " + J2.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel2.PointsJoueur++;
                ScoreJ2.Text = joueurActuel2.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            //
            else if (Case1.Content.ToString() == "O" && Case2.Content.ToString() == "O" && Case3.Content.ToString() == "O")
            {
                MessageBox.Show("Félicitations " + J2.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel2.PointsJoueur++;
                ScoreJ2.Text = joueurActuel2.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case4.Content.ToString() == "O" && Case5.Content.ToString() == "O" && Case6.Content.ToString() == "O")
            {
                MessageBox.Show("Félicitations " + J2.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel2.PointsJoueur++;
                ScoreJ2.Text = joueurActuel2.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case7.Content.ToString() == "O" && Case8.Content.ToString() == "O" && Case9.Content.ToString() == "O")
            {
                MessageBox.Show("Félicitations " + J2.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel2.PointsJoueur++;
                ScoreJ2.Text = joueurActuel2.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            //
            else if (Case1.Content.ToString() == "O" && Case5.Content.ToString() == "O" && Case9.Content.ToString() == "O")
            {
                MessageBox.Show("Félicitations " + J2.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel2.PointsJoueur++;
                ScoreJ2.Text = joueurActuel2.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case3.Content.ToString() == "O" && Case5.Content.ToString() == "O" && Case7.Content.ToString() == "O")
            {
                MessageBox.Show("Félicitations " + J2.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel2.PointsJoueur++;
                ScoreJ2.Text = joueurActuel2.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            // Combinaisons du joueur 1 :
            else if (Case1.Content.ToString() == "X" && Case4.Content.ToString() == "X" && Case7.Content.ToString() == "X")
            {
                MessageBox.Show("Félicitations " + J1.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel1.PointsJoueur++;
                ScoreJ1.Text = joueurActuel1.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case2.Content.ToString() == "X" && Case5.Content.ToString() == "X" && Case8.Content.ToString() == "X")
            {
                MessageBox.Show("Félicitations " + J1.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel1.PointsJoueur++;
                ScoreJ1.Text = joueurActuel1.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case3.Content.ToString() == "X" && Case6.Content.ToString() == "X" && Case9.Content.ToString() == "X")
            {
                MessageBox.Show("Félicitations " + J1.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel1.PointsJoueur++;
                ScoreJ1.Text = joueurActuel1.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            //
            else if (Case1.Content.ToString() == "X" && Case2.Content.ToString() == "X" && Case3.Content.ToString() == "X")
            {
                MessageBox.Show("Félicitations " + J1.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel1.PointsJoueur++;
                ScoreJ1.Text = joueurActuel1.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case4.Content.ToString() == "X" && Case5.Content.ToString() == "X" && Case6.Content.ToString() == "X")
            {
                MessageBox.Show("Félicitations " + J1.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel1.PointsJoueur++;
                ScoreJ1.Text = joueurActuel1.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case7.Content.ToString() == "X" && Case8.Content.ToString() == "X" && Case9.Content.ToString() == "X")
            {
                MessageBox.Show("Félicitations " + J1.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel1.PointsJoueur++;
                ScoreJ1.Text = joueurActuel1.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            //
            else if (Case1.Content.ToString() == "X" && Case5.Content.ToString() == "X" && Case9.Content.ToString() == "X")
            {
                MessageBox.Show("Félicitations " + J1.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel1.PointsJoueur++;
                ScoreJ1.Text = joueurActuel1.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (Case3.Content.ToString() == "X" && Case5.Content.ToString() == "X" && Case7.Content.ToString() == "X")
            {
                MessageBox.Show("Félicitations " + J1.Text + " vous avez fini la partie en " + partieEnCours.NbrTour + " tours !");
                joueurActuel1.PointsJoueur++;
                ScoreJ1.Text = joueurActuel1.PointsJoueur.ToString();
                partieEnCours.IsOngoing = false;
                endGame();
            }
            else if (clicked == 9)
            {
                MessageBox.Show("Egalité");
                partieEnCours.IsOngoing = false;
                endGame();
            }
 
        }

        private void endGame()
        {
            if(partieEnCours.IsOngoing != true)
            {
                foreach(Button unBouton in LesBoutons)
                {
                    unBouton.IsEnabled = false;
                }
            }
            J1.IsReadOnly = false;
            J2.IsReadOnly = false;
        }
    }
}
