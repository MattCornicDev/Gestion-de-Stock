
namespace GestionDeStock
{
    partial class GestionStock
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxRefSte = new System.Windows.Forms.TextBox();
            this.textBoxRefFrs = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxEmplacement = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.labelRefSte = new System.Windows.Forms.Label();
            this.labelRefFrs = new System.Windows.Forms.Label();
            this.labelNomArticle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelEmplacement = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelStockMin = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelStockMax = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.textBoxFrs = new System.Windows.Forms.TextBox();
            this.labelFRS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRefSte
            // 
            this.textBoxRefSte.Location = new System.Drawing.Point(885, 112);
            this.textBoxRefSte.Name = "textBoxRefSte";
            this.textBoxRefSte.Size = new System.Drawing.Size(301, 31);
            this.textBoxRefSte.TabIndex = 0;
            // 
            // textBoxRefFrs
            // 
            this.textBoxRefFrs.Location = new System.Drawing.Point(321, 115);
            this.textBoxRefFrs.Name = "textBoxRefFrs";
            this.textBoxRefFrs.Size = new System.Drawing.Size(301, 31);
            this.textBoxRefFrs.TabIndex = 1;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(321, 219);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(301, 31);
            this.textBoxNom.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(321, 431);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(301, 31);
            this.textBoxDescription.TabIndex = 3;
            // 
            // textBoxEmplacement
            // 
            this.textBoxEmplacement.Location = new System.Drawing.Point(321, 321);
            this.textBoxEmplacement.Name = "textBoxEmplacement";
            this.textBoxEmplacement.Size = new System.Drawing.Size(301, 31);
            this.textBoxEmplacement.TabIndex = 4;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(885, 431);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(301, 31);
            this.textBoxQuantite.TabIndex = 5;
            // 
            // labelRefSte
            // 
            this.labelRefSte.AutoSize = true;
            this.labelRefSte.Location = new System.Drawing.Point(678, 112);
            this.labelRefSte.Name = "labelRefSte";
            this.labelRefSte.Size = new System.Drawing.Size(189, 25);
            this.labelRefSte.TabIndex = 6;
            this.labelRefSte.Text = "Référence Société";
            // 
            // labelRefFrs
            // 
            this.labelRefFrs.AutoSize = true;
            this.labelRefFrs.Location = new System.Drawing.Point(54, 115);
            this.labelRefFrs.Name = "labelRefFrs";
            this.labelRefFrs.Size = new System.Drawing.Size(231, 25);
            this.labelRefFrs.TabIndex = 7;
            this.labelRefFrs.Text = "Référence Fournisseur";
            // 
            // labelNomArticle
            // 
            this.labelNomArticle.AutoSize = true;
            this.labelNomArticle.Location = new System.Drawing.Point(163, 228);
            this.labelNomArticle.Name = "labelNomArticle";
            this.labelNomArticle.Size = new System.Drawing.Size(122, 25);
            this.labelNomArticle.TabIndex = 8;
            this.labelNomArticle.Text = "Nom Article";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(163, 431);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 25);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description";
            // 
            // labelEmplacement
            // 
            this.labelEmplacement.AutoSize = true;
            this.labelEmplacement.Location = new System.Drawing.Point(143, 327);
            this.labelEmplacement.Name = "labelEmplacement";
            this.labelEmplacement.Size = new System.Drawing.Size(142, 25);
            this.labelEmplacement.TabIndex = 10;
            this.labelEmplacement.Text = "Emplacement";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(669, 437);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(198, 25);
            this.labelQuantite.TabIndex = 11;
            this.labelQuantite.Text = "Quantité d\'article(s)";
            // 
            // labelStockMin
            // 
            this.labelStockMin.AutoSize = true;
            this.labelStockMin.Location = new System.Drawing.Point(709, 228);
            this.labelStockMin.Name = "labelStockMin";
            this.labelStockMin.Size = new System.Drawing.Size(158, 25);
            this.labelStockMin.TabIndex = 12;
            this.labelStockMin.Text = "Stock Minimum";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(885, 219);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(143, 31);
            this.textBoxMin.TabIndex = 13;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(885, 324);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(139, 31);
            this.textBoxMax.TabIndex = 14;
            // 
            // labelStockMax
            // 
            this.labelStockMax.AutoSize = true;
            this.labelStockMax.Location = new System.Drawing.Point(703, 327);
            this.labelStockMax.Name = "labelStockMax";
            this.labelStockMax.Size = new System.Drawing.Size(164, 25);
            this.labelStockMax.TabIndex = 15;
            this.labelStockMax.Text = "Stock Maximum";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(284, 594);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(163, 49);
            this.buttonAjouter.TabIndex = 17;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(609, 594);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(163, 49);
            this.buttonAnnuler.TabIndex = 18;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(908, 594);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(163, 49);
            this.buttonQuitter.TabIndex = 19;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            // 
            // textBoxFrs
            // 
            this.textBoxFrs.Location = new System.Drawing.Point(1413, 91);
            this.textBoxFrs.Multiline = true;
            this.textBoxFrs.Name = "textBoxFrs";
            this.textBoxFrs.ReadOnly = true;
            this.textBoxFrs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFrs.Size = new System.Drawing.Size(164, 31);
            this.textBoxFrs.TabIndex = 20;
            // 
            // labelFRS
            // 
            this.labelFRS.AutoSize = true;
            this.labelFRS.Location = new System.Drawing.Point(1316, 91);
            this.labelFRS.Name = "labelFRS";
            this.labelFRS.Size = new System.Drawing.Size(54, 25);
            this.labelFRS.TabIndex = 21;
            this.labelFRS.Text = "FRS";
            // 
            // GestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 773);
            this.Controls.Add(this.labelFRS);
            this.Controls.Add(this.textBoxFrs);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelStockMax);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.labelStockMin);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.labelEmplacement);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelNomArticle);
            this.Controls.Add(this.labelRefFrs);
            this.Controls.Add(this.labelRefSte);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.textBoxEmplacement);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxRefFrs);
            this.Controls.Add(this.textBoxRefSte);
            this.Name = "GestionStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRefSte;
        private System.Windows.Forms.TextBox textBoxRefFrs;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxEmplacement;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Label labelRefSte;
        private System.Windows.Forms.Label labelRefFrs;
        private System.Windows.Forms.Label labelNomArticle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelEmplacement;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelStockMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelStockMax;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.TextBox textBoxFrs;
        private System.Windows.Forms.Label labelFRS;
    }
}

