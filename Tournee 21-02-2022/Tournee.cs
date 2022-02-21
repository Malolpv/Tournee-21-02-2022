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

            int i = 0;
            foreach(Intervention intervention in lesInterventions)
            {
                if(intervention.Statut == 'E')
                {
                    res.AddRange(lesInterventions.GetRange(i+1, lesInterventions.Count-1));
                    break;
                }
                i++;
            }
            return res;
        }

        public Intervention InterventionEnCours()
        {
            Intervention res = null;
            foreach(Intervention intervention in lesInterventions)
                if(intervention.Statut == 'E')
                {
                    res = intervention;
                    break;
                }
            return res;
        }

        public void AffecteInterventionUrgente(Intervention param)
        {
            int i = 0; 
            foreach(var intervention in lesInterventions)
            {
                if(intervention.Statut == 'E')
                {
                    lesInterventions.Insert(i + 1, param);
                    return;
                }
                i++;
            }
        }
    }
}
