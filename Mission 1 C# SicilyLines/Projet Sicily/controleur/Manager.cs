using Projet_Sicily.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Sicily.controleur
{
     class Manager
    {
        LiaisonDAO ld = new LiaisonDAO();


        //Chargement de la liste des liaisons
        public List<Liaison> chargementLBD()
        {
            return (ld.Charger_Fichier());
        }

        //Modifier une liaison
        public void updateLiaison(int index, string depart, string arrivee, string duree)
        {
            ld.modifier_Ligne(index, depart, arrivee, duree);
        }

        //Ajouter une liaison
        public void addLiaison(string portDepart, string portArrivee, string duree)
        {
            ld.inserer_ligne(portDepart, portArrivee, duree);
        }

        //Supprimer une liaison
        public void deleteLiaison(Liaison liaison)
        {
            ld.supprimer_Ligne(liaison);
        }

    }
}
