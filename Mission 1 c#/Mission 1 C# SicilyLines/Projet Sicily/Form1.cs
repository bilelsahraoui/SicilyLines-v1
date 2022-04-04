using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime;

namespace Projet_Sicily
{
    //Bonjour
    public partial class Form1 : Form
    {


        string path = "../../../liaisons.txt";//chemin du fichier
        public Form1()
        {
            InitializeComponent();
        }
        //Méthode pour charger le fichier
        public void charger_Fichier()
        {

            TextReader reader;
            reader = new StreamReader(path); //Instanciation de StreamReader

            string ligne = reader.ReadLine();

            while (ligne != null) //Tant que la ligne n'est pas vide
            {
                affectationObj(ligne);
                //lb.Items.Add(ligne); //On affecte "l'objet" ligne dans lb 
                ligne = reader.ReadLine(); //Lecture de la ligne

            }


            reader.Close(); //Fermeture de StreamReader
            lb.Font = new Font("Verdana", 10); //Police d'écriture
        }

        //Méthode actualiser

        private void actualiser()
        {
            lb.Items.Clear();
            charger_Fichier();
        }


        //Méthode pour supprimer une ligne
        private void supprimer_Ligne(string path, string ligne)
        {
            string texte = null; //Variable texte nulle pour effacer la ligne
            string ligneActuelle = null;
            StreamReader sr = new StreamReader(path); //Instanciation de StreamReader

            while ((sr.Peek() != -1)) //Si la ligne n'est pas vide, renvoie la valeur 1, on va chercher à trouver la ligne que l'on veut supprimer
            {
                ligneActuelle = sr.ReadLine();
                if (!(ligneActuelle == ligne)) //Selectionne seulement la ligne choisie
                {
                    texte = (texte+(ligneActuelle + "\r\n")); //Modification du texte
                }
            }
            sr.Close();

            StreamWriter sr2 = new StreamWriter(path); //Instanciation de StreamWriter
            sr2.Write(texte); //Ecriture de la ligne
            sr2.Close(); //Fermeture de StreamWriter
        }

        //Méthode pour modifier une ligne
        private void modifier_Ligne(string path, string ligneAModifier, string ligneStop)
        {
            string texteFinal = null;
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
        }

        //Méthode pour insérer une ligne
        private void inserer_ligne(string path)
        {
            string texte = tbInserer.Text; //Texte de la textbox dans un variable
            using (StreamWriter sw = File.AppendText(path)) //Instanciation de StreamWriter
            {
                sw.WriteLine(texte); //Ecriture de la ligne
                sw.Close(); //Fermeture de StreamWriter
            }
            
        }

        private void inserer_ligne(string path, string txt)
        {
           //Texte de la textbox dans un variable
            using (StreamWriter sw = File.AppendText(path)) //Instanciation de StreamWriter
            {
                sw.WriteLine(txt); //Ecriture de la ligne
                sw.Close(); //Fermeture de StreamWriter
            }

        }

        private void Form1_Load(object sender, EventArgs e) //On rend visible et invisible des éléments au chargement
        {
            charger_Fichier();
            btnSuppr.Visible = false;
            tbInserer.Visible = false;
            btnInserer.Visible = false;
            btnModif.Visible = false;
            tbModif.Visible = false;

        }

        private void affectationObj(string unTexte)
        {

            string texte = unTexte;
            string unDepart = texte.Split('-')[0];   
            string uneArrivee = texte.Split('-')[1];
            string uneDuree = texte.Split('-')[2];

            Liaison lt = new Liaison(unDepart, uneArrivee, uneDuree);

            lb.Items.Add(lt);
           
        }

        private void menuAccueil_Click(object sender, EventArgs e) //On rend visible et invisible des éléments en fonction de la catégorie souhaité
        {
            lb.Visible = true;
            btnSuppr.Visible = false;
            btnInserer.Visible = false;
            tbInserer.Visible = false;
            btnModif.Visible = false;
            tbModif.Visible = false;
            label2.Visible = true;
        }

        private void menuInserer_Click(object sender, EventArgs e) //On rend visible et invisible des éléments en fonction de la catégorie souhaité
        {
            lb.Visible = true;
            btnInserer.Visible = true;
            tbInserer.Visible = true;
            btnSuppr.Visible = false;
            btnModif.Visible = false;
            tbModif.Visible = false;
            label2.Visible = false;

        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            //Fenêtre de dialogue demandant confirmation
            DialogResult result = MessageBox.Show("Êtes-vous sur de vouloir supprimer ? ", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                supprimer_Ligne(path, Convert.ToString(lb.SelectedItem));
                actualiser();
            }
            

        }

        private void menuSuppr_Click(object sender, EventArgs e) //On rend visible et invisible des éléments en fonction de la catégorie souhaité
        {
            lb.Visible = true;
            btnSuppr.Visible = true;
            btnInserer.Visible = false;
            tbInserer.Visible = false;
            btnModif.Visible = false;
            tbModif.Visible = false;
            label2.Visible = false;
        }

        private void menuModif_Click(object sender, EventArgs e) //On rend visible et invisible des éléments en fonction de la catégorie souhaité
        {
            lb.Visible = true;
            btnSuppr.Visible = false;
            btnInserer.Visible = false;
            tbInserer.Visible = false;
            btnModif.Visible = true;
            tbModif.Visible = true;
            label2.Visible = false;
        }

        private void lb_MouseClick(object sender, MouseEventArgs e)
        {
            tbModif.Text = Convert.ToString(lb.SelectedItem);
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            //Fenêtre de dialogue demandant confirmation
            DialogResult result2 = MessageBox.Show("Êtes-vous sur de vouloir modifier ? ", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                modifier_Ligne(path, Convert.ToString(lb.SelectedItem), tbModif.Text);
                actualiser();
            }

        }

        private void btnInserer_Click(object sender, EventArgs e)
        {
            //Fenêtre de dialogue demandant confirmation
            DialogResult result2 = MessageBox.Show("Voulez vous insérer la ligne ? ", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                inserer_ligne(path);
                actualiser();
            }
        }
    
    }
}
