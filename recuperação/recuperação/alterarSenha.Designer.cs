
namespace recuperação
{
    partial class alterarSenha
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblConfirme = new System.Windows.Forms.Label();
            this.lblNova = new System.Windows.Forms.Label();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.txtConfirme = new System.Windows.Forms.TextBox();
            this.txtNova = new System.Windows.Forms.TextBox();
            this.txtAtual = new System.Windows.Forms.TextBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.Location = new System.Drawing.Point(378, 300);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(183, 33);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar senha";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.Location = new System.Drawing.Point(239, 262);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(133, 11);
            this.lblConfirme.TabIndex = 14;
            this.lblConfirme.Text = "Confirmar senha:";
            // 
            // lblNova
            // 
            this.lblNova.AutoSize = true;
            this.lblNova.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNova.Location = new System.Drawing.Point(239, 223);
            this.lblNova.Name = "lblNova";
            this.lblNova.Size = new System.Drawing.Size(93, 11);
            this.lblNova.TabIndex = 13;
            this.lblNova.Text = "Nova senha:";
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.Location = new System.Drawing.Point(239, 187);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(101, 11);
            this.lblSenhaAtual.TabIndex = 12;
            this.lblSenhaAtual.Text = "Senha atual:";
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.Location = new System.Drawing.Point(374, 118);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(152, 19);
            this.lblAlterarSenha.TabIndex = 11;
            this.lblAlterarSenha.Text = "Alterar senha";
            // 
            // txtConfirme
            // 
            this.txtConfirme.Location = new System.Drawing.Point(378, 253);
            this.txtConfirme.Name = "txtConfirme";
            this.txtConfirme.PasswordChar = '*';
            this.txtConfirme.Size = new System.Drawing.Size(183, 20);
            this.txtConfirme.TabIndex = 10;
            // 
            // txtNova
            // 
            this.txtNova.Location = new System.Drawing.Point(378, 214);
            this.txtNova.Name = "txtNova";
            this.txtNova.PasswordChar = '*';
            this.txtNova.Size = new System.Drawing.Size(183, 20);
            this.txtNova.TabIndex = 9;
            // 
            // txtAtual
            // 
            this.txtAtual.Location = new System.Drawing.Point(378, 178);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.PasswordChar = '*';
            this.txtAtual.Size = new System.Drawing.Size(183, 20);
            this.txtAtual.TabIndex = 8;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.White;
            this.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar.ForeColor = System.Drawing.Color.Black;
            this.BtnVoltar.Location = new System.Drawing.Point(12, 12);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 62;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // alterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.lblNova);
            this.Controls.Add(this.lblSenhaAtual);
            this.Controls.Add(this.lblAlterarSenha);
            this.Controls.Add(this.txtConfirme);
            this.Controls.Add(this.txtNova);
            this.Controls.Add(this.txtAtual);
            this.Name = "alterarSenha";
            this.Text = "alterarSenha";
            this.Load += new System.EventHandler(this.alterarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.Label lblNova;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.Label lblAlterarSenha;
        private System.Windows.Forms.TextBox txtConfirme;
        private System.Windows.Forms.TextBox txtNova;
        private System.Windows.Forms.TextBox txtAtual;
        private System.Windows.Forms.Button BtnVoltar;
    }
}