using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournee_21_02_2022;

namespace _21_02_2022
{
    public class Tournee
    {
        private DateTime _dateHeurePrevue;
        private Technicien _technicien;
        private List<Intervention> _lesInterventions;
        
        
        public static List<Tournee> CollTournee = new List<Tournee>();
        
        
        public DateTime DateHeurePrevue { get => _dateHeurePrevue; set => _dateHeurePrevue = value; }
        public Technicien LeTechnicien { get => _technicien; set => _technicien = value; }
        public List<Intervention> LesInterventions { get => _lesInterventions; set => _lesInterventions = value; }

        public Tournee(DateTime dateHeurePrevue,Technicien leTechnicien)
        {
            _dateHeurePrevue = dateHeurePrevue;
            _technicien = leTechnicien;
            _lesInterventions = new List<Intervention>();
            CollTournee.Add(this);
        }

        public List<Intervention> InterventionsRestantes()
        {
            List<Intervention> res = new List<Intervention>();
            
            int i = 0;
            foreach(Intervention intervention in _lesInterventions)
            {
                if(intervention.Statut == 'E')
                {
                    res.AddRange(_lesInterventions.GetRange(i+1, _lesInterventions.Count-1));
                    break;
                }
                i++;
            }
            return res;
        }

        public List<Intervention> InterventionsRestantesOLD()
        {
            List<Intervention> res = new List<Intervention>();
            Intervention iEnCours = InterventionEnCours();
            int i = 0;
            foreach (Intervention intervention in _lesInterventions)
            {
                if (intervention == iEnCours)
                {
                    res.AddRange(_lesInterventions.GetRange(i + 1, _lesInterventions.Count - 1));
                    break;
                }
                i++;
            }
            return res;
        }


        public Intervention InterventionEnCours()
        {
            Intervention res = null;
            foreach(Intervention intervention in _lesInterventions)
                if(intervention.Statut == 'E')
                {
                    res = intervention;
                    break;
                }
            return res;
        }

        //affecte une Intervention Urgente à la tournee 
        public void AffecteInterventionUrgente(Intervention param)
        {
            int i = _lesInterventions.FindIndex(x => x.Statut == 'E');
            if (i != -1)
                _lesInterventions.Insert(i+1, param);
        }

        //verifie si la tournee est en cours
        public bool EstEnCours()
        {
            if(InterventionEnCours() != null)
                return true;
            else
                return false;
        }

        //ajoute une intervention
        public void AjouteIntervention(Intervention param) 
        {
            _lesInterventions.Add(param); 
        }
        
    }
}
