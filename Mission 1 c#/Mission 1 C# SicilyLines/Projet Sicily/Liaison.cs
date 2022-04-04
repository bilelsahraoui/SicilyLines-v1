using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Sicily
{
    public class Liaison
    {
        public static int autoId = 1;
        public int id;
        public string duree;
        public string depart;
        public string arrivee;


        public Liaison(string unDepart, string uneArrivee, string uneDuree)
        {
            this.id = autoId++;
            this.duree = uneDuree;
            this.depart = unDepart;
            this.arrivee = uneArrivee;
        }

        public override string ToString()
        {
            return (this.id+" | "+this.depart + " - "+this.arrivee+ " : "+this.duree);
        }


    }
}
