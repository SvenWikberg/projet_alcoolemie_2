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
        const int GRAPH_LOCATION_X = 10;
        const int GRAPH_LOCATION_Y = 10;
        const int NB_LIGNE_HORI = 24;
        const int NB_LIGNE_VERTI = 10;
        const double TAUX_ALCOOL_MAX_GRAPH = 0.25;
        const double TAUX_ALCOOL_MAX_CONDUITE = 0.05;

        ModelPA _monModelPA;
        public ModelPA MonModelPA {
            get {
                return _monModelPA;
            }

            set {
                _monModelPA = value;
            }
        }

        public GraphView(ModelPA monModelPA) {
            InitializeComponent();

            MonModelPA = monModelPA;
        }

        private void GraphView_Paint(object sender, PaintEventArgs e) {
            Point[] tblPt = MonModelPA.CalculerGraphique(e.ClipRectangle.Width, e.ClipRectangle.Height, new Point(GRAPH_LOCATION_X, GRAPH_LOCATION_Y));
            Label[] tblLblHori = new Label[NB_LIGNE_HORI];
            Label[] tblLblVerti = new Label[NB_LIGNE_VERTI];
            DateTime tmpDt = DateTime.Now;
            tmpDt = tmpDt.AddMinutes(-tmpDt.Minute % 15);

            for (int i = 0; i < tblPt.Length; i++) {

                if (i % 8 == 0) {
                    if (i == tblPt.Length / 2) {
                        e.Graphics.DrawLine(Pens.Blue, new Point(GRAPH_LOCATION_X + (i / 8) * e.ClipRectangle.Width / NB_LIGNE_HORI, e.ClipRectangle.Y), new Point(GRAPH_LOCATION_X + (i / 8) * e.ClipRectangle.Width / NB_LIGNE_HORI, e.ClipRectangle.Height));
                    }

                    tblLblHori[i / 8] = new Label();
                    tblLblHori[i / 8].Size = new Size(35, 13);
                    tblLblHori[i / 8].Text = String.Format("{0:D2}:{1:D2}", tmpDt.Hour, tmpDt.Minute);
                    tblLblHori[i / 8].Font = new Font("Arial", 7);
                    tblLblHori[i / 8].Location = new Point((GRAPH_LOCATION_X + (i / 8) * e.ClipRectangle.Width / NB_LIGNE_HORI) - tblLblHori[i / 8].Width / 2, GRAPH_LOCATION_Y / 2);
                    tblLblHori[i / 8].Parent = this;
                }
                tmpDt = tmpDt.AddMinutes(15);
            }

            for (int i = 0; i < 10; i++) {
                e.Graphics.DrawLine(Pens.LightGray, new Point(e.ClipRectangle.X, e.ClipRectangle.Height - (((e.ClipRectangle.Height - GRAPH_LOCATION_Y) * i) / NB_LIGNE_VERTI) - GRAPH_LOCATION_Y), new Point(e.ClipRectangle.Width, e.ClipRectangle.Height - (((e.ClipRectangle.Height - GRAPH_LOCATION_Y) * i) / NB_LIGNE_VERTI) - GRAPH_LOCATION_Y));

                tblLblVerti[i] = new Label();
                tblLblVerti[i].Size = new Size(45, 13);
                tblLblVerti[i].Text = String.Format("{0:0.000}%", i * TAUX_ALCOOL_MAX_GRAPH / NB_LIGNE_VERTI);
                tblLblVerti[i].Font = new Font("Arial", 7);
                tblLblVerti[i].Location = new Point(0, (e.ClipRectangle.Height - (((e.ClipRectangle.Height - GRAPH_LOCATION_Y) * i) / NB_LIGNE_VERTI) - GRAPH_LOCATION_Y) - tblLblVerti[i].Height / 2);
                tblLblVerti[i].Parent = this;
            }

            e.Graphics.DrawLines(Pens.Black, tblPt);

            e.Graphics.DrawLine(Pens.Red, new Point(e.ClipRectangle.X, e.ClipRectangle.Height - (int)(TAUX_ALCOOL_MAX_CONDUITE * (e.ClipRectangle.Height - GRAPH_LOCATION_Y) / TAUX_ALCOOL_MAX_GRAPH) - GRAPH_LOCATION_Y), new Point(e.ClipRectangle.Width, e.ClipRectangle.Height - (int)(TAUX_ALCOOL_MAX_CONDUITE * (e.ClipRectangle.Height - GRAPH_LOCATION_Y) / TAUX_ALCOOL_MAX_GRAPH) - GRAPH_LOCATION_Y));
        }
    }
}
