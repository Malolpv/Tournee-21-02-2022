using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_2022
{
    public class Panne
    {
        private int _idPanne;
        private DateTime _dateHeurePanne;
        private char _statut;
        private bool _urgent;
        private Lampadaire _leLampadaire;
        private List<Intervention> _lesInterventions;

        public static List<Panne> CollPanne = new List<Panne>();

        public int IdPanne { get => _idPanne; set => _idPanne = value; }
        public DateTime DateHeurePanne { get => _dateHeurePanne; set => _dateHeurePanne = value; }
        public char Statut { get => _statut; set => _statut = value; }
        public bool Urgent { get => _urgent; set => _urgent = value; }
        internal Lampadaire LeLampadaire { get => _leLampadaire; set => _leLampadaire = value; }
        internal List<Intervention> LesInterventions { get => _lesInterventions; set => _lesInterventions = value; }

        public Panne(int idPanne, Lampadaire leLampadaire, bool urgent)
        {
            _idPanne = Utilitaire.NouvelIdPanne();
            _dateHeurePanne = DateTime.Now;
            _leLampadaire= leLampadaire;
            _urgent = urgent;
            
            _lesInterventions= new List<Intervention>();
            if (_urgent)
            {
                _statut = 'C';
                AjouteInterventionUrgente();
            }
            else { _statut = 'E'; }
                
            CollPanne.Add(this);
        }
        
        

        public void AjouteInterventionUrgente() 
        {
            Tournee t = Utilitaire.TourneePlusProche(this);

            if(t != null)
            {
                t.AffecteInterventionUrgente(new Intervention(1.5, "Panne Critique", this) { Statut = 'A' };);
            }

        }

        
    }
}
