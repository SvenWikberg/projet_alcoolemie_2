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
            MyModelIPA.Poids = (int)nudPoids.Value;
            MyModelIPA.EstHomme = (cbxSexe.SelectedIndex == 0 ? true : false);
            MyModelIPA.ShowGraphView();
        }

        private void MainView_Load(object sender, EventArgs e) {
            cbxBoissons.DataSource = MyModelIPA.Boissons;
            cbxBoissons.DisplayMember = "ToString";
            cbxBoissons.SelectedIndex = 0;
            cbxSexe.SelectedIndex = 0;
            timPkrBoissons.Format = DateTimePickerFormat.Custom;
            timPkrBoissons.CustomFormat = "HH:mm";
            UpdateView();
        }

        private void btnAjouterBoisson_Click(object sender, EventArgs e) {
            for (int i = 0; i < nudNbBoissons.Value; i++) {
                MyModelIPA.BoireUneBoisson(MyModelIPA.Boissons[cbxBoissons.SelectedIndex], new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timPkrBoissons.Value.Hour, timPkrBoissons.Value.Minute, 0));
            }
            UpdateView();
        }

        public void UpdateView() {
            lbxConso.DataSource = MyModelIPA.BoissonsConsommees.OrderBy(o => o.DtBoissonConsommee).ToArray();
            lbxConso.DisplayMember = "ToString";
        }

        private void lbxConso_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (lbxConso.Items.Count > 0) {
                BoissonConsommee bc = (BoissonConsommee)lbxConso.SelectedItem;
                MyModelIPA.BoissonsConsommees.Remove(bc);
                UpdateView();
            }
        }
    }
}
