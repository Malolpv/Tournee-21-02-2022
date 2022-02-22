using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;


namespace _21_02_2022
{
    public class Utilitaire
    {
        //public static List<Tournee> _tourneeEnCours = new List<Tournee>();

        //retourne la liste des tournees en cours
        public static List<Tournee> TourneesEnCours()
        {
            List<Tournee> res = new List<Tournee>();
            foreach(Tournee ti in Tournee.CollTournee)
            {
                if(ti.EstEnCours() && ti.DateHeurePrevue.Date == DateTime.Now.Date)
                    res.Add(ti);
            }
            return res;
        }
        
        //retourne la distance arrondie au mètre entre deux lampadaires
        public static double DistanceDeuxLampadaires(Lampadaire a ,Lampadaire b)
        {
            GeoCoordinate Ga = new GeoCoordinate(a.Latitude, a.Longitude);
            GeoCoordinate Gb = new GeoCoordinate(b.Latitude, b.Longitude);
            
            return Math.Round(Ga.GetDistanceTo(Gb));

        }

        //retourne la tournée la plus proche de la panne en cours
        public static Tournee TourneePlusProche(Panne param)
        {
            double distPlusCourt = double.MaxValue;
            Tournee tPlusProche = null;
            foreach (Tournee tournee in Utilitaire.TourneesEnCours())
            {
                Intervention i = tournee.InterventionEnCours();
                if (i != null)
                {
                    double distance = Utilitaire.DistanceDeuxLampadaires(param.LeLampadaire, i.LaPanne.LeLampadaire);
                    if (distance < distPlusCourt)
                    {
                        distPlusCourt = distance;
                        tPlusProche = tournee;
                    }

                }
            }
            return tPlusProche;
        }
        
        public static int NouvelIdPanne()
        {
            return Panne.CollPanne.Last().IdPanne + 1;
        }
    }
}
