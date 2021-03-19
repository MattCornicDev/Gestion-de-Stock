
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelEmplacement = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.textBoxFrs = new System.Windows.Forms.TextBox();
            this.labelFRS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRefSte
            // 
            this.textBoxRefSte.Location = new System.Drawing.Point(306, 118);
            this.textBoxRefSte.Name = "textBoxRefSte";
            this.textBoxRefSte.Size = new System.Drawing.Size(301, 31);
            this.textBoxRefSte.TabIndex = 0;
            // 
            // textBoxRefFrs
            // 
            this.textBoxRefFrs.Location = new System.Drawing.Point(306, 210);
            this.textBoxRefFrs.Name = "textBoxRefFrs";
            this.textBoxRefFrs.Size = new System.Drawing.Size(301, 31);
            this.textBoxRefFrs.TabIndex = 1;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(306, 301);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(301, 31);
            this.textBoxNom.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(306, 408);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(301, 31);
            this.textBoxDescription.TabIndex = 3;
            // 
            // textBoxEmplacement
            // 
            this.textBoxEmplacement.Location = new System.Drawing.Point(306, 523);
            this.textBoxEmplacement.Name = "textBoxEmplacement";
            this.textBoxEmplacement.Size = new System.Drawing.Size(301, 31);
            this.textBoxEmplacement.TabIndex = 4;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(248, 744);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(301, 31);
            this.textBoxQuantite.TabIndex = 5;
            // 
            // labelRefSte
            // 
            this.labelRefSte.AutoSize = true;
            this.labelRefSte.Location = new System.Drawing.Point(123, 121);
            this.labelRefSte.Name = "labelRefSte";
            this.labelRefSte.Size = new System.Drawing.Size(92, 25);
            this.labelRefSte.TabIndex = 6;
            this.labelRefSte.Text = "Ref STE";
            // 
            // labelRefFrs
            // 
            this.labelRefFrs.AutoSize = true;
            this.labelRefFrs.Location = new System.Drawing.Point(135, 231);
            this.labelRefFrs.Name = "labelRefFrs";
            this.labelRefFrs.Size = new System.Drawing.Size(93, 25);
            this.labelRefFrs.TabIndex = 7;
            this.labelRefFrs.Text = "Ref FRS";
            this.labelRefFrs.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(159, 307);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(56, 25);
            this.labelNom.TabIndex = 8;
            this.labelNom.Text = "Nom";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(108, 414);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 25);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description";
            // 
            // labelEmplacement
            // 
            this.labelEmplacement.AutoSize = true;
            this.labelEmplacement.Location = new System.Drawing.Point(97, 529);
            this.labelEmplacement.Name = "labelEmplacement";
            this.labelEmplacement.Size = new System.Drawing.Size(142, 25);
            this.labelEmplacement.TabIndex = 10;
            this.labelEmplacement.Text = "Emplacement";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(97, 744);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(93, 25);
            this.labelQuantite.TabIndex = 11;
            this.labelQuantite.Text = "Quantité";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(232, 657);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(47, 25);
            this.labelMin.TabIndex = 12;
            this.labelMin.Text = "Min";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(326, 657);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(143, 31);
            this.textBoxMin.TabIndex = 13;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(607, 651);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(139, 31);
            this.textBoxMax.TabIndex = 14;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(522, 660);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(53, 25);
            this.labelMax.TabIndex = 15;
            this.labelMax.Text = "Max";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(97, 654);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(66, 25);
            this.labelStock.TabIndex = 16;
            this.labelStock.Text = "Stock";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(306, 887);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(163, 49);
            this.buttonAjouter.TabIndex = 17;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(583, 887);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(163, 49);
            this.buttonAnnuler.TabIndex = 18;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(849, 887);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(163, 49);
            this.buttonQuitter.TabIndex = 19;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            // 
            // textBoxFrs
            // 
            this.textBoxFrs.Location = new System.Drawing.Point(1077, 117);
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
            this.labelFRS.Location = new System.Drawing.Point(995, 124);
            this.labelFRS.Name = "labelFRS";
            this.labelFRS.Size = new System.Drawing.Size(54, 25);
            this.labelFRS.TabIndex = 21;
            this.labelFRS.Text = "FRS";
            // 
            // GestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 1016);
            this.Controls.Add(this.labelFRS);
            this.Controls.Add(this.textBoxFrs);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.labelEmplacement);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelRefFrs);
            this.Controls.Add(this.labelRefSte);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.textBoxEmplacement);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxRefFrs);
            this.Controls.Add(this.textBoxRefSte);
            this.Name = "GestionStock";
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
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelEmplacement;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.TextBox textBoxFrs;
        private System.Windows.Forms.Label labelFRS;
    }
}

