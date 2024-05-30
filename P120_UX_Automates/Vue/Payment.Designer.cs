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
            this.lbl_recap = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResumeCommand
            // 
            this.lblResumeCommand.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumeCommand.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblResumeCommand.Location = new System.Drawing.Point(171, 28);
            this.lblResumeCommand.Name = "lblResumeCommand";
            this.lblResumeCommand.Size = new System.Drawing.Size(486, 55);
            this.lblResumeCommand.TabIndex = 29;
            this.lblResumeCommand.Text = "Résumé commande";
            this.lblResumeCommand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProced
            // 
            this.lblProced.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProced.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblProced.Location = new System.Drawing.Point(0, 476);
            this.lblProced.Name = "lblProced";
            this.lblProced.Size = new System.Drawing.Size(830, 55);
            this.lblProced.TabIndex = 30;
            this.lblProced.Text = "Procédez au paiement !";
            this.lblProced.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_recap
            // 
            this.lbl_recap.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recap.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_recap.Location = new System.Drawing.Point(60, 113);
            this.lbl_recap.Name = "lbl_recap";
            this.lbl_recap.Size = new System.Drawing.Size(357, 338);
            this.lbl_recap.TabIndex = 65;
            // 
            // lbl_date
            // 
            this.lbl_date.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_date.Location = new System.Drawing.Point(433, 113);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(189, 338);
            this.lbl_date.TabIndex = 66;
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_price.Location = new System.Drawing.Point(620, 113);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(174, 338);
            this.lbl_price.TabIndex = 67;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(830, 586);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_recap);
            this.Controls.Add(this.lblProced);
            this.Controls.Add(this.lblResumeCommand);
            this.Name = "Payment";
            this.Text = "Paiement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResumeCommand;
        private System.Windows.Forms.Label lblProced;
        private System.Windows.Forms.Label lbl_recap;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_price;
    }
}