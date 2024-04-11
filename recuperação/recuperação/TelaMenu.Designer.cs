
namespace recuperação
{
    partial class TelaMenu
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
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGoCadastro = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.BtnExitMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "CADASTRAR NOVO FORNECEDOR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "CADASTRAR NOVO FUNCIONARIO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "CADASTRAR NOVO FUNCIONARIOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "IR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "CADASTRAR NOVO CLIENTE";
            // 
            // BtnGoCadastro
            // 
            this.BtnGoCadastro.Location = new System.Drawing.Point(469, 160);
            this.BtnGoCadastro.Name = "BtnGoCadastro";
            this.BtnGoCadastro.Size = new System.Drawing.Size(60, 23);
            this.BtnGoCadastro.TabIndex = 38;
            this.BtnGoCadastro.Text = "IR";
            this.BtnGoCadastro.UseVisualStyleBackColor = true;
            this.BtnGoCadastro.Click += new System.EventHandler(this.BtnGoCadastro_Click_1);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(219, 61);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(374, 21);
            this.lblLogin.TabIndex = 37;
            this.lblLogin.Text = "Deseja cadastrar o que hoje?";
            // 
            // BtnExitMenu
            // 
            this.BtnExitMenu.BackColor = System.Drawing.Color.White;
            this.BtnExitMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitMenu.ForeColor = System.Drawing.Color.Black;
            this.BtnExitMenu.Location = new System.Drawing.Point(713, 12);
            this.BtnExitMenu.Name = "BtnExitMenu";
            this.BtnExitMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnExitMenu.TabIndex = 46;
            this.BtnExitMenu.Text = "EXIT";
            this.BtnExitMenu.UseVisualStyleBackColor = false;
            this.BtnExitMenu.Click += new System.EventHandler(this.BtnExitMenu_Click_1);
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExitMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGoCadastro);
            this.Controls.Add(this.lblLogin);
            this.Name = "TelaMenu";
            this.Text = "TelaMenu";
            this.Load += new System.EventHandler(this.TelaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGoCadastro;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button BtnExitMenu;
    }
}