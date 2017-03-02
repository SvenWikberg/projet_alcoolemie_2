using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_alcoolemie_2 {
    public class Boisson {
        // Nom de la boisson
        private string _nom;
        public string Nom {
            get {
                return _nom;
            }

            set {
                _nom = value;
            }
        }

        // Quantité en ml de la boisson
        private double _quantite;
        public double Quantite {
            get {
                return _quantite;
            }

            set {
                _quantite = value;
            }
        }

        // Degré d'alcool dans la boisson
        private double _degre;
        /// <summary>
        /// Retourne une valeur en 0 et 100
        /// </summary>
        public double Degre {
            get {
                return _degre;
            }

            set {
                if (value > 100) {
                    value = 100;
                }
                else {
                    if (value < 0) {
                        value = 0;
                    }
                }
                _degre = value;
            }
        }

        // Quantité d'alcool dans la boisson, en gramme
        public double AlcoolBrute {
            get {
                //0.8 est car 1L d'alcool pur pèse 0.8kg
                return ((Degre * Quantite) / 1000) * 0.8;
            }
        }

        // temps, en seconde, pour que l'utilisateur redeviennent sobre apres avoir bu cette boisson
        private int _tempsDElimination;
        public int TempsDElimination {
            get {
                return _tempsDElimination;
            }

            set {
                _tempsDElimination = value;
            }
        }


        public Boisson(string nom, double quantite, double degre) {
            Nom = nom;
            Quantite = quantite;
            Degre = degre;
            TempsDElimination = 0;
        }

        public void CalculTempsDElimination(int poids, bool estHomme) {
            double tauxDAlcoolemieTemp = 0;

            tauxDAlcoolemieTemp = AlcoolBrute / (poids * (estHomme ? 0.7 : 0.6));
        }
    }
}
