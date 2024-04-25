namespace P120_UX_Automates.Vue
{
    partial class Payment
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
            this.lblResumeCommand = new System.Windows.Forms.Label();
            this.lblProced = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResumeCommand
            // 
            this.lblResumeCommand.AutoSize = true;
            this.lblResumeCommand.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumeCommand.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblResumeCommand.Location = new System.Drawing.Point(177, 48);
            this.lblResumeCommand.Name = "lblResumeCommand";
            this.lblResumeCommand.Size = new System.Drawing.Size(486, 55);
            this.lblResumeCommand.TabIndex = 29;
            this.lblResumeCommand.Text = "Résumé commande";
            // 
            // lblProced
            // 
            this.lblProced.AutoSize = true;
            this.lblProced.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProced.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblProced.Location = new System.Drawing.Point(119, 463);
            this.lblProced.Name = "lblProced";
            this.lblProced.Size = new System.Drawing.Size(580, 55);
            this.lblProced.TabIndex = 30;
            this.lblProced.Text = "Procédez au paiement !";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTotal.Location = new System.Drawing.Point(490, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 24);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Totale";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(830, 586);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblProced);
            this.Controls.Add(this.lblResumeCommand);
            this.Name = "Payment";
            this.Text = "Paiement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResumeCommand;
        private System.Windows.Forms.Label lblProced;
        private System.Windows.Forms.Label lblTotal;
    }
}