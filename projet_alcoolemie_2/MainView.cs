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
    public partial class MainView : Form {

        ModelPA myModelIPA;
        public ModelPA MyModelIPA {
            get {
                return myModelIPA;
            }

            set {
                myModelIPA = value;
            }
        }


        public MainView() {
            InitializeComponent();

            MyModelIPA = new ModelPA(this);
        }

        private void button1_Click(object sender, EventArgs e) {
            MyModelIPA.ShowGraphView();
        }
    }
}
