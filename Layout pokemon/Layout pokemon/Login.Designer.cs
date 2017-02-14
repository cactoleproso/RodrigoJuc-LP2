namespace Layout_pokemon
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cadastre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SenhaTxt = new System.Windows.Forms.TextBox();
            this.UsuarioTxt = new System.Windows.Forms.TextBox();
            this.lSenha = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.Entrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastre
            // 
            this.cadastre.Location = new System.Drawing.Point(68, 212);
            this.cadastre.Name = "cadastre";
            this.cadastre.Size = new System.Drawing.Size(75, 23);
            this.cadastre.TabIndex = 0;
            this.cadastre.Text = "Cadastre-se";
            this.cadastre.UseVisualStyleBackColor = true;
            this.cadastre.Click += new System.EventHandler(this.cadastre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem-Vindo!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.SenhaTxt);
            this.groupBox1.Controls.Add(this.UsuarioTxt);
            this.groupBox1.Controls.Add(this.lSenha);
            this.groupBox1.Controls.Add(this.lUsuario);
            this.groupBox1.Location = new System.Drawing.Point(40, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // SenhaTxt
            // 
            this.SenhaTxt.Location = new System.Drawing.Point(53, 74);
            this.SenhaTxt.Name = "SenhaTxt";
            this.SenhaTxt.Size = new System.Drawing.Size(161, 20);
            this.SenhaTxt.TabIndex = 3;
            // 
            // UsuarioTxt
            // 
            this.UsuarioTxt.Location = new System.Drawing.Point(53, 32);
            this.UsuarioTxt.Name = "UsuarioTxt";
            this.UsuarioTxt.Size = new System.Drawing.Size(161, 20);
            this.UsuarioTxt.TabIndex = 2;
            this.UsuarioTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lSenha
            // 
            this.lSenha.AutoSize = true;
            this.lSenha.Location = new System.Drawing.Point(6, 77);
            this.lSenha.Name = "lSenha";
            this.lSenha.Size = new System.Drawing.Size(41, 13);
            this.lSenha.TabIndex = 1;
            this.lSenha.Text = "Senha:";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(6, 35);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(46, 13);
            this.lUsuario.TabIndex = 0;
            this.lUsuario.Text = "Usuário:";
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(166, 212);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 4;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Layout_pokemon.Properties.Resources.l42324_pokeball_48813;
            this.ClientSize = new System.Drawing.Size(299, 252);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "PokémIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SenhaTxt;
        private System.Windows.Forms.TextBox UsuarioTxt;
        private System.Windows.Forms.Label lSenha;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button Entrar;
    }
}

