﻿namespace P120_UX_Automates.Vue
{
    partial class Aeroport
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
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAeroport = new System.Windows.Forms.Label();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnGoNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAgeReduct = new System.Windows.Forms.Label();
            this.lblAgeAdult = new System.Windows.Forms.Label();
            this.lbl1_50e = new System.Windows.Forms.Label();
            this.lbl2e = new System.Windows.Forms.Label();
            this.btnChild = new System.Windows.Forms.Button();
            this.btnAdult = new System.Windows.Forms.Button();
            this.lblValidity = new System.Windows.Forms.Label();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.rdbtn3 = new System.Windows.Forms.RadioButton();
            this.rdbtn5 = new System.Windows.Forms.RadioButton();
            this.pnlDays = new System.Windows.Forms.Panel();
            this.coboxQuantity = new System.Windows.Forms.ComboBox();
            this.pnlDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "";
            this.dateTime.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(318, 387);
            this.dateTime.MinDate = new System.DateTime(2024, 5, 24, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(170, 35);
            this.dateTime.TabIndex = 59;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDate.Location = new System.Drawing.Point(189, 387);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(123, 31);
            this.lblDate.TabIndex = 58;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAeroport
            // 
            this.lblAeroport.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAeroport.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAeroport.Location = new System.Drawing.Point(285, 24);
            this.lblAeroport.Name = "lblAeroport";
            this.lblAeroport.Size = new System.Drawing.Size(282, 55);
            this.lblAeroport.TabIndex = 57;
            this.lblAeroport.Text = "Aéroport";
            this.lblAeroport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnValid
            // 
            this.btnValid.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnValid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValid.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValid.Location = new System.Drawing.Point(208, 480);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(235, 80);
            this.btnValid.TabIndex = 56;
            this.btnValid.Text = "Valider tickets";
            this.btnValid.UseVisualStyleBackColor = false;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // btnGoNext
            // 
            this.btnGoNext.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoNext.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoNext.Location = new System.Drawing.Point(518, 480);
            this.btnGoNext.Name = "btnGoNext";
            this.btnGoNext.Size = new System.Drawing.Size(243, 80);
            this.btnGoNext.TabIndex = 55;
            this.btnGoNext.Text = "Paiement";
            this.btnGoNext.UseVisualStyleBackColor = false;
            this.btnGoNext.Click += new System.EventHandler(this.btnGoNext_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(28, 480);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 80);
            this.btnReturn.TabIndex = 54;
            this.btnReturn.Text = "🠔";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblQuantity.Location = new System.Drawing.Point(161, 323);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(151, 31);
            this.lblQuantity.TabIndex = 53;
            this.lblQuantity.Text = "Quantité";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(68, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 8);
            this.panel1.TabIndex = 52;
            // 
            // lblAgeReduct
            // 
            this.lblAgeReduct.AutoSize = true;
            this.lblAgeReduct.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeReduct.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAgeReduct.Location = new System.Drawing.Point(532, 234);
            this.lblAgeReduct.Name = "lblAgeReduct";
            this.lblAgeReduct.Size = new System.Drawing.Size(187, 24);
            this.lblAgeReduct.TabIndex = 51;
            this.lblAgeReduct.Text = "Enfant, étudiant";
            // 
            // lblAgeAdult
            // 
            this.lblAgeAdult.AutoSize = true;
            this.lblAgeAdult.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAdult.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAgeAdult.Location = new System.Drawing.Point(174, 234);
            this.lblAgeAdult.Name = "lblAgeAdult";
            this.lblAgeAdult.Size = new System.Drawing.Size(89, 24);
            this.lblAgeAdult.TabIndex = 50;
            this.lblAgeAdult.Text = "Dès ans";
            // 
            // lbl1_50e
            // 
            this.lbl1_50e.AutoSize = true;
            this.lbl1_50e.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_50e.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl1_50e.Location = new System.Drawing.Point(588, 192);
            this.lbl1_50e.Name = "lbl1_50e";
            this.lbl1_50e.Size = new System.Drawing.Size(73, 24);
            this.lbl1_50e.TabIndex = 49;
            this.lbl1_50e.Text = "1,50 €";
            // 
            // lbl2e
            // 
            this.lbl2e.AutoSize = true;
            this.lbl2e.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2e.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl2e.Location = new System.Drawing.Point(204, 192);
            this.lbl2e.Name = "lbl2e";
            this.lbl2e.Size = new System.Drawing.Size(41, 24);
            this.lbl2e.TabIndex = 48;
            this.lbl2e.Text = "2 €";
            // 
            // btnChild
            // 
            this.btnChild.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChild.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChild.Location = new System.Drawing.Point(516, 100);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(205, 68);
            this.btnChild.TabIndex = 47;
            this.btnChild.Text = "Enfant";
            this.btnChild.UseVisualStyleBackColor = false;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // btnAdult
            // 
            this.btnAdult.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdult.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnAdult.Location = new System.Drawing.Point(124, 100);
            this.btnAdult.Name = "btnAdult";
            this.btnAdult.Size = new System.Drawing.Size(205, 68);
            this.btnAdult.TabIndex = 46;
            this.btnAdult.Text = "Adulte";
            this.btnAdult.UseVisualStyleBackColor = false;
            this.btnAdult.Click += new System.EventHandler(this.btnAdult_Click);
            // 
            // lblValidity
            // 
            this.lblValidity.AutoSize = true;
            this.lblValidity.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblValidity.Location = new System.Drawing.Point(588, 352);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(95, 24);
            this.lblValidity.TabIndex = 63;
            this.lblValidity.Text = "Validité";
            // 
            // rdbtn1
            // 
            this.rdbtn1.AutoSize = true;
            this.rdbtn1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rdbtn1.Location = new System.Drawing.Point(28, 0);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(41, 28);
            this.rdbtn1.TabIndex = 64;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.Text = "1";
            this.rdbtn1.UseVisualStyleBackColor = true;
            this.rdbtn1.CheckedChanged += new System.EventHandler(this.rdbtn1_CheckedChanged);
            // 
            // rdbtn3
            // 
            this.rdbtn3.AutoSize = true;
            this.rdbtn3.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rdbtn3.Location = new System.Drawing.Point(92, 0);
            this.rdbtn3.Name = "rdbtn3";
            this.rdbtn3.Size = new System.Drawing.Size(41, 28);
            this.rdbtn3.TabIndex = 65;
            this.rdbtn3.TabStop = true;
            this.rdbtn3.Text = "3";
            this.rdbtn3.UseVisualStyleBackColor = true;
            this.rdbtn3.CheckedChanged += new System.EventHandler(this.rdbtn3_CheckedChanged);
            // 
            // rdbtn5
            // 
            this.rdbtn5.AutoSize = true;
            this.rdbtn5.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rdbtn5.Location = new System.Drawing.Point(155, 0);
            this.rdbtn5.Name = "rdbtn5";
            this.rdbtn5.Size = new System.Drawing.Size(41, 28);
            this.rdbtn5.TabIndex = 66;
            this.rdbtn5.TabStop = true;
            this.rdbtn5.Text = "5";
            this.rdbtn5.UseVisualStyleBackColor = true;
            this.rdbtn5.CheckedChanged += new System.EventHandler(this.rdbtn5_CheckedChanged);
            // 
            // pnlDays
            // 
            this.pnlDays.Controls.Add(this.rdbtn3);
            this.pnlDays.Controls.Add(this.rdbtn5);
            this.pnlDays.Controls.Add(this.rdbtn1);
            this.pnlDays.Location = new System.Drawing.Point(542, 391);
            this.pnlDays.Name = "pnlDays";
            this.pnlDays.Size = new System.Drawing.Size(218, 31);
            this.pnlDays.TabIndex = 67;
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
            this.coboxQuantity.Location = new System.Drawing.Point(318, 326);
            this.coboxQuantity.Name = "coboxQuantity";
            this.coboxQuantity.Size = new System.Drawing.Size(49, 32);
            this.coboxQuantity.TabIndex = 68;
            this.coboxQuantity.Text = "1";
            // 
            // Aeroport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(830, 586);
            this.Controls.Add(this.coboxQuantity);
            this.Controls.Add(this.pnlDays);
            this.Controls.Add(this.lblValidity);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAeroport);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.btnGoNext);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAgeReduct);
            this.Controls.Add(this.lblAgeAdult);
            this.Controls.Add(this.lbl1_50e);
            this.Controls.Add(this.lbl2e);
            this.Controls.Add(this.btnChild);
            this.Controls.Add(this.btnAdult);
            this.Name = "Aeroport";
            this.Text = "Aéroport";
            this.pnlDays.ResumeLayout(false);
            this.pnlDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAeroport;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Button btnGoNext;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAgeReduct;
        private System.Windows.Forms.Label lblAgeAdult;
        private System.Windows.Forms.Label lbl1_50e;
        private System.Windows.Forms.Label lbl2e;
        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.Button btnAdult;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.RadioButton rdbtn1;
        private System.Windows.Forms.RadioButton rdbtn3;
        private System.Windows.Forms.RadioButton rdbtn5;
        private System.Windows.Forms.Panel pnlDays;
        private System.Windows.Forms.ComboBox coboxQuantity;
    }
}