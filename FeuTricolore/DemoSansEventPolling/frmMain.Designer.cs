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
            this.pbxFeuTricolore = new System.Windows.Forms.PictureBox();
            this.pbxVoiture = new System.Windows.Forms.PictureBox();
            this.chkGo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFeuTricolore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFeuTricolore
            // 
            this.pbxFeuTricolore.Location = new System.Drawing.Point(27, 93);
            this.pbxFeuTricolore.Name = "pbxFeuTricolore";
            this.pbxFeuTricolore.Size = new System.Drawing.Size(100, 235);
            this.pbxFeuTricolore.TabIndex = 1;
            this.pbxFeuTricolore.TabStop = false;
            // 
            // pbxVoiture
            // 
            this.pbxVoiture.Image = global::EventFeuTricolore.Properties.Resources.voiture;
            this.pbxVoiture.Location = new System.Drawing.Point(170, 93);
            this.pbxVoiture.Name = "pbxVoiture";
            this.pbxVoiture.Size = new System.Drawing.Size(77, 72);
            this.pbxVoiture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxVoiture.TabIndex = 3;
            this.pbxVoiture.TabStop = false;
            // 
            // chkGo
            // 
            this.chkGo.AutoSize = true;
            this.chkGo.Location = new System.Drawing.Point(27, 49);
            this.chkGo.Name = "chkGo";
            this.chkGo.Size = new System.Drawing.Size(40, 17);
            this.chkGo.TabIndex = 11;
            this.chkGo.Text = "Go";
            this.chkGo.UseVisualStyleBackColor = true;
            this.chkGo.CheckedChanged += new System.EventHandler(this.chkGo_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.Controls.Add(this.chkGo);
            this.Controls.Add(this.pbxVoiture);
            this.Controls.Add(this.pbxFeuTricolore);
            this.Name = "frmMain";
            this.Text = "Event Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFeuTricolore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxFeuTricolore;
        private System.Windows.Forms.PictureBox pbxVoiture;
        private System.Windows.Forms.CheckBox chkGo;
    }
}

