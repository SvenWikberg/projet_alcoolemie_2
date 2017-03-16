namespace projet_alcoolemie_2 {
    partial class MainView {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.btnGraph = new System.Windows.Forms.Button();
            this.cbxBoissons = new System.Windows.Forms.ComboBox();
            this.timPkrBoissons = new System.Windows.Forms.DateTimePicker();
            this.nudNbBoissons = new System.Windows.Forms.NumericUpDown();
            this.btnAjouterBoisson = new System.Windows.Forms.Button();
            this.lbxConso = new System.Windows.Forms.ListBox();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.cbxSexe = new System.Windows.Forms.ComboBox();
            this.nudPoids = new System.Windows.Forms.NumericUpDown();
            this.lblKg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbBoissons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoids)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(0, 436);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(302, 37);
            this.btnGraph.TabIndex = 0;
            this.btnGraph.Text = "Voir le graphique";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxBoissons
            // 
            this.cbxBoissons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBoissons.FormattingEnabled = true;
            this.cbxBoissons.Location = new System.Drawing.Point(1, 52);
            this.cbxBoissons.Name = "cbxBoissons";
            this.cbxBoissons.Size = new System.Drawing.Size(121, 21);
            this.cbxBoissons.TabIndex = 1;
            // 
            // timPkrBoissons
            // 
            this.timPkrBoissons.Location = new System.Drawing.Point(128, 52);
            this.timPkrBoissons.Name = "timPkrBoissons";
            this.timPkrBoissons.ShowUpDown = true;
            this.timPkrBoissons.Size = new System.Drawing.Size(49, 20);
            this.timPkrBoissons.TabIndex = 2;
            // 
            // nudNbBoissons
            // 
            this.nudNbBoissons.Location = new System.Drawing.Point(183, 52);
            this.nudNbBoissons.Name = "nudNbBoissons";
            this.nudNbBoissons.Size = new System.Drawing.Size(38, 20);
            this.nudNbBoissons.TabIndex = 3;
            this.nudNbBoissons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAjouterBoisson
            // 
            this.btnAjouterBoisson.Location = new System.Drawing.Point(227, 50);
            this.btnAjouterBoisson.Name = "btnAjouterBoisson";
            this.btnAjouterBoisson.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterBoisson.TabIndex = 4;
            this.btnAjouterBoisson.Text = "Ajouter";
            this.btnAjouterBoisson.UseVisualStyleBackColor = true;
            this.btnAjouterBoisson.Click += new System.EventHandler(this.btnAjouterBoisson_Click);
            // 
            // lbxConso
            // 
            this.lbxConso.FormattingEnabled = true;
            this.lbxConso.Location = new System.Drawing.Point(1, 79);
            this.lbxConso.Name = "lbxConso";
            this.lbxConso.Size = new System.Drawing.Size(301, 355);
            this.lbxConso.TabIndex = 5;
            this.lbxConso.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxConso_MouseDoubleClick);
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(1, 13);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(37, 13);
            this.lblSexe.TabIndex = 6;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(141, 13);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(39, 13);
            this.lblPoids.TabIndex = 7;
            this.lblPoids.Text = "Poids :";
            // 
            // cbxSexe
            // 
            this.cbxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexe.FormattingEnabled = true;
            this.cbxSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbxSexe.Location = new System.Drawing.Point(45, 13);
            this.cbxSexe.Name = "cbxSexe";
            this.cbxSexe.Size = new System.Drawing.Size(90, 21);
            this.cbxSexe.TabIndex = 8;
            // 
            // nudPoids
            // 
            this.nudPoids.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPoids.Location = new System.Drawing.Point(183, 12);
            this.nudPoids.Name = "nudPoids";
            this.nudPoids.Size = new System.Drawing.Size(51, 20);
            this.nudPoids.TabIndex = 9;
            this.nudPoids.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(234, 16);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(19, 13);
            this.lblKg.TabIndex = 10;
            this.lblKg.Text = "kg";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 485);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.nudPoids);
            this.Controls.Add(this.cbxSexe);
            this.Controls.Add(this.lblPoids);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.lbxConso);
            this.Controls.Add(this.btnAjouterBoisson);
            this.Controls.Add(this.nudNbBoissons);
            this.Controls.Add(this.timPkrBoissons);
            this.Controls.Add(this.cbxBoissons);
            this.Controls.Add(this.btnGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainView";
            this.Text = "Calcul alcoolémie";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNbBoissons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoids)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.ComboBox cbxBoissons;
        private System.Windows.Forms.DateTimePicker timPkrBoissons;
        private System.Windows.Forms.NumericUpDown nudNbBoissons;
        private System.Windows.Forms.Button btnAjouterBoisson;
        private System.Windows.Forms.ListBox lbxConso;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.ComboBox cbxSexe;
        private System.Windows.Forms.NumericUpDown nudPoids;
        private System.Windows.Forms.Label lblKg;
    }
}

