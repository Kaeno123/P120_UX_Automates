namespace P120_UX_Automates.Vue
{
    partial class Disneyland
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
            this.lstboxQuantity = new System.Windows.Forms.ListBox();
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
            this.lblDisney = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstboxQuantity
            // 
            this.lstboxQuantity.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxQuantity.ItemHeight = 31;
            this.lstboxQuantity.Location = new System.Drawing.Point(376, 318);
            this.lstboxQuantity.Name = "lstboxQuantity";
            this.lstboxQuantity.Size = new System.Drawing.Size(75, 35);
            this.lstboxQuantity.TabIndex = 14;
            // 
            // btnValid
            // 
            this.btnValid.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnValid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValid.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValid.Location = new System.Drawing.Point(195, 473);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(235, 80);
            this.btnValid.TabIndex = 26;
            this.btnValid.Text = "Valider tickets";
            this.btnValid.UseVisualStyleBackColor = false;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // btnGoNext
            // 
            this.btnGoNext.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoNext.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoNext.Location = new System.Drawing.Point(505, 473);
            this.btnGoNext.Name = "btnGoNext";
            this.btnGoNext.Size = new System.Drawing.Size(243, 80);
            this.btnGoNext.TabIndex = 25;
            this.btnGoNext.Text = "Paiement";
            this.btnGoNext.UseVisualStyleBackColor = false;
            this.btnGoNext.Click += new System.EventHandler(this.btnGoNext_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(15, 473);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 82);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "<-";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblQuantity.Location = new System.Drawing.Point(181, 318);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(179, 31);
            this.lblQuantity.TabIndex = 23;
            this.lblQuantity.Text = "Quantité";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(55, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 8);
            this.panel1.TabIndex = 22;
            // 
            // lblAgeReduct
            // 
            this.lblAgeReduct.AutoSize = true;
            this.lblAgeReduct.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeReduct.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAgeReduct.Location = new System.Drawing.Point(521, 229);
            this.lblAgeReduct.Name = "lblAgeReduct";
            this.lblAgeReduct.Size = new System.Drawing.Size(187, 24);
            this.lblAgeReduct.TabIndex = 21;
            this.lblAgeReduct.Text = "Enfant, étudiant";
            // 
            // lblAgeAdult
            // 
            this.lblAgeAdult.AutoSize = true;
            this.lblAgeAdult.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeAdult.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAgeAdult.Location = new System.Drawing.Point(155, 229);
            this.lblAgeAdult.Name = "lblAgeAdult";
            this.lblAgeAdult.Size = new System.Drawing.Size(119, 24);
            this.lblAgeAdult.TabIndex = 20;
            this.lblAgeAdult.Text = "25 - 40 ans";
            // 
            // lbl1_50e
            // 
            this.lbl1_50e.AutoSize = true;
            this.lbl1_50e.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_50e.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl1_50e.Location = new System.Drawing.Point(592, 191);
            this.lbl1_50e.Name = "lbl1_50e";
            this.lbl1_50e.Size = new System.Drawing.Size(73, 24);
            this.lbl1_50e.TabIndex = 19;
            this.lbl1_50e.Text = "1.50 €";
            // 
            // lbl2e
            // 
            this.lbl2e.AutoSize = true;
            this.lbl2e.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2e.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl2e.Location = new System.Drawing.Point(177, 191);
            this.lbl2e.Name = "lbl2e";
            this.lbl2e.Size = new System.Drawing.Size(41, 24);
            this.lbl2e.TabIndex = 18;
            this.lbl2e.Text = "2 €";
            // 
            // btnChild
            // 
            this.btnChild.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChild.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChild.Location = new System.Drawing.Point(514, 105);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(205, 68);
            this.btnChild.TabIndex = 17;
            this.btnChild.Text = "Enfant";
            this.btnChild.UseVisualStyleBackColor = false;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // btnAdult
            // 
            this.btnAdult.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdult.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnAdult.Location = new System.Drawing.Point(113, 105);
            this.btnAdult.Name = "btnAdult";
            this.btnAdult.Size = new System.Drawing.Size(205, 68);
            this.btnAdult.TabIndex = 16;
            this.btnAdult.Text = "Adulte";
            this.btnAdult.UseVisualStyleBackColor = false;
            this.btnAdult.Click += new System.EventHandler(this.btnAdult_Click);
            // 
            // lblDisney
            // 
            this.lblDisney.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisney.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDisney.Location = new System.Drawing.Point(201, 21);
            this.lblDisney.Name = "lblDisney";
            this.lblDisney.Size = new System.Drawing.Size(425, 55);
            this.lblDisney.TabIndex = 27;
            this.lblDisney.Text = "DisneyLand";
            this.lblDisney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblDate.Location = new System.Drawing.Point(195, 382);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(165, 31);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(376, 382);
            this.dateTime.MinDate = new System.DateTime(2024, 4, 25, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(410, 35);
            this.dateTime.TabIndex = 29;
            // 
            // Disneyland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(830, 586);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDisney);
            this.Controls.Add(this.lstboxQuantity);
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
            this.Name = "Disneyland";
            this.Text = "DisneyLand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxQuantity;
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
        private System.Windows.Forms.Label lblDisney;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}