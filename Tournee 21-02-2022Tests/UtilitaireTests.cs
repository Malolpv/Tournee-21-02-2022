using Microsoft.VisualStudio.TestTools.UnitTesting;
using _21_02_2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
namespace _21_02_2022.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod()]
        public void DistanceDeuxLampadairesTest()
        {

            Lampadaire l1 = new Lampadaire(1, "test1", 48.739523, -3.444800, 1, "test1");
            Lampadaire l2 = new Lampadaire(2, "test2", 48.738455, -3.444671, 2, "test2");

            double res = Utilitaire.DistanceDeuxLampadaires(l1, l2);
            double attendu = 119;
            Assert.AreEqual(attendu, res);
        }

        [TestMethod()]
        public void TourneesEnCoursTest()
        {
            Lampadaire l1 =new Lampadaire(1, "a1", 48.739523, -3.44800, 1, "test");
            Lampadaire l2 = new Lampadaire(1, "a1", 48.739523, -3.44800, 1, "test");


            Panne p1 = new Panne(1,l1,false);
            Panne p2 = new Panne(2,l2,false);

            Intervention i1 = new Intervention(1.5, "panne",p1);
            Intervention i2 = new Intervention(1.5, "panne",p2);

            Tournee t1 = new Tournee(DateTime.Now.AddHours(1),new Tournee_21_02_2022.Technicien(1,"test","test"));
            t1.AjouteIntervention(new Intervention(1.5, "panne", p1));
            t1.LesInterventions[0].Statut = 'E';
            t1.AjouteIntervention(new Intervention(1.5, "panne", p2));
            
            Tournee t2 = new Tournee(DateTime.Now.AddHours(2), new Tournee_21_02_2022.Technicien(2, "test", "test"));
            t2.AjouteIntervention(new Intervention(1.5, "panne", p1));
            t2.AjouteIntervention(new Intervention(1.5, "panne", p2));
            t2.LesInterventions[1].Statut = 'E';

            Tournee t3 = new Tournee(DateTime.Now.AddHours(3), new Tournee_21_02_2022.Technicien(3, "test", "test"));
            t3.AjouteIntervention(new Intervention(1.5, "panne", p1));
            t3.AjouteIntervention(new Intervention(1.5, "panne", p2));



            List<Tournee>attendu = new List<Tournee>();
            attendu.Add(t1);
            attendu.Add(t2);

            List<Tournee> res = Utilitaire.TourneesEnCours();
            CollectionAssert.AreEqual(attendu,res);
        }
    }
}