﻿namespace Layout_pokemon
{
    partial class Batalha
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
            this.batalhar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // batalhar
            // 
            this.batalhar.Location = new System.Drawing.Point(95, 179);
            this.batalhar.Name = "batalhar";
            this.batalhar.Size = new System.Drawing.Size(75, 23);
            this.batalhar.TabIndex = 0;
            this.batalhar.Text = "Batalhar";
            this.batalhar.UseVisualStyleBackColor = true;
            this.batalhar.Click += new System.EventHandler(this.batalhar_Click);
            // 
            // Batalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.batalhar);
            this.Name = "Batalha";
            this.Text = "Batalha";
            this.Load += new System.EventHandler(this.Batalha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button batalhar;
    }
}