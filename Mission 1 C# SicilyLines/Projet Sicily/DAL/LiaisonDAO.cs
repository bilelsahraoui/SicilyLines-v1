using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Sicily.DAL
{

    //Si on utilise StreamReader il faut modifier les données utilisées, passé par le manager.
    public class LiaisonDAO
    {
        List<Liaison> l_liaison = new List<Liaison>();
        string path = "../../../liaisons.txt";//chemin du fichier

        //Chargement des données du fichier 
        public List<Liaison> Charger_Fichier()
        {
            //Instanciation du lecteur
            TextReader reader;
            reader = new StreamReader(path);
            string ligne = reader.ReadLine();
            int num = 1; //On ajoute un id pour chaque Liaison
            while (ligne != null) //lecture de chaque ligne
            {
                string[] mots = ligne.Split('-'); //Récuperation des données dans un tableau
                l_liaison.Add(new Liaison(num, mots[0], mots[1], mots[2])); // remplissage de la collection de liason (le tiret mots[1] est exclu)
                //list1.Items.Add(ligne);
                ligne = reader.ReadLine();
                num++;
            }
            reader.Close();

            return l_liaison;
        }


        //Suppression d'une ligne
        public void supprimer_Ligne(Liaison liaison)
        {
            l_liaison.Remove(liaison);

            //Avec utilisation de StreamReader
            /* string texte = null; //Variable texte nulle pour effacer la ligne
             string ligneActuelle = null;
             StreamReader sr = new StreamReader(path); //Instanciation de StreamReader

             while ((sr.Peek() != -1)) //Si la ligne n'est pas vide, renvoie la valeur 1, on va chercher à trouver la ligne que l'on veut supprimer
             {
                 ligneActuelle = sr.ReadLine();
                 if (!(ligneActuelle == ligne)) //Selectionne seulement la ligne choisie
                 {
                     texte = (texte + (ligneActuelle + "\r\n")); //Modification du texte
                 }
             }
             sr.Close();

             StreamWriter sr2 = new StreamWriter(path); //Instanciation de StreamWriter
             sr2.Write(texte); //Ecriture de la ligne
             sr2.Close(); //Fermeture de StreamWriter*/
        }

        //Insertion d'une ligne
        public void inserer_ligne(string liaisonD, string liaisonA, string duree)
        {
            int num = l_liaison.Count() + 1;
            l_liaison.Add(new Liaison(num, liaisonD, liaisonA, duree));

            //Avec utilisation de StreamWriter
            /*string texte = tbInserer.Text; //Texte de la textbox dans un variable
            using (StreamWriter sw = File.AppendText(path)) //Instanciation de StreamWriter
            {
                sw.WriteLine(texte); //Ecriture de la ligne
                sw.Close(); //Fermeture de StreamWriter
            }*/

        }

        //Modification d'une ligne
        public void modifier_Ligne(int index, string depart, string arrivee, string duree)
        {
            l_liaison[index].depart = depart;
            l_liaison[index].arrivee = arrivee;
            l_liaison[index].duree = duree;



            //Avec utilisation de StreamReader
            /*string texteFinal = null;
            StreamReader sr = new StreamReader(path); //Instanciation de StreamReader
            string ligneActuelle = null;
            while ((sr.Peek() != -1)) //Si la ligne n'est pas vide, renvoie la valeur 1, on va chercher à trouver la ligne que l'on veut modifier
            {
                ligneActuelle = sr.ReadLine(); //Lecture de la ligne
                if ((ligneActuelle == ligneAModifier)) //Comparaison des lignes
                {
                    texteFinal = (texteFinal+(ligneStop + "\r\n")); //Modification du texte
                }
                else
                {
                    texteFinal = (texteFinal+(ligneActuelle + "\r\n")); //Modification du texte
                }
            }
            sr.Close();  //Fermeture de StreamReader

            StreamWriter sw2 = new StreamWriter(path); //Instanciation de StreamWriter
            sw2.WriteLine(texteFinal); //Ecriture de la ligne
            sw2.Close(); //Fermeture de StreamWriter
            */
        }

    }
}
