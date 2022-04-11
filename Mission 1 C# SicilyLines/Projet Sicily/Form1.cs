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
using Projet_Sicily.controleur;

namespace Projet_Sicily
{
    public partial class Form1 : Form
    {


        string path = "../../../liaisons.txt";//chemin du fichier

        public List<Liaison> listLiaison = new List<Liaison>();

        Manager monManager;


        public Form1()
        {
            InitializeComponent();
            monManager = new Manager();
        }


        private void actualiser()
        {
            foreach (Liaison li in listLiaison) // lecture de la collection de liaison
            {
                lb.Items.Add(li.ToString()); //ajout des items dans la listbox
            }

        }

        public void sauvegarder()
        {
            StreamWriter writer = new StreamWriter(path); //Instanciation de StreamWriter
            foreach (Liaison liaison in listLiaison)
            {
                writer.WriteLine(liaison.ToString());
            }
            writer.Close();
        }

        private void Form1_Load(object sender, EventArgs e) //On rend visible et invisible des éléments au chargement
        {
            listLiaison = monManager.chargementLBD();
            if (listLiaison.Count != 0) { actualiser(); }

            btnSuppr.Visible = false;
            ButtonChange.Visible= false;
            TBArrivee.Visible = false;
            TBDepart.Visible = false;
            TBTemps.Visible = false;

        }
        private void menuAccueil_Click(object sender, EventArgs e) //On rend visible et invisible des éléments en fonction de la catégorie souhaité
        {
            lb.Visible = true;
            btnSuppr.Visible = false;
            label2.Visible = true;
        }

        

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (lb.SelectedItem == null)
            {
                MessageBox.Show("Veuillez seletionner une liaison");
            }
            else
            {

                //Fenêtre de dialogue demandant confirmation
                DialogResult result = MessageBox.Show("Êtes-vous sur de vouloir supprimer ? ", "Message de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int index = lb.SelectedIndex;
                    Liaison li = listLiaison[index];
                    monManager.deleteLiaison(li);
                    lb.Items.Clear();
                    actualiser();
                    sauvegarder();
                }

            }

        }

        private void menuSuppr_Click(object sender, EventArgs e) //On rend visible et invisible des éléments en fonction de la catégorie souhaité
        {
            lb.Visible = true;
            btnSuppr.Visible = true;
            TBDepart.Visible = false;
            TBArrivee.Visible = false;
            TBTemps.Visible = false;
            ButtonChange.Visible = false;
        }

        private void menuModif_Click(object sender, EventArgs e) //On rend visible et invisible des éléments en fonction de la catégorie souhaité
        {
            lb.Visible = true;
            btnSuppr.Visible = false;
            TBDepart.Visible = true;
            TBArrivee.Visible = true;
            TBTemps.Visible=true;
            ButtonChange.Text = "Modifier";
            ButtonChange.Visible = true;

        }
        private void menuInserer_Click(object sender, EventArgs e) //On rend visible et invisible des éléments en fonction de la catégorie souhaité
        {
            lb.Visible = true;
            btnSuppr.Visible = false;
            TBArrivee.Visible = true;
            TBDepart.Visible=true;
            TBTemps.Visible = true;
            ButtonChange.Text = "Ajouter";
            ButtonChange.Visible=true;

        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (ButtonChange.Text== "Modifier")
            {
                if (lb.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez seletionner une liaison");
                }
                else
                {
                    int index = lb.SelectedIndex;
                    monManager.updateLiaison(index,TBDepart.Text,TBArrivee.Text,TBTemps.Text);
                    lb.Items.Clear();
                    actualiser();
                    sauvegarder();
                }
            }

            if( ButtonChange.Text == "Ajouter" )
            {

                monManager.addLiaison(TBDepart.Text, TBArrivee.Text, TBTemps.Text);

                lb.Items.Clear();
                actualiser();
                sauvegarder();
            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            i = lb.SelectedIndex;

            if (i == -1) { Liaison liaison = listLiaison[0]; }

            else {
                Liaison liaison = listLiaison[i];

                TBDepart.Text = liaison.depart;
                TBArrivee.Text = liaison.arrivee;
                TBTemps.Text = liaison.duree;
            }
        }
    }
}
