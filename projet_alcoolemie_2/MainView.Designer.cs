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
            this.button1 = new System.Windows.Forms.Button();
            this.cbxBoissons = new System.Windows.Forms.ComboBox();
            this.timPkrBoissons = new System.Windows.Forms.DateTimePicker();
            this.nudNbBoissons = new System.Windows.Forms.NumericUpDown();
            this.btnAjouterBoisson = new System.Windows.Forms.Button();
            this.lbxConso = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbBoissons)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.timPkrBoissons.Location = new System.Drawing.Point(128, 49);
            this.timPkrBoissons.Name = "timPkrBoissons";
            this.timPkrBoissons.ShowUpDown = true;
            this.timPkrBoissons.Size = new System.Drawing.Size(49, 20);
            this.timPkrBoissons.TabIndex = 2;
            // 
            // nudNbBoissons
            // 
            this.nudNbBoissons.Location = new System.Drawing.Point(183, 50);
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
            this.lbxConso.Location = new System.Drawing.Point(779, 56);
            this.lbxConso.Name = "lbxConso";
            this.lbxConso.Size = new System.Drawing.Size(193, 355);
            this.lbxConso.TabIndex = 5;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.lbxConso);
            this.Controls.Add(this.btnAjouterBoisson);
            this.Controls.Add(this.nudNbBoissons);
            this.Controls.Add(this.timPkrBoissons);
            this.Controls.Add(this.cbxBoissons);
            this.Controls.Add(this.button1);
            this.Name = "MainView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNbBoissons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxBoissons;
        private System.Windows.Forms.DateTimePicker timPkrBoissons;
        private System.Windows.Forms.NumericUpDown nudNbBoissons;
        private System.Windows.Forms.Button btnAjouterBoisson;
        private System.Windows.Forms.ListBox lbxConso;
    }
}

