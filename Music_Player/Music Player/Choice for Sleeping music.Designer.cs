﻿namespace Music_Player
{
    partial class Form2
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
            this.btn_Instrumental = new System.Windows.Forms.Button();
            this.btn_Asmr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Instrumental
            // 
            this.btn_Instrumental.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Instrumental.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Instrumental.Location = new System.Drawing.Point(17, 128);
            this.btn_Instrumental.Name = "btn_Instrumental";
            this.btn_Instrumental.Size = new System.Drawing.Size(170, 44);
            this.btn_Instrumental.TabIndex = 4;
            this.btn_Instrumental.Text = "Instrumental music";
            this.btn_Instrumental.UseVisualStyleBackColor = true;
            // 
            // btn_Asmr
            // 
            this.btn_Asmr.Font = new System.Drawing.Font("Goudy Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Asmr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Asmr.Location = new System.Drawing.Point(17, 64);
            this.btn_Asmr.Name = "btn_Asmr";
            this.btn_Asmr.Size = new System.Drawing.Size(170, 44);
            this.btn_Asmr.TabIndex = 3;
            this.btn_Asmr.Text = "ASMR";
            this.btn_Asmr.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(472, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pick the type of sleeping music you want to be played";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Instrumental);
            this.Controls.Add(this.btn_Asmr);
            this.Name = "Form2";
            this.Text = "Choise for Sleeping Music";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Instrumental;
        private System.Windows.Forms.Button btn_Asmr;
        private System.Windows.Forms.Label label1;
    }
}