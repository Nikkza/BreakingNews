﻿namespace BreakingNews
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
            this.radioButtonPolis = new System.Windows.Forms.RadioButton();
            this.radioButtonEkonomi = new System.Windows.Forms.RadioButton();
            this.radioButtonBostad = new System.Windows.Forms.RadioButton();
            this.radioButtonKorea = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonAftonbladet
            // 
            this.radioButtonAftonbladet.AutoSize = true;
            this.radioButtonAftonbladet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButtonAftonbladet.FlatAppearance.BorderSize = 0;
            this.radioButtonAftonbladet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButtonAftonbladet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAftonbladet.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAftonbladet.Location = new System.Drawing.Point(28, 25);
            this.radioButtonAftonbladet.Name = "radioButtonAftonbladet";
            this.radioButtonAftonbladet.Size = new System.Drawing.Size(158, 33);
            this.radioButtonAftonbladet.TabIndex = 2;
            this.radioButtonAftonbladet.TabStop = true;
            this.radioButtonAftonbladet.Text = "aftonbladet";
            this.radioButtonAftonbladet.UseVisualStyleBackColor = true;
            // 
            // radioButtonDN
            // 
            this.radioButtonDN.AutoSize = true;
            this.radioButtonDN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButtonDN.FlatAppearance.BorderSize = 0;
            this.radioButtonDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonDN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDN.Location = new System.Drawing.Point(28, 118);
            this.radioButtonDN.Name = "radioButtonDN";
            this.radioButtonDN.Size = new System.Drawing.Size(199, 33);
            this.radioButtonDN.TabIndex = 5;
            this.radioButtonDN.TabStop = true;
            this.radioButtonDN.Text = "dagensNyheter";
            this.radioButtonDN.UseVisualStyleBackColor = true;
            // 
            // radioButtonExpressen
            // 
            this.radioButtonExpressen.AutoSize = true;
            this.radioButtonExpressen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.radioButtonExpressen.FlatAppearance.BorderSize = 0;
            this.radioButtonExpressen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonExpressen.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonExpressen.Location = new System.Drawing.Point(28, 72);
            this.radioButtonExpressen.Name = "radioButtonExpressen";
            this.radioButtonExpressen.Size = new System.Drawing.Size(147, 33);
            this.radioButtonExpressen.TabIndex = 6;
            this.radioButtonExpressen.TabStop = true;
            this.radioButtonExpressen.Text = "expressen";
            this.radioButtonExpressen.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCount.Location = new System.Drawing.Point(203, 344);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 46);
            this.labelCount.TabIndex = 7;
            // 
            // buttonGetStat
            // 
            this.buttonGetStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonGetStat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonGetStat.FlatAppearance.BorderSize = 0;
            this.buttonGetStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetStat.Location = new System.Drawing.Point(12, 265);
            this.buttonGetStat.Name = "buttonGetStat";
            this.buttonGetStat.Size = new System.Drawing.Size(517, 55);
            this.buttonGetStat.TabIndex = 8;
            this.buttonGetStat.Text = "Get Statistcs";
            this.buttonGetStat.UseVisualStyleBackColor = false;
            this.buttonGetStat.Click += new System.EventHandler(this.buttonGetStat_Click);
            // 
            // radioButtonPolis
            // 
            this.radioButtonPolis.AutoSize = true;
            this.radioButtonPolis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPolis.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPolis.Location = new System.Drawing.Point(49, 161);
            this.radioButtonPolis.Name = "radioButtonPolis";
            this.radioButtonPolis.Size = new System.Drawing.Size(87, 33);
            this.radioButtonPolis.TabIndex = 4;
            this.radioButtonPolis.Text = "polis";
            this.radioButtonPolis.UseVisualStyleBackColor = true;
            // 
            // radioButtonEkonomi
            // 
            this.radioButtonEkonomi.AutoSize = true;
            this.radioButtonEkonomi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonEkonomi.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEkonomi.Location = new System.Drawing.Point(49, 119);
            this.radioButtonEkonomi.Name = "radioButtonEkonomi";
            this.radioButtonEkonomi.Size = new System.Drawing.Size(128, 33);
            this.radioButtonEkonomi.TabIndex = 3;
            this.radioButtonEkonomi.TabStop = true;
            this.radioButtonEkonomi.Text = "ekonomi";
            this.radioButtonEkonomi.UseVisualStyleBackColor = true;
            // 
            // radioButtonBostad
            // 
            this.radioButtonBostad.AutoSize = true;
            this.radioButtonBostad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonBostad.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBostad.Location = new System.Drawing.Point(49, 73);
            this.radioButtonBostad.Name = "radioButtonBostad";
            this.radioButtonBostad.Size = new System.Drawing.Size(108, 33);
            this.radioButtonBostad.TabIndex = 1;
            this.radioButtonBostad.TabStop = true;
            this.radioButtonBostad.Text = "bostad";
            this.radioButtonBostad.UseVisualStyleBackColor = true;
            // 
            // radioButtonKorea
            // 
            this.radioButtonKorea.AutoSize = true;
            this.radioButtonKorea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonKorea.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKorea.Location = new System.Drawing.Point(49, 25);
            this.radioButtonKorea.Name = "radioButtonKorea";
            this.radioButtonKorea.Size = new System.Drawing.Size(98, 33);
            this.radioButtonKorea.TabIndex = 0;
            this.radioButtonKorea.TabStop = true;
            this.radioButtonKorea.Text = "korea";
            this.radioButtonKorea.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.radioButtonBostad);
            this.groupBox1.Controls.Add(this.radioButtonPolis);
            this.groupBox1.Controls.Add(this.radioButtonEkonomi);
            this.groupBox1.Controls.Add(this.radioButtonKorea);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 211);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonExpressen);
            this.groupBox2.Controls.Add(this.radioButtonDN);
            this.groupBox2.Controls.Add(this.radioButtonAftonbladet);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(285, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 210);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 19);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(521, 19);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(187, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 182);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(518, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 182);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(0, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 182);
            this.textBox5.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(541, 414);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGetStat);
            this.Controls.Add(this.labelCount);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.RadioButton radioButtonPolis;
        private System.Windows.Forms.RadioButton radioButtonEkonomi;
        private System.Windows.Forms.RadioButton radioButtonBostad;
        private System.Windows.Forms.RadioButton radioButtonKorea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

