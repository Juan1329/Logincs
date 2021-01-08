
namespace Login
{
    partial class FormCadastro
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
            this.btnCadSenha = new System.Windows.Forms.Button();
            this.btnCadSair = new System.Windows.Forms.Button();
            this.txtCadLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadSenha
            // 
            this.btnCadSenha.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadSenha.Location = new System.Drawing.Point(38, 175);
            this.btnCadSenha.Name = "btnCadSenha";
            this.btnCadSenha.Size = new System.Drawing.Size(94, 29);
            this.btnCadSenha.TabIndex = 0;
            this.btnCadSenha.Text = "Cadastrar";
            this.btnCadSenha.UseVisualStyleBackColor = true;
            this.btnCadSenha.Click += new System.EventHandler(this.btnCadSenha_Click);
            // 
            // btnCadSair
            // 
            this.btnCadSair.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadSair.Location = new System.Drawing.Point(192, 175);
            this.btnCadSair.Name = "btnCadSair";
            this.btnCadSair.Size = new System.Drawing.Size(94, 29);
            this.btnCadSair.TabIndex = 1;
            this.btnCadSair.Text = "Sair";
            this.btnCadSair.UseVisualStyleBackColor = true;
            this.btnCadSair.Click += new System.EventHandler(this.btnCadSair_Click);
            // 
            // txtCadLogin
            // 
            this.txtCadLogin.Location = new System.Drawing.Point(150, 61);
            this.txtCadLogin.Name = "txtCadLogin";
            this.txtCadLogin.Size = new System.Drawing.Size(125, 27);
            this.txtCadLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(72, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Location = new System.Drawing.Point(150, 117);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(125, 27);
            this.txtCadSenha.TabIndex = 6;
            this.txtCadSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(99, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "CADASTRE-SE";
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 226);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadLogin);
            this.Controls.Add(this.btnCadSair);
            this.Controls.Add(this.btnCadSenha);
            this.Name = "FormCadastro";
            this.ShowIcon = false;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadSenha;
        private System.Windows.Forms.Button btnCadSair;
        private System.Windows.Forms.TextBox txtCadLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.Label label4;
    }
}