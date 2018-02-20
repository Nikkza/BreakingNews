namespace BreakingNews
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
            this.radioButtonAftonbladet = new System.Windows.Forms.RadioButton();
            this.radioButtonDN = new System.Windows.Forms.RadioButton();
            this.radioButtonExpressen = new System.Windows.Forms.RadioButton();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonGetStat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.radioButtonPolis = new System.Windows.Forms.RadioButton();
            this.radioButtonEkonomi = new System.Windows.Forms.RadioButton();
            this.radioButtonBostad = new System.Windows.Forms.RadioButton();
            this.radioButtonKorea = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonAftonbladet
            // 
            this.radioButtonAftonbladet.AutoSize = true;
            this.radioButtonAftonbladet.Location = new System.Drawing.Point(28, 20);
            this.radioButtonAftonbladet.Name = "radioButtonAftonbladet";
            this.radioButtonAftonbladet.Size = new System.Drawing.Size(115, 24);
            this.radioButtonAftonbladet.TabIndex = 2;
            this.radioButtonAftonbladet.TabStop = true;
            this.radioButtonAftonbladet.Text = "aftonbladet";
            this.radioButtonAftonbladet.UseVisualStyleBackColor = true;
            // 
            // radioButtonDN
            // 
            this.radioButtonDN.AutoSize = true;
            this.radioButtonDN.Location = new System.Drawing.Point(28, 170);
            this.radioButtonDN.Name = "radioButtonDN";
            this.radioButtonDN.Size = new System.Drawing.Size(142, 24);
            this.radioButtonDN.TabIndex = 5;
            this.radioButtonDN.TabStop = true;
            this.radioButtonDN.Text = "dagensNyheter";
            this.radioButtonDN.UseVisualStyleBackColor = true;
            // 
            // radioButtonExpressen
            // 
            this.radioButtonExpressen.AutoSize = true;
            this.radioButtonExpressen.Location = new System.Drawing.Point(28, 95);
            this.radioButtonExpressen.Name = "radioButtonExpressen";
            this.radioButtonExpressen.Size = new System.Drawing.Size(107, 24);
            this.radioButtonExpressen.TabIndex = 6;
            this.radioButtonExpressen.TabStop = true;
            this.radioButtonExpressen.Text = "expressen";
            this.radioButtonExpressen.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCount.Location = new System.Drawing.Point(690, 123);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(91, 32);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Count";
            // 
            // buttonGetStat
            // 
            this.buttonGetStat.Location = new System.Drawing.Point(696, 62);
            this.buttonGetStat.Name = "buttonGetStat";
            this.buttonGetStat.Size = new System.Drawing.Size(186, 33);
            this.buttonGetStat.TabIndex = 8;
            this.buttonGetStat.Text = "DownLoad";
            this.buttonGetStat.UseVisualStyleBackColor = true;
            this.buttonGetStat.Click += new System.EventHandler(this.buttonGetStat_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(221, 270);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(666, 104);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(315, 417);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(516, 84);
            this.listBox2.TabIndex = 12;
            // 
            // radioButtonPolis
            // 
            this.radioButtonPolis.AutoSize = true;
            this.radioButtonPolis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPolis.Location = new System.Drawing.Point(49, 268);
            this.radioButtonPolis.Name = "radioButtonPolis";
            this.radioButtonPolis.Size = new System.Drawing.Size(64, 24);
            this.radioButtonPolis.TabIndex = 4;
            this.radioButtonPolis.Text = "polis";
            this.radioButtonPolis.UseVisualStyleBackColor = true;
            // 
            // radioButtonEkonomi
            // 
            this.radioButtonEkonomi.AutoSize = true;
            this.radioButtonEkonomi.Location = new System.Drawing.Point(49, 187);
            this.radioButtonEkonomi.Name = "radioButtonEkonomi";
            this.radioButtonEkonomi.Size = new System.Drawing.Size(94, 24);
            this.radioButtonEkonomi.TabIndex = 3;
            this.radioButtonEkonomi.TabStop = true;
            this.radioButtonEkonomi.Text = "ekonomi";
            this.radioButtonEkonomi.UseVisualStyleBackColor = true;
            // 
            // radioButtonBostad
            // 
            this.radioButtonBostad.AutoSize = true;
            this.radioButtonBostad.Location = new System.Drawing.Point(49, 100);
            this.radioButtonBostad.Name = "radioButtonBostad";
            this.radioButtonBostad.Size = new System.Drawing.Size(83, 24);
            this.radioButtonBostad.TabIndex = 1;
            this.radioButtonBostad.TabStop = true;
            this.radioButtonBostad.Text = "bostad";
            this.radioButtonBostad.UseVisualStyleBackColor = true;
            // 
            // radioButtonKorea
            // 
            this.radioButtonKorea.AutoSize = true;
            this.radioButtonKorea.Location = new System.Drawing.Point(49, 25);
            this.radioButtonKorea.Name = "radioButtonKorea";
            this.radioButtonKorea.Size = new System.Drawing.Size(74, 24);
            this.radioButtonKorea.TabIndex = 0;
            this.radioButtonKorea.TabStop = true;
            this.radioButtonKorea.Text = "korea";
            this.radioButtonKorea.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBostad);
            this.groupBox1.Controls.Add(this.radioButtonPolis);
            this.groupBox1.Controls.Add(this.radioButtonEkonomi);
            this.groupBox1.Controls.Add(this.radioButtonKorea);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 311);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonExpressen);
            this.groupBox2.Controls.Add(this.radioButtonDN);
            this.groupBox2.Controls.Add(this.radioButtonAftonbladet);
            this.groupBox2.Location = new System.Drawing.Point(285, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 210);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonGetStat);
            this.Controls.Add(this.labelCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonAftonbladet;
        private System.Windows.Forms.RadioButton radioButtonDN;
        private System.Windows.Forms.RadioButton radioButtonExpressen;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonGetStat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton radioButtonPolis;
        private System.Windows.Forms.RadioButton radioButtonEkonomi;
        private System.Windows.Forms.RadioButton radioButtonBostad;
        private System.Windows.Forms.RadioButton radioButtonKorea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

