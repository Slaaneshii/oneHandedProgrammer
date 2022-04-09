namespace oneHandedProgrammer
{
    partial class FrmDebug
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
            this.btnSendInput = new System.Windows.Forms.Button();
            this.tbxVoice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendInput
            // 
            this.btnSendInput.Location = new System.Drawing.Point(12, 12);
            this.btnSendInput.Name = "btnSendInput";
            this.btnSendInput.Size = new System.Drawing.Size(107, 54);
            this.btnSendInput.TabIndex = 0;
            this.btnSendInput.Text = "sendInput";
            this.btnSendInput.UseVisualStyleBackColor = true;
            this.btnSendInput.Click += new System.EventHandler(this.btnSendInput_Click);
            // 
            // tbxVoice
            // 
            this.tbxVoice.Location = new System.Drawing.Point(125, 12);
            this.tbxVoice.Multiline = true;
            this.tbxVoice.Name = "tbxVoice";
            this.tbxVoice.Size = new System.Drawing.Size(406, 205);
            this.tbxVoice.TabIndex = 1;
            // 
            // FrmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxVoice);
            this.Controls.Add(this.btnSendInput);
            this.Name = "FrmDebug";
            this.Text = "FrmDebug";
            this.Load += new System.EventHandler(this.FrmDebug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendInput;
        private System.Windows.Forms.TextBox tbxVoice;
    }
}