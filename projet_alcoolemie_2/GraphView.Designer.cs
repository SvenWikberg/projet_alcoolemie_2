﻿namespace projet_alcoolemie_2 {
    partial class GraphView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // GraphView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 462);
            this.MaximumSize = new System.Drawing.Size(1500, 500);
            this.MinimumSize = new System.Drawing.Size(1500, 500);
            this.Name = "GraphView";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphView_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}