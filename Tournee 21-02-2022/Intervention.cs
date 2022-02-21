namespace _21_02_2022
{
    internal class Intervention
    {

        private double _dureePrevue, _dureeReelle;
        private string _description;
        private char _statut;
        private Panne _laPanne;

        public char Statut { get => _statut; set => _statut = value; }
        public double DureeReelle { get => _dureeReelle; set => _dureeReelle = value; }
        public string Description { get => _description; set => _description = value; }
        public double DureePrevue { get => _dureePrevue; set => _dureePrevue = value; }
        internal Panne LaPanne { get => _laPanne; set => _laPanne = value; }

        public Intervention(double DureePrevue,string Description,Panne unePanne)
        {
            _statut = 'N';
            _dureeReelle = 0;
            _dureePrevue = DureePrevue;
            _description = Description;
            _laPanne = unePanne;
            

        }
    }
}