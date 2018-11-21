using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfosEmp
{
    class Program
    {
        struct employe
        {
            public string Nom_employe;
            public string Prenom_employe;
            public int Type_employe;
            public double Salaire;
            public string Courriel;
            public date Date_naissance;
        }

        struct date
        {
            public int annee;
            public string mois;
            public int jour;
        }

        static void afficheStruct(employe profil)
        {
            Console.WriteLine("*************************\n");
            Console.WriteLine("Prénom : {0}", profil.Prenom_employe);
            Console.WriteLine("Nom : {0}", profil.Nom_employe);
            Console.WriteLine("Type d'employé : {0}", profil.Type_employe);
            Console.WriteLine(String.Format("Salaire : {0:C}", profil.Salaire));
            Console.WriteLine("Courriel : {0}", profil.Courriel);
            Console.WriteLine("Date de naissance : {0} {1} {2}", profil.Date_naissance.jour, profil.Date_naissance.mois, profil.Date_naissance.annee);
            Console.WriteLine("\n");
        }

        static void TrierParAge(employe[] Age)
        {
            int[] x = new int[4];

            for (int i = 0; i <= x.GetUpperBound(0); i++)
            {
                x[i] = Age[i].Date_naissance.annee;
            }
            Array.Sort(x);
            Array.Reverse(x);

            for (int i = 0; i <= x.GetUpperBound(0); i++)
            {
                Console.Write(x[i] + " \n");
            }
            Console.WriteLine("\n");
        }

        static void TrierCourriel(employe[] Email)
        {
            string[] y = new string[4];

            for (int i = 0; i <= y.GetUpperBound(0); i++)
            {
                y[i] = Email[i].Courriel;
            }
            Array.Sort(y);

            for (int i = 0; i <= y.GetUpperBound(0); i++)
            {
                Console.Write(y[i] + " \n");
            }
            Console.WriteLine("\n");
        }

        static void SeparerSalaire(employe[] SepSalaire)
        {
            Console.WriteLine("Les travailleurs gagnant entre 10 000$ et 30 000$ sont : \n");
            for (int k = 0; k < SepSalaire.Length; k++)
            {
                if (SepSalaire[k].Salaire >= 10000 && SepSalaire[k].Salaire <= 30000)
                {
                    Console.WriteLine(SepSalaire[k].Prenom_employe + " " + SepSalaire[k].Nom_employe + (String.Format(" avec {0:C}", SepSalaire[k].Salaire)));
                }
            }
            Console.WriteLine("\n*************************\n");
            Console.WriteLine("Les travailleurs gagnant entre 30 001$ et 50 000$ sont : \n");
            for (int k = 0; k < SepSalaire.Length; k++)
            {
                if (SepSalaire[k].Salaire >= 30001 && SepSalaire[k].Salaire <= 50000)
                {
                    Console.WriteLine(SepSalaire[k].Prenom_employe + " " + SepSalaire[k].Nom_employe + (String.Format(" avec {0:C}", SepSalaire[k].Salaire)));
                }
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            employe[] travailleur = new employe[4];

            travailleur[0].Prenom_employe = "Marco";
            travailleur[0].Nom_employe = "Polo";
            travailleur[0].Type_employe = 2;
            travailleur[0].Salaire = 20000;
            travailleur[0].Courriel = "MPolo@hotmail.com";
            travailleur[0].Date_naissance.jour = 09;
            travailleur[0].Date_naissance.mois = "Juin";
            travailleur[0].Date_naissance.annee = 1970;

            travailleur[1].Prenom_employe = "Marie";
            travailleur[1].Nom_employe = "Curie";
            travailleur[1].Type_employe = 1;
            travailleur[1].Salaire = 45000;
            travailleur[1].Courriel = "MCurie@hotmail.com";
            travailleur[1].Date_naissance.jour = 30;
            travailleur[1].Date_naissance.mois = "Octobre";
            travailleur[1].Date_naissance.annee = 1965;

            travailleur[2].Prenom_employe = "René";
            travailleur[2].Nom_employe = "Descartes";
            travailleur[2].Type_employe = 3;
            travailleur[2].Salaire = 35000;
            travailleur[2].Courriel = "RDescartes@gmail.com";
            travailleur[2].Date_naissance.jour = 20;
            travailleur[2].Date_naissance.mois = "Mars";
            travailleur[2].Date_naissance.annee = 1960;

            travailleur[3].Prenom_employe = "Anne";
            travailleur[3].Nom_employe = "Conway";
            travailleur[3].Type_employe = 4;
            travailleur[3].Salaire = 32000;
            travailleur[3].Courriel = "AConway@gmail.com";
            travailleur[3].Date_naissance.jour = 20;
            travailleur[3].Date_naissance.mois = "Mars";
            travailleur[3].Date_naissance.annee = 1980;

            for (int compt = 0; compt < travailleur.Length; compt++)
            {
                afficheStruct(travailleur[compt]);
            }

            Console.WriteLine("***********************\n");
            TrierParAge(travailleur);
            Console.WriteLine("***********************\n");
            SeparerSalaire(travailleur);
            Console.WriteLine("***********************\n");
            TrierCourriel(travailleur);
            Console.ReadLine();
        }
    }
}
