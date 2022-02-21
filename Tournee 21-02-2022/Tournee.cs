using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_2022
{
    internal class Tournee
    {
        private List<Intervention> lesInterventions;



        public List<Intervention> InterventionsRestantes()
        {
            List<Intervention> res = new List<Intervention>();
            Intervention interventionEnCours = InterventionEnCours();
            int i = 0;
            foreach(Intervention intervention in lesInterventions)
            {
                if(intervention == interventionEnCours)
                {
                    res.AddRange(lesInterventions.GetRange(i, lesInterventions.Count));
                    break;
                }
                i++;
            }
            return res;
        }

        public Intervention InterventionEnCours()
        {
            Intervention res = new Intervention();
            foreach(Intervention intervention in lesInterventions)
                if(intervention.Statut == 'E')
                {
                    res = intervention;
                    break;
                }
            return res;
        }
    }
}
