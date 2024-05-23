namespace P120_UX_Automates.Vue
{
    partial class Recap
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
            this.lblRecap = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lbl_recap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecap
            // 
            this.lblRecap.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecap.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRecap.Location = new System.Drawing.Point(0, 25);
            this.lblRecap.Name = "lblRecap";
            this.lblRecap.Size = new System.Drawing.Size(829, 55);
            this.lblRecap.TabIndex = 71;
            this.lblRecap.Text = "Récapitulatif";
            this.lblRecap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(77, 492);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(235, 68);
            this.btnNo.TabIndex = 70;
            this.btnNo.Text = "Non";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYes.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(500, 492);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(243, 68);
            this.btnYes.TabIndex = 69;
            this.btnYes.Text = "Oui";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblQuestion.Location = new System.Drawing.Point(68, 432);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(691, 31);
            this.lblQuestion.TabIndex = 72;
            this.lblQuestion.Text = "Tous les tickets souhaités sont présent ci-dessus ?";
            // 
            // lbl_recap
            // 
            this.lbl_recap.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recap.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_recap.Location = new System.Drawing.Point(70, 104);
            this.lbl_recap.Name = "lbl_recap";
            this.lbl_recap.Size = new System.Drawing.Size(673, 316);
            this.lbl_recap.TabIndex = 64;
            // 
            // Recap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(830, 586);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblRecap);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lbl_recap);
            this.Name = "Recap";
            this.Text = "Récapitulatif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRecap;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lbl_recap;
    }
}