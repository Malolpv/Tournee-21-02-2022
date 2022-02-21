namespace _21_02_2022
{
    internal class Lampadaire
    {
        private int _id;
        private string _referenceInterne;
        private double _latitude;
        private double _longitude;
        private int _numero;
        private string _adresse;
        private Modele _leModele;
        private TypeEmplacement _leTypeEmplacement;

        public Lampadaire(int id,string referenceInterne,double latitude,double longitude,int numero,string adresse)
        {
            _id = id;
            _referenceInterne = referenceInterne;
            _latitude = latitude;
            _longitude = longitude;
            _numero = numero;
            _adresse = adresse;


        }

        public double Latitude { get => _latitude; set => _latitude = value; }
        public double Longitude { get => _longitude; set => _longitude = value; }
        public int Id { get => _id; set => _id = value; }
        public string ReferenceInterne { get => _referenceInterne; set => _referenceInterne = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
    }
}