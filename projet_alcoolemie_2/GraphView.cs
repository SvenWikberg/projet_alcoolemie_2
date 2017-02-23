using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_alcoolemie_2 {
    public partial class GraphView : Form {
        ModelPA _monModelPA;
        public ModelPA MonModelPA {
            get {
                return _monModelPA;
            }

            set {
                _monModelPA = value;
            }
        }

        public GraphView(ModelPA monMondePA) {
            InitializeComponent();

            MonModelPA = monMondePA;
        }
    }
}
