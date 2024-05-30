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
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_recap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecap
            // 
            this.lblRecap.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecap.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRecap.Location = new System.Drawing.Point(0, 23);
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
            this.btnNo.Location = new System.Drawing.Point(77, 498);
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
            this.btnYes.Location = new System.Drawing.Point(500, 498);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(243, 68);
            this.btnYes.TabIndex = 69;
            this.btnYes.Text = "Oui";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblQuestion.Location = new System.Drawing.Point(0, 446);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(829, 31);
            this.lblQuestion.TabIndex = 72;
            this.lblQuestion.Text = "Tous les tickets souhaités sont présent ci-dessus ?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_price.Location = new System.Drawing.Point(620, 100);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(190, 338);
            this.lbl_price.TabIndex = 75;
            // 
            // lbl_date
            // 
            this.lbl_date.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_date.Location = new System.Drawing.Point(422, 100);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(190, 338);
            this.lbl_date.TabIndex = 74;
            // 
            // lbl_recap
            // 
            this.lbl_recap.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recap.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_recap.Location = new System.Drawing.Point(49, 100);
            this.lbl_recap.Name = "lbl_recap";
            this.lbl_recap.Size = new System.Drawing.Size(357, 338);
            this.lbl_recap.TabIndex = 73;
            // 
            // Recap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(830, 586);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_recap);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblRecap);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Name = "Recap";
            this.Text = "Récapitulatif";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRecap;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_recap;
    }
}