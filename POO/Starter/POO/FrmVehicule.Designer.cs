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
            this.cbxTypeVehicule.Location = new System.Drawing.Point(20, 20);
            this.cbxTypeVehicule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTypeVehicule.Name = "cbxTypeVehicule";
            this.cbxTypeVehicule.Size = new System.Drawing.Size(180, 28);
            this.cbxTypeVehicule.TabIndex = 0;
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(20, 78);
            this.btnCreation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(182, 35);
            this.btnCreation.TabIndex = 1;
            this.btnCreation.Text = "Création";
            this.btnCreation.UseVisualStyleBackColor = true;
            // 
            // btnDestruction
            // 
            this.btnDestruction.Location = new System.Drawing.Point(20, 168);
            this.btnDestruction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDestruction.Name = "btnDestruction";
            this.btnDestruction.Size = new System.Drawing.Size(182, 35);
            this.btnDestruction.TabIndex = 2;
            this.btnDestruction.Text = "Destruction";
            this.btnDestruction.UseVisualStyleBackColor = true;
            // 
            // btnConsommation
            // 
            this.btnConsommation.Location = new System.Drawing.Point(18, 123);
            this.btnConsommation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsommation.Name = "btnConsommation";
            this.btnConsommation.Size = new System.Drawing.Size(182, 35);
            this.btnConsommation.TabIndex = 3;
            this.btnConsommation.Text = "Consommation";
            this.btnConsommation.UseVisualStyleBackColor = true;
            // 
            // gbxVehicule
            // 
            this.gbxVehicule.Controls.Add(this.label7);
            this.gbxVehicule.Controls.Add(this.txbConsommation);
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
            this.gbxVehicule.Location = new System.Drawing.Point(242, 2);
            this.gbxVehicule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxVehicule.Name = "gbxVehicule";
            this.gbxVehicule.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxVehicule.Size = new System.Drawing.Size(438, 289);
            this.gbxVehicule.TabIndex = 4;
            this.gbxVehicule.TabStop = false;
            this.gbxVehicule.Text = "Caractéristique du véhicule";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(52, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Consommation :";
            // 
            // txbConsommation
            // 
            this.txbConsommation.Location = new System.Drawing.Point(255, 247);
            this.txbConsommation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbConsommation.Name = "txbConsommation";
            this.txbConsommation.Size = new System.Drawing.Size(148, 26);
            this.txbConsommation.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Charge : ";
            // 
            // txbCharge
            // 
            this.txbCharge.Location = new System.Drawing.Point(255, 211);
            this.txbCharge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCharge.Name = "txbCharge";
            this.txbCharge.Size = new System.Drawing.Size(148, 26);
            this.txbCharge.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Passager(s) :";
            // 
            // txbPassagers
            // 
            this.txbPassagers.Location = new System.Drawing.Point(255, 171);
            this.txbPassagers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPassagers.Name = "txbPassagers";
            this.txbPassagers.Size = new System.Drawing.Size(148, 26);
            this.txbPassagers.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vitesse minimum  : ";
            // 
            // txbVitesseMini
            // 
            this.txbVitesseMini.Location = new System.Drawing.Point(255, 126);
            this.txbVitesseMini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbVitesseMini.Name = "txbVitesseMini";
            this.txbVitesseMini.Size = new System.Drawing.Size(148, 26);
            this.txbVitesseMini.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vitesse maximum  : ";
            // 
            // txbVitesseMaxi
            // 
            this.txbVitesseMaxi.Location = new System.Drawing.Point(255, 86);
            this.txbVitesseMaxi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbVitesseMaxi.Name = "txbVitesseMaxi";
            this.txbVitesseMaxi.Size = new System.Drawing.Size(148, 26);
            this.txbVitesseMaxi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance :";
            // 
            // txbDistance
            // 
            this.txbDistance.Location = new System.Drawing.Point(255, 46);
            this.txbDistance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbDistance.Name = "txbDistance";
            this.txbDistance.Size = new System.Drawing.Size(148, 26);
            this.txbDistance.TabIndex = 0;
            // 
            // FrmVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 323);
            this.Controls.Add(this.gbxVehicule);
            this.Controls.Add(this.btnConsommation);
            this.Controls.Add(this.btnDestruction);
            this.Controls.Add(this.btnCreation);
            this.Controls.Add(this.cbxTypeVehicule);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

