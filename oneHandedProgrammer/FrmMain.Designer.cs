namespace oneHandedProgrammer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tbxEntendu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxConverti = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbSlaanesh = new System.Windows.Forms.PictureBox();
            this.tbrTransparency = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlaanesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTransparency)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxEntendu
            // 
            this.tbxEntendu.Location = new System.Drawing.Point(12, 28);
            this.tbxEntendu.Name = "tbxEntendu";
            this.tbxEntendu.Size = new System.Drawing.Size(246, 20);
            this.tbxEntendu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entendu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Converti:";
            // 
            // tbxConverti
            // 
            this.tbxConverti.Location = new System.Drawing.Point(12, 96);
            this.tbxConverti.Name = "tbxConverti";
            this.tbxConverti.Size = new System.Drawing.Size(246, 20);
            this.tbxConverti.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 192);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(42, 43);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbSlaanesh
            // 
            this.pbSlaanesh.Image = global::oneHandedProgrammer.Properties.Resources.slaaneshPP;
            this.pbSlaanesh.Location = new System.Drawing.Point(-14, 241);
            this.pbSlaanesh.Name = "pbSlaanesh";
            this.pbSlaanesh.Size = new System.Drawing.Size(324, 303);
            this.pbSlaanesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlaanesh.TabIndex = 7;
            this.pbSlaanesh.TabStop = false;
            // 
            // tbrTransparency
            // 
            this.tbrTransparency.Location = new System.Drawing.Point(100, 206);
            this.tbrTransparency.Maximum = 100;
            this.tbrTransparency.Minimum = 10;
            this.tbrTransparency.Name = "tbrTransparency";
            this.tbrTransparency.Size = new System.Drawing.Size(191, 45);
            this.tbrTransparency.TabIndex = 8;
            this.tbrTransparency.TickFrequency = 5;
            this.tbrTransparency.Value = 100;
            this.tbrTransparency.Scroll += new System.EventHandler(this.tbrTransparency_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Transparency";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(291, 540);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbSlaanesh);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxConverti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxEntendu);
            this.Controls.Add(this.tbrTransparency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "One Handed Programmer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlaanesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTransparency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEntendu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxConverti;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pbSlaanesh;
        private System.Windows.Forms.TrackBar tbrTransparency;
        private System.Windows.Forms.Label label3;
    }
}

