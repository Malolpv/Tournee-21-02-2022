using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;


namespace _21_02_2022
{
    internal class Utilitaire
    {
        private static List<Tournee> _tourneeEnCours = new List<Tournee>();

        public static List<Tournee> TourneesEnCours()
        {
            return _tourneeEnCours;
        }
        
        public static double DistanceDeuxLampadaires(Lampadaire a ,Lampadaire b)
        {
            GeoCoordinate Ga = new GeoCoordinate(a.Latitude, a.Longitude);
            GeoCoordinate Gb = new GeoCoordinate(b.Latitude, b.Longitude);

            return Ga.GetDistanceTo(Gb);

        }
    }
}
