namespace WindowsFormsApplication1
{
    partial class PokemIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemIN));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nomeL = new System.Windows.Forms.Label();
            this.tipoL = new System.Windows.Forms.Label();
            this.ataqueL = new System.Windows.Forms.Label();
            this.defesaL = new System.Windows.Forms.Label();
            this.hpL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // nomeL
            // 
            this.nomeL.AutoSize = true;
            this.nomeL.BackColor = System.Drawing.Color.Transparent;
            this.nomeL.ForeColor = System.Drawing.Color.White;
            this.nomeL.Location = new System.Drawing.Point(12, 18);
            this.nomeL.Name = "nomeL";
            this.nomeL.Size = new System.Drawing.Size(38, 13);
            this.nomeL.TabIndex = 3;
            this.nomeL.Text = "Nome:";
            // 
            // tipoL
            // 
            this.tipoL.AutoSize = true;
            this.tipoL.BackColor = System.Drawing.Color.Transparent;
            this.tipoL.ForeColor = System.Drawing.Color.White;
            this.tipoL.Location = new System.Drawing.Point(12, 67);
            this.tipoL.Name = "tipoL";
            this.tipoL.Size = new System.Drawing.Size(31, 13);
            this.tipoL.TabIndex = 4;
            this.tipoL.Text = "Tipo:";
            // 
            // ataqueL
            // 
            this.ataqueL.AutoSize = true;
            this.ataqueL.BackColor = System.Drawing.Color.Transparent;
            this.ataqueL.ForeColor = System.Drawing.Color.White;
            this.ataqueL.Location = new System.Drawing.Point(11, 121);
            this.ataqueL.Name = "ataqueL";
            this.ataqueL.Size = new System.Drawing.Size(44, 13);
            this.ataqueL.TabIndex = 5;
            this.ataqueL.Text = "Ataque:";
            // 
            // defesaL
            // 
            this.defesaL.AutoSize = true;
            this.defesaL.BackColor = System.Drawing.Color.Transparent;
            this.defesaL.ForeColor = System.Drawing.Color.Transparent;
            this.defesaL.Location = new System.Drawing.Point(11, 165);
            this.defesaL.Name = "defesaL";
            this.defesaL.Size = new System.Drawing.Size(44, 13);
            this.defesaL.TabIndex = 6;
            this.defesaL.Text = "Defesa:";
            // 
            // hpL
            // 
            this.hpL.AutoSize = true;
            this.hpL.BackColor = System.Drawing.Color.Transparent;
            this.hpL.ForeColor = System.Drawing.Color.White;
            this.hpL.Location = new System.Drawing.Point(11, 213);
            this.hpL.Name = "hpL";
            this.hpL.Size = new System.Drawing.Size(25, 13);
            this.hpL.TabIndex = 7;
            this.hpL.Text = "HP:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 210);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 20);
            this.textBox5.TabIndex = 13;
            // 
            // PokemIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Pokebola;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(302, 303);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hpL);
            this.Controls.Add(this.defesaL);
            this.Controls.Add(this.ataqueL);
            this.Controls.Add(this.tipoL);
            this.Controls.Add(this.nomeL);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PokemIN";
            this.Text = "PokemIN Cadastro Pokemon";
            this.Load += new System.EventHandler(this.PokemIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label nomeL;
        private System.Windows.Forms.Label tipoL;
        private System.Windows.Forms.Label ataqueL;
        private System.Windows.Forms.Label defesaL;
        private System.Windows.Forms.Label hpL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

