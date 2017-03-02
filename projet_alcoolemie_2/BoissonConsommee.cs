using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_alcoolemie_2 {
    public class BoissonConsommee {
        //boiss qui a été consommé
        private Boisson _b;
        public Boisson B {
            get {
                return _b;
            }

            set {
                _b = value;
            }
        }

        //instant on l'utilisateur a bu la boisson
        private DateTime _dtBoissonConsommee;
        public DateTime DtBoissonConsommee {
            get {
                return _dtBoissonConsommee;
            }

            set {
                _dtBoissonConsommee = value;
            }
        }

        //instant ou l'alcool de la boisson n'a plus d'effet sur l'utilisateur
        private DateTime _dtFinEffetBoisson;
        public DateTime DtFinEffetBoisson {
            get {
                return _dtFinEffetBoisson;
            }

            set {
                _dtFinEffetBoisson = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="dtBoissonConsommee">instant on l'utilisateur a bu la boisson, au quart d'heure près, sans les secondes</param>
        public BoissonConsommee(Boisson b, DateTime dtBoissonConsommee) {
            B = b;
            DtBoissonConsommee = dtBoissonConsommee;
            DtFinEffetBoisson = DtBoissonConsommee;
            DtFinEffetBoisson.AddSeconds(b.TempsDElimination);
        }
    }
}
