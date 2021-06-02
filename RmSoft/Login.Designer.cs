
namespace RmSoft
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Senha = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Senha
            // 
            this.Senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Senha.Location = new System.Drawing.Point(123, 209);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(100, 21);
            this.Senha.TabIndex = 2;
            this.Senha.Tag = "1";
            this.Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(107, 334);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Lembrar Usuario/Senha";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.Location = new System.Drawing.Point(41, 273);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Entrar.TabIndex = 4;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = true;
            this.Btn_Entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(232, 273);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sair.TabIndex = 5;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "roodrigogp.3@gmail.com";
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(78, 132);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(206, 21);
            this.Usuario.TabIndex = 1;
            this.Usuario.Tag = "0";
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            this.Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Digite um Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(148, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(356, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Senha);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Btn_Entrar;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

