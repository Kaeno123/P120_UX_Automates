namespace P120_UX_Automates.Vue
{
    partial class TypeOfPayment
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
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblGooglePay = new System.Windows.Forms.Label();
            this.lbl_Cash = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.lblTypeOfPay = new System.Windows.Forms.Label();
            this.btnGooglePay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCard.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCreditCard.Location = new System.Drawing.Point(354, 302);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(188, 24);
            this.lblCreditCard.TabIndex = 33;
            this.lblCreditCard.Text = "Visa, Mastercard";
            // 
            // lblGooglePay
            // 
            this.lblGooglePay.AutoSize = true;
            this.lblGooglePay.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGooglePay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblGooglePay.Location = new System.Drawing.Point(354, 426);
            this.lblGooglePay.Name = "lblGooglePay";
            this.lblGooglePay.Size = new System.Drawing.Size(195, 24);
            this.lblGooglePay.TabIndex = 32;
            this.lblGooglePay.Text = "Avec le téléphone";
            // 
            // lbl_Cash
            // 
            this.lbl_Cash.AutoSize = true;
            this.lbl_Cash.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cash.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Cash.Location = new System.Drawing.Point(354, 172);
            this.lbl_Cash.Name = "lbl_Cash";
            this.lbl_Cash.Size = new System.Drawing.Size(299, 24);
            this.lbl_Cash.TabIndex = 31;
            this.lbl_Cash.Text = "0,50€   1€   2€   5€   10€   20€";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreditCard.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditCard.Location = new System.Drawing.Point(90, 269);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(205, 84);
            this.btnCreditCard.TabIndex = 30;
            this.btnCreditCard.Text = "Carte de crédit";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCash.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnCash.Location = new System.Drawing.Point(90, 145);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(205, 84);
            this.btnCash.TabIndex = 29;
            this.btnCash.Text = "Argent liquide";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // lblTypeOfPay
            // 
            this.lblTypeOfPay.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfPay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTypeOfPay.Location = new System.Drawing.Point(170, 34);
            this.lblTypeOfPay.Name = "lblTypeOfPay";
            this.lblTypeOfPay.Size = new System.Drawing.Size(511, 55);
            this.lblTypeOfPay.TabIndex = 28;
            this.lblTypeOfPay.Text = "Moyens de paiement";
            this.lblTypeOfPay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGooglePay
            // 
            this.btnGooglePay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGooglePay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGooglePay.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGooglePay.Location = new System.Drawing.Point(90, 393);
            this.btnGooglePay.Name = "btnGooglePay";
            this.btnGooglePay.Size = new System.Drawing.Size(205, 84);
            this.btnGooglePay.TabIndex = 35;
            this.btnGooglePay.Text = "Google Pay";
            this.btnGooglePay.UseVisualStyleBackColor = false;
            this.btnGooglePay.Click += new System.EventHandler(this.btnGooglePay_Click);
            // 
            // TypeOfPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(830, 586);
            this.Controls.Add(this.btnGooglePay);
            this.Controls.Add(this.lblCreditCard);
            this.Controls.Add(this.lblGooglePay);
            this.Controls.Add(this.lbl_Cash);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.lblTypeOfPay);
            this.Name = "TypeOfPayment";
            this.Text = "Moyens de paiement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblGooglePay;
        private System.Windows.Forms.Label lbl_Cash;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label lblTypeOfPay;
        private System.Windows.Forms.Button btnGooglePay;
    }
}