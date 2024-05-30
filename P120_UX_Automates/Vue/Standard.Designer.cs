namespace P120_UX_Automates.Vue
{
    partial class Standard
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
            this.lblStandard = new System.Windows.Forms.Label();
            this.btnAdult = new System.Windows.Forms.Button();
            this.btnReductPrice = new System.Windows.Forms.Button();
            this.lbl1_50e = new System.Windows.Forms.Label();
            this.lbl1e = new System.Windows.Forms.Label();
            this.lblAgeAdult = new System.Windows.Forms.Label();
            this.lblAgeReduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnGoNext = new System.Windows.Forms.Button();
            this.btnValid = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblValidityStandard = new System.Windows.Forms.Label();
            this.coboxQuantity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblStandard.Location = new System.Drawing.Point(289, 28);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(251, 55);
            this.lblStandard.TabIndex = 2;
            this.lblStandard.Text = "Standard";
            // 
            // btnAdult
            // 
            this.btnAdult.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdult.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnAdult.Location = new System.Drawing.Point(110, 111);
            this.btnAdult.Name = "btnAdult";
            this.btnAdult.Size = new System.Drawing.Size(205, 79);
            this.btnAdult.TabIndex = 3;
            this.btnAdult.Text = "Adulte";
            this.btnAdult.UseVisualStyleBackColor = false;
            this.btnAdult.Click += new System.EventHandler(this.btnAdult_Click);
            // 
            // btnReductPrice
            // 
            this.btnReductPrice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReductPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReductPrice.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReductPrice.Location = new System.Drawing.Point(502, 111);
            this.btnReductPrice.Name = "btnReductPrice";
            this.btnReductPrice.Size = new System.Drawing.Size(205, 79);
            this.btnReductPrice.TabIndex = 4;
            this.btnReductPrice.Text = "Prix réduit";
            this.btnReductPrice.UseVisualStyleBackColor = false;
            this.btnReductPrice.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // lbl1_50e
            // 
            this.lbl1_50e.AutoSize = true;
            this.lbl1_50e.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_50e.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl1_50e.Location = new System.Drawing.Point(174, 210);
            this.lbl1_50e.Name = "lbl1_50e";
            this.lbl1_50e.Size = new System.Drawing.Size(73, 24);
            this.lbl1_50e.TabIndex = 5;
            this.lbl1_50e.Text = "1.50 €";
            // 
            // lbl1e
            // 
            this.lbl1e.AutoSize = true;
            this.lbl1e.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1e.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl1e.Location = new System.Drawing.Point(589, 210);
            this.lbl1e.Name = "lbl1e";
            this.lbl1e.Size = new System.Drawing.Size(41, 24);
            this.lbl1e.TabIndex = 6;
            this.lbl1e.Text = "1 €";
            // 
            // lblAgeAdult
            // 
            this.lblAgeAdult.AutoSize = true;
            this.lblAgeAdult.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAdult.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAgeAdult.Location = new System.Drawing.Point(152, 248);
            this.lblAgeAdult.Name = "lblAgeAdult";
            this.lblAgeAdult.Size = new System.Drawing.Size(120, 24);
            this.lblAgeAdult.TabIndex = 7;
            this.lblAgeAdult.Text = "Dès 18 ans";
            // 
            // lblAgeReduct
            // 
            this.lblAgeReduct.AutoSize = true;
            this.lblAgeReduct.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeReduct.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAgeReduct.Location = new System.Drawing.Point(518, 248);
            this.lblAgeReduct.Name = "lblAgeReduct";
            this.lblAgeReduct.Size = new System.Drawing.Size(187, 24);
            this.lblAgeReduct.TabIndex = 8;
            this.lblAgeReduct.Text = "Enfant, étudiant";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(52, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 8);
            this.panel1.TabIndex = 9;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblQuantity.Location = new System.Drawing.Point(192, 334);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(175, 31);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantité";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 494);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 80);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "🠔";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnGoNext
            // 
            this.btnGoNext.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoNext.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoNext.Location = new System.Drawing.Point(502, 494);
            this.btnGoNext.Name = "btnGoNext";
            this.btnGoNext.Size = new System.Drawing.Size(243, 80);
            this.btnGoNext.TabIndex = 12;
            this.btnGoNext.Text = "Paiement";
            this.btnGoNext.UseVisualStyleBackColor = false;
            this.btnGoNext.Click += new System.EventHandler(this.btnGoNext_Click);
            // 
            // btnValid
            // 
            this.btnValid.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnValid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValid.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValid.Location = new System.Drawing.Point(192, 494);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(235, 80);
            this.btnValid.TabIndex = 13;
            this.btnValid.Text = "Valider tickets";
            this.btnValid.UseVisualStyleBackColor = false;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTime.Location = new System.Drawing.Point(373, 402);
            this.dateTime.MinDate = new System.DateTime(2024, 5, 24, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTime.Size = new System.Drawing.Size(168, 35);
            this.dateTime.TabIndex = 46;
            this.dateTime.Value = new System.DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDate.Location = new System.Drawing.Point(227, 402);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(140, 31);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblValidityStandard
            // 
            this.lblValidityStandard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValidityStandard.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidityStandard.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblValidityStandard.Location = new System.Drawing.Point(547, 406);
            this.lblValidityStandard.Name = "lblValidityStandard";
            this.lblValidityStandard.Size = new System.Drawing.Size(175, 31);
            this.lblValidityStandard.TabIndex = 47;
            this.lblValidityStandard.Text = "Validité : 1 jour";
            this.lblValidityStandard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coboxQuantity
            // 
            this.coboxQuantity.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coboxQuantity.FormattingEnabled = true;
            this.coboxQuantity.ItemHeight = 24;
            this.coboxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.coboxQuantity.Location = new System.Drawing.Point(373, 337);
            this.coboxQuantity.Name = "coboxQuantity";
            this.coboxQuantity.Size = new System.Drawing.Size(49, 32);
            this.coboxQuantity.TabIndex = 69;
            this.coboxQuantity.Text = "1";
            // 
            // Standard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(834, 586);
            this.Controls.Add(this.coboxQuantity);
            this.Controls.Add(this.lblValidityStandard);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.btnGoNext);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAgeReduct);
            this.Controls.Add(this.lblAgeAdult);
            this.Controls.Add(this.lbl1e);
            this.Controls.Add(this.lbl1_50e);
            this.Controls.Add(this.btnReductPrice);
            this.Controls.Add(this.btnAdult);
            this.Controls.Add(this.lblStandard);
            this.Name = "Standard";
            this.Text = "Standard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Button btnAdult;
        private System.Windows.Forms.Button btnReductPrice;
        private System.Windows.Forms.Label lbl1_50e;
        private System.Windows.Forms.Label lbl1e;
        private System.Windows.Forms.Label lblAgeAdult;
        private System.Windows.Forms.Label lblAgeReduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnGoNext;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblValidityStandard;
        private System.Windows.Forms.ComboBox coboxQuantity;
    }
}