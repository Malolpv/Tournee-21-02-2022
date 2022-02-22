using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using _21_02_2022;

namespace Tournee_21_02_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lampadaire l1 = new Lampadaire(1, "a1", 48.739523, -3.44800, 1, "test");
            Lampadaire l2 = new Lampadaire(2, "a2", 48.739523, -3.44800, 1, "test");
            Lampadaire l3 = new Lampadaire(3, "a3", 48.739523, -3.44800, 1, "test");
            Lampadaire l4 = new Lampadaire(4, "a4", 48.739523, -3.44800, 1, "test");
            Lampadaire l5 = new Lampadaire(5, "a5", 48.739523, -3.44800, 1, "test");


            Panne p1 = new Panne(1, l1, false);
            Panne p2 = new Panne(2, l2, false);
            Panne p3 = new Panne(3, l2, false);
            Panne p4 = new Panne(4, l2, false);
            Panne p5 = new Panne(5, l2, false);

            Tournee t1 = new Tournee(DateTime.Now.AddHours(1), new Tournee_21_02_2022.Technicien(1, "test", "test"));
            t1.AjouteIntervention(new Intervention(1.5, "panne", p1));
            t1.LesInterventions[0].Statut = 'E';
            t1.AjouteIntervention(new Intervention(1.5, "panne", p2));
            t1.AjouteIntervention(new Intervention(1.5, "panne", p3));
            t1.AjouteIntervention(new Intervention(1.5, "panne", p4));
            t1.AjouteIntervention(new Intervention(1.5, "panne", p5));

            
            //init su chrono
            Stopwatch sw = new Stopwatch();

            //mesure de la methode 1 (normalement la plus opti)
            sw.Start();
            t1.InterventionsRestantes();
            sw.Stop();

            Console.WriteLine("Methode 1 : {0}",sw.Elapsed.ToString());

            //mesure de la methode 2 (normalement la moins opti)
            sw.Restart();
            t1.InterventionsRestantesOLD();
            sw.Stop();

            Console.WriteLine("Methode 2 : {0}", sw.Elapsed.ToString());


            Console.ReadKey();
        }
    }
}
