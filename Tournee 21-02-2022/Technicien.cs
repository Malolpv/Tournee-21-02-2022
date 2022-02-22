using _21_02_2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournee_21_02_2022
{
    public class Technicien
    {
        private int _id;
        private string _nom, _prenom;

        public List<Tournee> lesTournees;
        public Technicien(int id, string nom,string prenom)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            lesTournees = new List<Tournee>();
        }
    }
}
