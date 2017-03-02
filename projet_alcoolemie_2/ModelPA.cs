using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_alcoolemie_2 {
    public class ModelPA {
        //poids de l'utilisateur
        private int _poids;
        public int Poids {
            get {
                return _poids;
            }

            set {
                _poids = value;
            }
        }

        //sexe de l'utilisateur
        private bool _estHomme;
        public bool EstHomme {
            get {
                return _estHomme;
            }

            set {
                _estHomme = value;
            }
        }

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
                return _maGraphView;
            }

            set {
                _maGraphView = value;
            }
        }

        public ModelPA(MainView maMainView) {
            MaMainView = maMainView;
            Boissons = new List<Boisson>();
            Boissons.Add(new Boisson("Bière", 250, 5));
            Boissons.Add(new Boisson("Bière légère", 250, 4));
            Boissons.Add(new Boisson("Bière", 500, 5));
            Boissons.Add(new Boisson("Bière légère", 500, 4));
            Boissons.Add(new Boisson("Verre de vin", 140, 11));
            Boissons.Add(new Boisson("Shot", 45, 40));

            BoissonsConsommees = new List<BoissonConsommee>();
            TauxDAlcolemie = 0;
            TempsDElimination = 0;
            MaGraphView = new GraphView(this);


            //////////////////////TEST

            Poids = 60;
            EstHomme = true;
            BoissonsConsommees.Add(new BoissonConsommee(Boissons[2], new DateTime(2017, 3, 1, 21, 0, 0)));
            BoissonsConsommees.Add(new BoissonConsommee(Boissons[2], new DateTime(2017, 3, 1, 22, 0, 0)));
            BoissonsConsommees.Add(new BoissonConsommee(Boissons[2], new DateTime(2017, 3, 1, 22, 0, 0)));
            BoissonsConsommees.Add(new BoissonConsommee(Boissons[5], new DateTime(2017, 3, 2, 13, 0, 0)));
            BoissonsConsommees.Add(new BoissonConsommee(Boissons[5], new DateTime(2017, 3, 2, 15, 0, 0)));

            //////////////////////FIN TEST
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
            Current = Current.AddDays(-1);
            Current = Current.AddSeconds(-Current.Second);
            Current = Current.AddMinutes(-Current.Minute % 15);
            double tmpTauxAlcolemie = 0;
            Point[] tmpGraph = new Point[192];

            // 192 c'est le nombre de 1/4 d'heure sur 48 heures (24 avant -> 24 apres maintenant)
            for (int i = 0; i < 192; i++) {
                Current = Current.AddMinutes(15);

                tmpTauxAlcolemie -= 0.015 / 4; //L'alcool est ensuite métabolisé dans le foie à raison de environ 0.15 pour mille par heure
                if (tmpTauxAlcolemie < 0) {
                    tmpTauxAlcolemie = 0;
                }

                foreach (BoissonConsommee bc in BoissonsConsommees) {
                    if (bc.DtBoissonConsommee.Year == Current.Year && bc.DtBoissonConsommee.Month == Current.Month && bc.DtBoissonConsommee.Day == Current.Day && bc.DtBoissonConsommee.Hour == Current.Hour && bc.DtBoissonConsommee.Minute == Current.Minute && bc.DtBoissonConsommee.Second == Current.Second) {
                        tmpTauxAlcolemie += CalculTauxAlcool(bc.B.AlcoolBrute, Poids, EstHomme);
                    }
                }

                tmpGraph[i] = new Point(((largeur * i) / 192) + pointDeDepart.X, hauteur - (((int)((tmpTauxAlcolemie / 0.25) * hauteur)) + pointDeDepart.Y));
            }

            return tmpGraph;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="q">quantité d'alcool consommée (en g)</param>
        /// <param name="m">masse corporelle du consommateur (en Kg)</param>
        /// <param name="estHomme"></param>
        /// <returns></returns>
        public double CalculTauxAlcool(double q, double m, bool estHomme) {
            double K = (estHomme ? 0.7 : 0.6);
            return q / (m * K);
        }
    }
}
