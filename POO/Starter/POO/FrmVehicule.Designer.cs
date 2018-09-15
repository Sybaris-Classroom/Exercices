namespace POO
{
    partial class FrmVehicule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxTypeVehicule = new System.Windows.Forms.ComboBox();
            this.btnCreation = new System.Windows.Forms.Button();
            this.btnDestruction = new System.Windows.Forms.Button();
            this.btnConsommation = new System.Windows.Forms.Button();
            this.gbxVehicule = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbConsommation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbConsoRef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCharge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPassagers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbVitesseMini = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbVitesseMaxi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDistance = new System.Windows.Forms.TextBox();
            this.gbxVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxTypeVehicule
            // 
            this.cbxTypeVehicule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeVehicule.FormattingEnabled = true;
            this.cbxTypeVehicule.Items.AddRange(new object[] {
            "Voiture",
            "Camion",
            "Moto"});
            this.cbxTypeVehicule.Location = new System.Drawing.Point(13, 13);
            this.cbxTypeVehicule.Name = "cbxTypeVehicule";
            this.cbxTypeVehicule.Size = new System.Drawing.Size(121, 21);
            this.cbxTypeVehicule.TabIndex = 0;
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(13, 51);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(121, 23);
            this.btnCreation.TabIndex = 1;
            this.btnCreation.Text = "Création";
            this.btnCreation.UseVisualStyleBackColor = true;
            // 
            // btnDestruction
            // 
            this.btnDestruction.Location = new System.Drawing.Point(13, 109);
            this.btnDestruction.Name = "btnDestruction";
            this.btnDestruction.Size = new System.Drawing.Size(121, 23);
            this.btnDestruction.TabIndex = 2;
            this.btnDestruction.Text = "Destruction";
            this.btnDestruction.UseVisualStyleBackColor = true;
            // 
            // btnConsommation
            // 
            this.btnConsommation.Location = new System.Drawing.Point(12, 80);
            this.btnConsommation.Name = "btnConsommation";
            this.btnConsommation.Size = new System.Drawing.Size(121, 23);
            this.btnConsommation.TabIndex = 3;
            this.btnConsommation.Text = "Consommation";
            this.btnConsommation.UseVisualStyleBackColor = true;
            // 
            // gbxVehicule
            // 
            this.gbxVehicule.Controls.Add(this.label7);
            this.gbxVehicule.Controls.Add(this.txbConsommation);
            this.gbxVehicule.Controls.Add(this.label6);
            this.gbxVehicule.Controls.Add(this.txbConsoRef);
            this.gbxVehicule.Controls.Add(this.label5);
            this.gbxVehicule.Controls.Add(this.txbCharge);
            this.gbxVehicule.Controls.Add(this.label4);
            this.gbxVehicule.Controls.Add(this.txbPassagers);
            this.gbxVehicule.Controls.Add(this.label3);
            this.gbxVehicule.Controls.Add(this.txbVitesseMini);
            this.gbxVehicule.Controls.Add(this.label2);
            this.gbxVehicule.Controls.Add(this.txbVitesseMaxi);
            this.gbxVehicule.Controls.Add(this.label1);
            this.gbxVehicule.Controls.Add(this.txbDistance);
            this.gbxVehicule.Location = new System.Drawing.Point(161, 1);
            this.gbxVehicule.Name = "gbxVehicule";
            this.gbxVehicule.Size = new System.Drawing.Size(292, 226);
            this.gbxVehicule.TabIndex = 4;
            this.gbxVehicule.TabStop = false;
            this.gbxVehicule.Text = "Caractéristique du véhicule";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(35, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Consommation :";
            // 
            // txbConsommation
            // 
            this.txbConsommation.Location = new System.Drawing.Point(170, 189);
            this.txbConsommation.Name = "txbConsommation";
            this.txbConsommation.Size = new System.Drawing.Size(100, 20);
            this.txbConsommation.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Consommation de réf :";
            // 
            // txbConsoRef
            // 
            this.txbConsoRef.Location = new System.Drawing.Point(170, 163);
            this.txbConsoRef.Name = "txbConsoRef";
            this.txbConsoRef.Size = new System.Drawing.Size(100, 20);
            this.txbConsoRef.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Charge : ";
            // 
            // txbCharge
            // 
            this.txbCharge.Location = new System.Drawing.Point(170, 137);
            this.txbCharge.Name = "txbCharge";
            this.txbCharge.Size = new System.Drawing.Size(100, 20);
            this.txbCharge.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Passager(s) :";
            // 
            // txbPassagers
            // 
            this.txbPassagers.Location = new System.Drawing.Point(170, 111);
            this.txbPassagers.Name = "txbPassagers";
            this.txbPassagers.Size = new System.Drawing.Size(100, 20);
            this.txbPassagers.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vitesse minimum  : ";
            // 
            // txbVitesseMini
            // 
            this.txbVitesseMini.Location = new System.Drawing.Point(170, 82);
            this.txbVitesseMini.Name = "txbVitesseMini";
            this.txbVitesseMini.Size = new System.Drawing.Size(100, 20);
            this.txbVitesseMini.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vitesse maximum  : ";
            // 
            // txbVitesseMaxi
            // 
            this.txbVitesseMaxi.Location = new System.Drawing.Point(170, 56);
            this.txbVitesseMaxi.Name = "txbVitesseMaxi";
            this.txbVitesseMaxi.Size = new System.Drawing.Size(100, 20);
            this.txbVitesseMaxi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance :";
            // 
            // txbDistance
            // 
            this.txbDistance.Location = new System.Drawing.Point(170, 30);
            this.txbDistance.Name = "txbDistance";
            this.txbDistance.Size = new System.Drawing.Size(100, 20);
            this.txbDistance.TabIndex = 0;
            // 
            // FrmVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 261);
            this.Controls.Add(this.gbxVehicule);
            this.Controls.Add(this.btnConsommation);
            this.Controls.Add(this.btnDestruction);
            this.Controls.Add(this.btnCreation);
            this.Controls.Add(this.cbxTypeVehicule);
            this.Name = "FrmVehicule";
            this.Text = "Vehicule POO";
            this.Load += new System.EventHandler(this.FrmVehicule_Load);
            this.gbxVehicule.ResumeLayout(false);
            this.gbxVehicule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTypeVehicule;
        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.Button btnDestruction;
        private System.Windows.Forms.Button btnConsommation;
        private System.Windows.Forms.GroupBox gbxVehicule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbConsommation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbConsoRef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCharge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPassagers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbVitesseMini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbVitesseMaxi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDistance;
    }
}

