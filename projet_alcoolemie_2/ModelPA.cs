using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_alcoolemie_2 {
    public class ModelPA {
        ////poids de l'utilisateur
        //private int _poids;
        //public int Poids {
        //    get {
        //        return _poids;
        //    }

        //    set {
        //        _poids = value;
        //    }
        //}

        ////sexe de l'utilisateur
        //private bool _estHomme;
        //public bool EstHomme {
        //    get {
        //        return _estHomme;
        //    }

        //    set {
        //        _estHomme = value;
        //    }
        //}

        //liste des boissons
        private List<Boisson> _boissons;
        public List<Boisson> Boissons {
            get {
                return _boissons;
            }

            set {
                _boissons = value;
            }
        }

        //liste des boissons consommees
        private List<BoissonConsommee> _boissonsConsommees;
        public List<BoissonConsommee> BoissonsConsommees {
            get {
                return _boissonsConsommees;
            }

            set {
                _boissonsConsommees = value;
            }
        }

        //taux d'alcolemie de l'utilisateur
        private double _tauxDAlcolemie;
        public double TauxDAlcolemie {
            get {
                return _tauxDAlcolemie;
            }

            set {
                _tauxDAlcolemie = value;
            }
        }

        // temps, en seconde, pour que l'utilisateur redeviennent sobre
        private int _tempsDElimination;
        public int TempsDElimination {
            get {
                return _tempsDElimination;
            }

            set {
                _tempsDElimination = value;
            }
        }

        private MainView _maMainView;
        public MainView MaMainView {
            get {
                return _maMainView;
            }

            set {
                _maMainView = value;
            }
        }

        private GraphView _maGraphView;
        public GraphView MaGraphView {
            get {
                return MaGraphView;
            }

            set {
                MaGraphView = value;
            }
        }

        public ModelPA(MainView maMainView) {
            MaMainView = maMainView;
            Boissons = new List<Boisson>();
            Boissons.Add(new Boisson("Bière", 250, 8));
            Boissons.Add(new Boisson("Bière légère", 250, 4));
            Boissons.Add(new Boisson("Bière", 500, 8));
            Boissons.Add(new Boisson("Bière légère", 500, 4));
            Boissons.Add(new Boisson("Verre de vin", 140, 11));
            Boissons.Add(new Boisson("Shot", 45, 40));

            BoissonsConsommees = new List<BoissonConsommee>();
            TauxDAlcolemie = 0;
            TempsDElimination = 0;
        }

        public void ShowGraphView() {
            MaGraphView = new GraphView(this);
            MaGraphView.Show();
        }

        public void BoireUneBoisson(Boisson b, DateTime dtBoissonConsommee) {
            BoissonsConsommees.Add(new BoissonConsommee(b, dtBoissonConsommee));
        }

        public Point[] CalculerGraphique(int largeur, int hauteur, Point pointDeDepart) {
            DateTime Current = DateTime.Now;
            Current.AddHours(-24);
        }
    }
}
