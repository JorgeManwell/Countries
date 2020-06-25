namespace Countries
{
    partial class Form1
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox_Countries = new System.Windows.Forms.ListBox();
            this.pictureBox_Country = new System.Windows.Forms.PictureBox();
            this.lbl_CountryName = new System.Windows.Forms.Label();
            this.lbl_CapitalName = new System.Windows.Forms.Label();
            this.lbl_Region = new System.Windows.Forms.Label();
            this.lbl_SubRegion = new System.Windows.Forms.Label();
            this.lbl_Population = new System.Windows.Forms.Label();
            this.lbl_GiniIndex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Country)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.Color.Maroon;
            this.labelResultado.Location = new System.Drawing.Point(19, 347);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(59, 20);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "label1";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Maroon;
            this.labelStatus.Location = new System.Drawing.Point(19, 416);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(55, 20);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 385);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 18);
            this.progressBar1.TabIndex = 6;
            // 
            // listBox_Countries
            // 
            this.listBox_Countries.FormattingEnabled = true;
            this.listBox_Countries.ItemHeight = 16;
            this.listBox_Countries.Location = new System.Drawing.Point(22, 28);
            this.listBox_Countries.Name = "listBox_Countries";
            this.listBox_Countries.Size = new System.Drawing.Size(385, 212);
            this.listBox_Countries.TabIndex = 7;
            this.listBox_Countries.SelectedIndexChanged += new System.EventHandler(this.listBox_Countries_SelectedIndexChanged);
            // 
            // pictureBox_Country
            // 
            this.pictureBox_Country.Location = new System.Drawing.Point(658, 222);
            this.pictureBox_Country.Name = "pictureBox_Country";
            this.pictureBox_Country.Size = new System.Drawing.Size(132, 106);
            this.pictureBox_Country.TabIndex = 8;
            this.pictureBox_Country.TabStop = false;
            // 
            // lbl_CountryName
            // 
            this.lbl_CountryName.AutoSize = true;
            this.lbl_CountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountryName.Location = new System.Drawing.Point(651, 38);
            this.lbl_CountryName.Name = "lbl_CountryName";
            this.lbl_CountryName.Size = new System.Drawing.Size(203, 25);
            this.lbl_CountryName.TabIndex = 9;
            this.lbl_CountryName.Text = "Country Name Result:";
            // 
            // lbl_CapitalName
            // 
            this.lbl_CapitalName.AutoSize = true;
            this.lbl_CapitalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CapitalName.Location = new System.Drawing.Point(652, 67);
            this.lbl_CapitalName.Name = "lbl_CapitalName";
            this.lbl_CapitalName.Size = new System.Drawing.Size(195, 25);
            this.lbl_CapitalName.TabIndex = 10;
            this.lbl_CapitalName.Text = "Capital Name Result:";
            // 
            // lbl_Region
            // 
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Region.Location = new System.Drawing.Point(652, 94);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(138, 25);
            this.lbl_Region.TabIndex = 11;
            this.lbl_Region.Text = "Region Result:";
            // 
            // lbl_SubRegion
            // 
            this.lbl_SubRegion.AutoSize = true;
            this.lbl_SubRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubRegion.Location = new System.Drawing.Point(652, 122);
            this.lbl_SubRegion.Name = "lbl_SubRegion";
            this.lbl_SubRegion.Size = new System.Drawing.Size(181, 25);
            this.lbl_SubRegion.TabIndex = 12;
            this.lbl_SubRegion.Text = "Sub-Region Result:";
            // 
            // lbl_Population
            // 
            this.lbl_Population.AutoSize = true;
            this.lbl_Population.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Population.Location = new System.Drawing.Point(651, 150);
            this.lbl_Population.Name = "lbl_Population";
            this.lbl_Population.Size = new System.Drawing.Size(169, 25);
            this.lbl_Population.TabIndex = 13;
            this.lbl_Population.Text = "Population Result:";
            // 
            // lbl_GiniIndex
            // 
            this.lbl_GiniIndex.AutoSize = true;
            this.lbl_GiniIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiniIndex.Location = new System.Drawing.Point(652, 179);
            this.lbl_GiniIndex.Name = "lbl_GiniIndex";
            this.lbl_GiniIndex.Size = new System.Drawing.Size(164, 25);
            this.lbl_GiniIndex.TabIndex = 14;
            this.lbl_GiniIndex.Text = "Gini Index Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(467, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Country Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(467, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Capital Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(467, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Region:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(467, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sub-Region:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(467, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Population:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(467, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gini Index:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(467, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Flag:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1067, 462);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_GiniIndex);
            this.Controls.Add(this.lbl_Population);
            this.Controls.Add(this.lbl_SubRegion);
            this.Controls.Add(this.lbl_Region);
            this.Controls.Add(this.lbl_CapitalName);
            this.Controls.Add(this.lbl_CountryName);
            this.Controls.Add(this.pictureBox_Country);
            this.Controls.Add(this.listBox_Countries);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Country)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox_Countries;
        private System.Windows.Forms.PictureBox pictureBox_Country;
        private System.Windows.Forms.Label lbl_CountryName;
        private System.Windows.Forms.Label lbl_CapitalName;
        private System.Windows.Forms.Label lbl_Region;
        private System.Windows.Forms.Label lbl_SubRegion;
        private System.Windows.Forms.Label lbl_Population;
        private System.Windows.Forms.Label lbl_GiniIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

