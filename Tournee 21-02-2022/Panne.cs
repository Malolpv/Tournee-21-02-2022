using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_2022
{
    internal class Panne
    {
        private int _idPanne;
        private DateTime _dateHeurePanne;
        private char _statut;
        private bool _urgent;
        private Lampadaire _leLampadaire;
        private List<Intervention> _lesInterventions;

        public int IdPanne { get => _idPanne; set => _idPanne = value; }
        public DateTime DateHeurePanne { get => _dateHeurePanne; set => _dateHeurePanne = value; }
        public char Statut { get => _statut; set => _statut = value; }
        public bool Urgent { get => _urgent; set => _urgent = value; }
        internal Lampadaire LeLampadaire { get => _leLampadaire; set => _leLampadaire = value; }
        internal List<Intervention> LesInterventions { get => _lesInterventions; set => _lesInterventions = value; }

        public Panne(int idPanne, Lampadaire leLampadaire, bool urgent)
        {
            _idPanne = idPanne;
            _leLampadaire= leLampadaire;
            _urgent = urgent;
        }

        public void AjouteInterventionUrgente() 
        {
            double distPlusCourt = double.MaxValue; 

            Intervention iUrgente = new Intervention();
            foreach (Tournee tournee in Utilitaire.TourneesEnCours())
            {
                Intervention i = tournee.InterventionEnCours();
                if (i != null)
                {
                    double distance = Utilitaire.DistanceDeuxLampadaires(_leLampadaire, i.LaPanne.LeLampadaire);
                    if(distance < distPlusCourt)
                    {
                        distPlusCourt = distance;

                    }

                }
            }
            
        }

        public Intervention Get_InterventionPlusProche()
        {
            double distPlusCourt = double.MaxValue;
            foreach (Tournee tournee in Utilitaire.TourneesEnCours())
            {
                Intervention i = tournee.InterventionEnCours();
                if (i != null)
                {
                    double distance = Utilitaire.DistanceDeuxLampadaires(_leLampadaire, i.LaPanne.LeLampadaire);
                    if (distance < distPlusCourt)
                    {
                        distPlusCourt = distance;

                    }

                }
            }
        }
    }
}
