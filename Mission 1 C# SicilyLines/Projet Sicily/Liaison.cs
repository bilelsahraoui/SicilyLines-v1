using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Sicily
{
    public class Liaison
    {
        public int num;
        public string duree;
        public string depart;
        public string arrivee;
        


        public Liaison(int unNum, string unDepart, string uneArrivee, string uneDuree)
        {
            this.num = unNum;
            this.duree = uneDuree;
            this.depart = unDepart;
            this.arrivee = uneArrivee;
            
        }

        public override string ToString()
        {
            return (this.depart + "-"+this.arrivee+ "-"+this.duree);
        }

        public virtual string Description
        {
            get
            {
                return ("Port de Depart : " + this.depart
              + " // Port d'Arrivee : " + this.arrivee + " // Duree :" + this.duree);
            }
        }

    }
}
