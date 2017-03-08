using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Baccara
{
    class moteurBac
    {
        // Attributs.
        public double solde = 1000;
        public int mise = 0;
        public int pari = -1;	// -1 joueur , 0 égalité , 1 banque.
        public const int NBC = 52;
        public const int NBS = 6;
        private int COMPTEUR = 0;
        public Byte[] distributeur = new Byte[NBC * NBS];
        public Random rndNumbers;
        public Jeu joueur;
        public Jeu banque;
        private ConsoleColor fgDefaut;
        public int freqTriche = 0;
        public Byte textbox3Joueur = 0;
        public Byte textbox3Banque = 0;
        // Constructeur(s).
        public moteurBac()
        {
            int i;
            rndNumbers = new Random();
            joueur = new Jeu("Joueur");
            banque = new Jeu("Banque");
            for (i = 0; i < NBC * NBS; i++)
            {
                distributeur[i] = (Byte)(i % NBC);
            }
            fgDefaut = Console.ForegroundColor;
        }
        // Méthodes.
        public void distribuerCarte(Jeu x)
        {
            if (COMPTEUR >= NBS * NBC)
            {
                melanger();
                COMPTEUR = 0;
            }
            x.tab[x.nbCartes] = distributeur[COMPTEUR];
            COMPTEUR++;
            x.nbCartes++;
            x.score = evaluerMain(x);
        }
        public int evaluerMain(Jeu x)
        {
            int sc;
            int i;
            for (i = 0, sc = 0; i < x.nbCartes; i++)
                sc = sc + scoreCarte(x.tab[i]);
            return sc % 10;
        }
        public int scoreCarte(Byte C)
        {
            if (C < 40)
                return C / 4 + 1;
            return 0;
        }
        public void nouvelleMain()
        {
            joueur.nbCartes = 0;
            joueur.score = 0;
            banque.nbCartes = 0;
            banque.score = 0;   
        }
        public void afficherMain(Jeu x)
        {
            int i;
            for (i = 0; i < x.nbCartes; i++)
                afficherCarte(x.tab[i]);
        }
        public Boolean troisiemesCartes()
        {
            // Cherche à savoir si la banque ou le joueur a un naturel.
            if (estNaturel(joueur) || estNaturel(banque))
            {
                Console.Write("\n\t\t\t  Une main est un naturel");
                
                return false;
            }
            else // Aucun d'eux n'a un naturel.
            {
                if (joueur.score >= 6)	// Seule la banque tire une troisième carte ...
                {
                    if (banque.score <= 5) //... si son score est inférieur ou égal 5
                    {
                        distribuerCarte(banque);
                        textbox3Banque = 1;
                        return true;
                    }
                }
                else // Donc le score du joueur est inférieur à 6 ...
                {
                    // ... il tire alors une troisième carte ...
                    distribuerCarte(joueur);
                    textbox3Joueur = 1;
                    
                    //... et pour la banque cela dépend de 2 paramètres.
                    if (banqueTroisiemeCarte(banque.score, scoreCarte(joueur.tab[2])))
                    {
                        distribuerCarte(banque);
                        textbox3Banque = 1;
                        return true;
                    }
                }
            }
            return false;
        }
        public Boolean banqueTroisiemeCarte(int scb, int C3)
        {
            if (
                scb <= 2 ||
                (scb == 3 && C3 != 8) ||
                (scb == 4 && C3 >= 2 && C3 <= 7) ||
                (scb == 5 && C3 >= 4 && C3 <= 7) ||
                (scb == 6 && C3 >= 6 && C3 <= 7)
                )
                return true;
            return false;
        }
        public Boolean estNaturel(Jeu x)
        {
            if ((x.score >= 8) && (x.nbCartes == 2))
            return true;
            else
            return false;
        }
        public void melanger()
        {
            int i;
            int position;
            Byte temp;
            
            for (i = 0; i < NBC * NBS; i++)
            {
                position = (rndNumbers.Next() % (NBC * NBS - i)) + i;
                temp = distributeur[i];
                distributeur[i] = distributeur[position];
                distributeur[position] = temp;
            }

        }
        public void afficherCarte(Byte C)
        {
            Console.Write("[{0}{1}] ", moteurBac.sValeurCarte(C), moteurBac.cCouleurCarte(C));
            Console.ForegroundColor = fgDefaut;
        }
        public string stAfficherCarte(Byte C)
        {
            return "[" + moteurBac.sValeurCarte(C) + moteurBac.cCouleurCarte(C) + "]";
        }
        public int jeuGagnant(Jeu a, Jeu b)
        {
            if (a.score > b.score)
            {
                Console.WriteLine("\n\t\t\t\t{0} gagne", a.nom);
                return -1;
            }
            if (a.score < b.score)
            {
                Console.WriteLine("\n\t\t\t\t{0} gagne", b.nom);
                return 1;
            }
            if (a.score == b.score)
            {
                Console.WriteLine("\n\t\t      Egalité entre {0} et {1}", a.nom, b.nom);
                return 0;
            }

            return 2;
        }
        public void afficherSabot()
        {
            int i;
            for (i = 0; i < moteurBac.NBC * NBS; i++)
            {
                afficherCarte(distributeur[i]);
            }
        }
    	public void aleaTricher()
        {
        int alea;
        alea=rndNumbers.Next()%100;
        
        if(freqTriche>0 && alea<freqTriche)
               	tricher(true);
       
        if(freqTriche<0 && alea<-freqTriche)
        		tricher(false);
        
        }
        public void tricher (Boolean avantage)
        {
        	Byte temp = 0;
        	int k = COMPTEUR;
        	int l=0; 
        	distribuerCarte(joueur);              
            distribuerCarte(banque);        
            distribuerCarte(joueur);   
            distribuerCarte(banque); 
            
            troisiemesCartes();
            
            if ((pari == jeuGagnant(joueur, banque)) == avantage)
            {
            	COMPTEUR = k; 
            	// Cas favorable on remet le compteur à sa valeur initiale.	
            }
            else
            {
            	if(joueur.nbCartes == 2 && banque.nbCartes == 2)
            	{
            		temp = distributeur[k];
            		distributeur[k] = distributeur[k+1];
            		distributeur[k+1] = distributeur[k+2];
            		distributeur[k+2] = distributeur[k+3];
            		distributeur[k+3] = temp;
            		COMPTEUR = k;       		
            	}
                if (joueur.nbCartes == 3 && banque.nbCartes == 2)
                {
                    while (banque.nbCartes !=3)
                    {
                        temp = distributeur[k + 3];
                        distributeur[k + 3] = distributeur[COMPTEUR];
                        banque.tab[1] = distributeur[COMPTEUR];
                        distributeur[COMPTEUR] = temp;

                        banque.score = evaluerMain(banque);
                        if (banqueTroisiemeCarte(banque.score, scoreCarte(joueur.tab[2])))
                            distribuerCarte(banque);
                        else COMPTEUR++;
                    }
                }
            	if(banque.nbCartes == 3)
            	{
            		l=COMPTEUR-1;
            		while (((pari == jeuGagnant(joueur, banque)) !=avantage) && COMPTEUR < NBS*NBC)
            		{
            			temp = distributeur [l];
            			distributeur [l] = distributeur[COMPTEUR];
            			banque.tab[2] = distributeur [COMPTEUR];
            			banque.score = evaluerMain(banque);
            			distributeur[COMPTEUR] = temp;
            			COMPTEUR++;
            		}
            		
            		COMPTEUR = k;     		            
            	}
            	
            	if (joueur.nbCartes == 2 && banque.nbCartes !=3)
            	{
            		
            	}
            
            }
            
            COMPTEUR = k; 
            nouvelleMain();
        }
        public static string sValeurCarte(Byte C)
        {
            string s;
            int T = C / 4;
            T = T + 1;
            switch (T)
            {
                case 13:
                    s = "R";
                    break;
                case 12:
                    s = "D";
                    break;
                case 11:
                    s = "V";
                    break;
                default:
                    s = T.ToString();
                    break;
            }
            return s;
        }
        public static char cCouleurCarte(Byte C)
        {
            char c;
            int T = C % 4;
            switch (T)
            {
                case 0:
                    //pique = '\u2660';
                    c = '\u2660';

                    break;
                case 1:
                    //carreau = 
                    c = '\u2666';
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    //coeur = '\u2665';
                    c = '\u2665';
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    //trefle = '\u2663';
                    c = '\u2663';

                    break;
                default:
                    c = 'E';
                    break;
            }
            return c;
        }
        public class Jeu
        {
            public int nbCartes;
            public Byte[] tab;
            public int score;
            public string nom;

            public Jeu(string stNom)
            {
                tab = new Byte[3];
                nbCartes = 0;
                score = 0;
                nom = stNom;
            }
        }
    }
}
