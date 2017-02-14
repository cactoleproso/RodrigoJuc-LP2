namespace Layout_pokemon
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.cadastreok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomeinv = new System.Windows.Forms.Label();
            this.senhainc = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.cadastrosenha2 = new System.Windows.Forms.TextBox();
            this.cadastrosenha1 = new System.Windows.Forms.TextBox();
            this.cadastroUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastreok
            // 
            this.cadastreok.Location = new System.Drawing.Point(176, 209);
            this.cadastreok.Name = "cadastreok";
            this.cadastreok.Size = new System.Drawing.Size(75, 23);
            this.cadastreok.TabIndex = 0;
            this.cadastreok.Text = "Cadastrar";
            this.cadastreok.UseVisualStyleBackColor = true;
            this.cadastreok.Click += new System.EventHandler(this.cadastreok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nomeinv);
            this.groupBox1.Controls.Add(this.senhainc);
            this.groupBox1.Controls.Add(this.cancelar);
            this.groupBox1.Controls.Add(this.cadastrosenha2);
            this.groupBox1.Controls.Add(this.cadastrosenha1);
            this.groupBox1.Controls.Add(this.cadastroUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cadastreok);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nomeinv
            // 
            this.nomeinv.AutoSize = true;
            this.nomeinv.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeinv.ForeColor = System.Drawing.Color.Silver;
            this.nomeinv.Location = new System.Drawing.Point(8, 180);
            this.nomeinv.Name = "nomeinv";
            this.nomeinv.Size = new System.Drawing.Size(0, 16);
            this.nomeinv.TabIndex = 11;
            // 
            // senhainc
            // 
            this.senhainc.AutoSize = true;
            this.senhainc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhainc.ForeColor = System.Drawing.Color.Silver;
            this.senhainc.Location = new System.Drawing.Point(8, 164);
            this.senhainc.Name = "senhainc";
            this.senhainc.Size = new System.Drawing.Size(0, 16);
            this.senhainc.TabIndex = 10;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(9, 209);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 9;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // cadastrosenha2
            // 
            this.cadastrosenha2.Location = new System.Drawing.Point(96, 104);
            this.cadastrosenha2.Name = "cadastrosenha2";
            this.cadastrosenha2.Size = new System.Drawing.Size(158, 20);
            this.cadastrosenha2.TabIndex = 8;
            this.cadastrosenha2.TextChanged += new System.EventHandler(this.cadastrosenha2_TextChanged);
            // 
            // cadastrosenha1
            // 
            this.cadastrosenha1.Location = new System.Drawing.Point(96, 73);
            this.cadastrosenha1.Name = "cadastrosenha1";
            this.cadastrosenha1.Size = new System.Drawing.Size(158, 20);
            this.cadastrosenha1.TabIndex = 7;
            // 
            // cadastroUsuario
            // 
            this.cadastroUsuario.Location = new System.Drawing.Point(96, 44);
            this.cadastroUsuario.Name = "cadastroUsuario";
            this.cadastroUsuario.Size = new System.Drawing.Size(158, 20);
            this.cadastroUsuario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirmar Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome de Usuário:";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Layout_pokemon.Properties.Resources.l42324_pokeball_48813;
            this.ClientSize = new System.Drawing.Size(281, 262);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadastreok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox cadastrosenha2;
        private System.Windows.Forms.TextBox cadastrosenha1;
        private System.Windows.Forms.TextBox cadastroUsuario;
        private System.Windows.Forms.Label senhainc;
        private System.Windows.Forms.Label nomeinv;
    }
}