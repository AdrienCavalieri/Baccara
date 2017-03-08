using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baccara
{
    public partial class Baccara : Form
    {
        //Attributs
        moteurBac cartes;
        int k = 0;

        public Baccara()
        {
            InitializeComponent();
            cartes = new moteurBac();
            cartes.melanger();
            textBoxSolde.Text = cartes.solde.ToString();
            textBoxMise.Text = cartes.mise.ToString();

            freqTriche.Visible = false;
            if (this.Height == 475)
                this.Height += 115;
            else
                this.Height -= 115;
        }

        void boutonAnnulerMise_Click(object sender, EventArgs e)
        {
            cartes.solde = cartes.solde + cartes.mise;
            cartes.mise = 0;
            textBoxSolde.Text = cartes.solde.ToString();
            textBoxMise.Text = cartes.mise.ToString();
        }

        void boutonPlusUn_Click(object sender, EventArgs e)
        {
            if (cartes.solde >= 1)
            {
                cartes.mise = cartes.mise + 1;
                cartes.solde = cartes.solde - 1;
            }

            textBoxSolde.Text = cartes.solde.ToString();
            textBoxMise.Text = cartes.mise.ToString();
        }

        void boutonPlusDix_Click(object sender, EventArgs e)
        {
            if (cartes.solde >= 10)
            {
                cartes.mise = cartes.mise + 10;
                cartes.solde = cartes.solde - 10;
            }

            textBoxSolde.Text = cartes.solde.ToString();
            textBoxMise.Text = cartes.mise.ToString();
        }

        void boutonPlusCent_Click(object sender, EventArgs e)
        {
            if (cartes.solde >= 100)
            {
                cartes.mise = cartes.mise + 100;
                cartes.solde = cartes.solde - 100;
            }

            textBoxSolde.Text = cartes.solde.ToString();
            textBoxMise.Text = cartes.mise.ToString();
        }

        void boutonPlusMille_Click(object sender, EventArgs e)
        {
            if (cartes.solde >= 1000)
            {
                cartes.mise = cartes.mise + 1000;
                cartes.solde = cartes.solde - 1000;
            }
            
            textBoxSolde.Text = cartes.solde.ToString();
            textBoxMise.Text = cartes.mise.ToString();
        }

        void boutonDémarrer_Click(object sender, EventArgs e)
        { 
        	//Efface les différentes textBox.
			textBoxCartesJoueur1.Clear();
            textBoxCartesJoueur2.Clear();
            textBoxCartesJoueur3.Clear();

			textBoxCartesBanque1.Clear();
            textBoxCartesBanque2.Clear();
            textBoxCartesBanque3.Clear();
			
            textBoxScoreJoueur.Clear();
		    textBoxScoreBanque.Clear();	

            //Réinitialise les variables contrôlant l'affichage des 3èmes textBoxCarte.          
            cartes.textbox3Joueur = 0;
            cartes.textbox3Banque = 0;           
     
		    if (cartes.solde >= 0 && cartes.mise > 0)
		    {
		    		
        	cartes.nouvelleMain();
            cartes.aleaTricher(); //Appel de la méthode tricher.
               
            cartes.distribuerCarte(cartes.joueur); //Distribue une première carte au joueur.             
            cartes.distribuerCarte(cartes.banque); //Distribue une première carte à la banque.       
            cartes.distribuerCarte(cartes.joueur); //Distribue une seconde carte au joueur.   
            cartes.distribuerCarte(cartes.banque); //Distribue une seconde carte à la banque.

            cartes.afficherMain(cartes.joueur);
            cartes.afficherMain(cartes.banque);

            	if (cartes.troisiemesCartes()) //Résout les situations comme décrites dans le tableau des règles.
            	{
                	cartes.afficherMain(cartes.joueur);
                	cartes.afficherMain(cartes.banque);
            	}

            	if (cartes.pari == cartes.jeuGagnant(cartes.joueur, cartes.banque)) //Résout les paris.
            	{
                	if (cartes.pari == -1)
                	{
                    	cartes.solde = cartes.solde + 2 * cartes.mise;
                        textboxPrincipale.Text = "Pari gagnant. Si vous avez assez d'argent, vous pouvez reparier !";
                	}
                	if (cartes.pari == 0)
                	{
                    	cartes.solde = cartes.solde + 9 * cartes.mise;
                        textboxPrincipale.Text = "Pari gagnant. Si vous avez assez d'argent, vous pouvez reparier !";
                	}
                	if (cartes.pari == 1)
                	{
                		cartes.solde = cartes.solde + 1.95 * cartes.mise;
                    	textboxPrincipale.Text = "Pari gagnant. Si vous avez assez d'argent, vous pouvez reparier !";
                	}

					cartes.mise = 0;				      
            	}
            	
            	else
            	{
                    textboxPrincipale.Text = "Pari perdant. Si vous avez assez d'argent, vous pouvez reparier !";
            		cartes.mise = 0;
            	}
            	
            //Affichage des cartes.
            textBoxCartesJoueur1.Text = cartes.stAfficherCarte(cartes.joueur.tab[0]);
            textBoxCartesJoueur2.Text = cartes.stAfficherCarte(cartes.joueur.tab[1]);
            if (cartes.textbox3Joueur == 1)
            textBoxCartesJoueur3.Text = cartes.stAfficherCarte(cartes.joueur.tab[2]);
            
            textBoxCartesBanque1.Text = cartes.stAfficherCarte(cartes.banque.tab[0]);
            textBoxCartesBanque2.Text = cartes.stAfficherCarte(cartes.banque.tab[1]);
            if (cartes.textbox3Banque == 1)
            textBoxCartesBanque3.Text = cartes.stAfficherCarte(cartes.banque.tab[2]);
            
            //Affichage des scores.
            textBoxScoreJoueur.Text = cartes.joueur.score.ToString();
			textBoxScoreBanque.Text = cartes.banque.score.ToString(); 
            
            //Affichage du solde et de la remise.			
            textBoxSolde.Text = cartes.solde.ToString();
           	textBoxMise.Text = cartes.mise.ToString();
           	
        	}
            else
            {
            	textboxPrincipale.Clear();
                textboxPrincipale.Text = "Erreur ! Veuillez entrer des valeurs valides.";
            }
            
        }
        
        void BoutonRadioJoueur_CheckedChanged(object sender, EventArgs e)
        {
            cartes.pari = -1; //Pari joueur.
        }

        void BoutonRadioEgalité_CheckedChanged(object sender, EventArgs e)
        {
            cartes.pari = 0; //Pari égalité.
        }

        void BoutonRadioBanque_CheckedChanged(object sender, EventArgs e)
        {
            cartes.pari = 1; //Pari banque.
        }
             
        void TrackBarTricheScroll(object sender, EventArgs e)
        {
        	cartes.freqTriche = trackBarTriche.Value; //Permet de contrôler la fréquence de triche grâce à la trackbar.
        }

        void changerCouleurBox(TextBox tx)
        {
        	if(tx.Text.Contains("\u2660") || tx.Text.Contains("\u2663"))
        		tx.ForeColor = Color.Black;
        	if(tx.Text.Contains("\u2665") || tx.Text.Contains ("\u2666"))
        		tx.ForeColor = Color.Red;
        }

        void textBoxCartesTextChanged(object sender, EventArgs e)
        {
            changerCouleurBox((TextBox)sender);
        }

        void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Permet de quitter le programme.	
        }

        void cacherBarre(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (trackBarTriche.Visible == true)
                {
                    freqTriche.Visible = false;
                    if (this.Height == 475)
                        this.Height += 115;
                    else
                        this.Height -= 115;
                }
                else
                {
                    freqTriche.Visible = true;
                    if (this.Height == 475)
                        this.Height += 115;
                    else
                        this.Height -= 115;
                }
            }
        }

        void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxCartesJoueur1.Clear();
            textBoxCartesJoueur2.Clear();
            textBoxCartesJoueur3.Clear();

            textBoxCartesBanque1.Clear();
            textBoxCartesBanque2.Clear();
            textBoxCartesBanque3.Clear();

            textBoxScoreJoueur.Clear();
            textBoxScoreBanque.Clear();

            textboxPrincipale.Clear();

            cartes.solde = 1000;
            trackBarTriche.Value = 0;

            textBoxSolde.Text = cartes.solde.ToString();
            textBoxMise.Text = cartes.mise.ToString();
        }
     }
}

