namespace EventFeuTricolore
{
    partial class frmMain
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
            this.chkGo = new System.Windows.Forms.CheckBox();
            this.pbxVoiture = new System.Windows.Forms.PictureBox();
            this.pbxFeuTricolore = new System.Windows.Forms.PictureBox();
            this.pbxCircuit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVoiture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFeuTricolore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCircuit)).BeginInit();
            this.SuspendLayout();
            // 
            // chkGo
            // 
            this.chkGo.AutoSize = true;
            this.chkGo.Location = new System.Drawing.Point(40, 75);
            this.chkGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkGo.Name = "chkGo";
            this.chkGo.Size = new System.Drawing.Size(57, 24);
            this.chkGo.TabIndex = 11;
            this.chkGo.Text = "Go";
            this.chkGo.UseVisualStyleBackColor = true;
            // 
            // pbxVoiture
            // 
            this.pbxVoiture.BackColor = System.Drawing.Color.Transparent;
            this.pbxVoiture.Image = global::EventFeuTricolore.Properties.Resources.voiture;
            this.pbxVoiture.Location = new System.Drawing.Point(323, 116);
            this.pbxVoiture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxVoiture.Name = "pbxVoiture";
            this.pbxVoiture.Size = new System.Drawing.Size(77, 72);
            this.pbxVoiture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVoiture.TabIndex = 3;
            this.pbxVoiture.TabStop = false;
            // 
            // pbxFeuTricolore
            // 
            this.pbxFeuTricolore.Location = new System.Drawing.Point(40, 131);
            this.pbxFeuTricolore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxFeuTricolore.Name = "pbxFeuTricolore";
            this.pbxFeuTricolore.Size = new System.Drawing.Size(150, 362);
            this.pbxFeuTricolore.TabIndex = 1;
            this.pbxFeuTricolore.TabStop = false;
            // 
            // pbxCircuit
            // 
            this.pbxCircuit.Image = global::EventFeuTricolore.Properties.Resources.Circuit;
            this.pbxCircuit.Location = new System.Drawing.Point(250, 63);
            this.pbxCircuit.Name = "pbxCircuit";
            this.pbxCircuit.Size = new System.Drawing.Size(614, 428);
            this.pbxCircuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCircuit.TabIndex = 12;
            this.pbxCircuit.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(889, 518);
            this.Controls.Add(this.chkGo);
            this.Controls.Add(this.pbxVoiture);
            this.Controls.Add(this.pbxFeuTricolore);
            this.Controls.Add(this.pbxCircuit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Event Example";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVoiture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFeuTricolore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCircuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxFeuTricolore;
        private System.Windows.Forms.PictureBox pbxVoiture;
        private System.Windows.Forms.CheckBox chkGo;
        private System.Windows.Forms.PictureBox pbxCircuit;
    }
}

