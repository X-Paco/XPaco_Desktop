
namespace Xpaco
{
    partial class Usuario
    {
        /// <summary> *
        /// Required designer variable.
        /// 
        /// *********************************************************
        /// Tipos de acesso.: public, private, protected, internal
        /// Modificadores...: abstrac, sealed, static
        /// Tipo de retorno.: void(sem retorno)
        /// Nome método.....:
        /// Lista Parâmetros:
        /// **********************************************************
        /// </summary>

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                //
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.panelSuperiorUser = new System.Windows.Forms.Panel();
            this.pbLogoPaginaCadastro = new System.Windows.Forms.PictureBox();
            this.lblPaginaCadastro = new System.Windows.Forms.Label();
            this.lblNomePaginaCadastro = new System.Windows.Forms.Label();
            this.txtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.TelefonePaginaCadastro = new System.Windows.Forms.Label();
            this.lblRepitaSenhaPaginaCadastro = new System.Windows.Forms.Label();
            this.lblSenhaPaginaCadastro = new System.Windows.Forms.Label();
            this.lblEmailPaginaCadastro = new System.Windows.Forms.Label();
            this.lblApelidoPaginaCadastro = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtBoxApelido = new System.Windows.Forms.TextBox();
            this.txtBoxRepitaSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrarUser = new System.Windows.Forms.Button();
            this.btnVoltarPaginaCadastro = new System.Windows.Forms.Button();
            this.panelEsquerdoPaginaCadastro = new System.Windows.Forms.Panel();
            this.panelDireitoPaginaCadastro = new System.Windows.Forms.Panel();
            this.panelBottomPaginaCadastro = new System.Windows.Forms.Panel();
            this.panelSuperiorUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPaginaCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperiorUser
            // 
            this.panelSuperiorUser.BackColor = System.Drawing.Color.Gray;
            this.panelSuperiorUser.Controls.Add(this.pbLogoPaginaCadastro);
            this.panelSuperiorUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperiorUser.Location = new System.Drawing.Point(0, 0);
            this.panelSuperiorUser.Name = "panelSuperiorUser";
            this.panelSuperiorUser.Size = new System.Drawing.Size(826, 62);
            this.panelSuperiorUser.TabIndex = 0;
            // 
            // pbLogoPaginaCadastro
            // 
            this.pbLogoPaginaCadastro.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoPaginaCadastro.Image")));
            this.pbLogoPaginaCadastro.Location = new System.Drawing.Point(0, 0);
            this.pbLogoPaginaCadastro.Name = "pbLogoPaginaCadastro";
            this.pbLogoPaginaCadastro.Size = new System.Drawing.Size(137, 62);
            this.pbLogoPaginaCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoPaginaCadastro.TabIndex = 0;
            this.pbLogoPaginaCadastro.TabStop = false;
            // 
            // lblPaginaCadastro
            // 
            this.lblPaginaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaginaCadastro.AutoSize = true;
            this.lblPaginaCadastro.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.lblPaginaCadastro.Location = new System.Drawing.Point(317, 74);
            this.lblPaginaCadastro.Name = "lblPaginaCadastro";
            this.lblPaginaCadastro.Size = new System.Drawing.Size(193, 29);
            this.lblPaginaCadastro.TabIndex = 1;
            this.lblPaginaCadastro.Text = "Página de cadastro";
            // 
            // lblNomePaginaCadastro
            // 
            this.lblNomePaginaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomePaginaCadastro.AutoSize = true;
            this.lblNomePaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNomePaginaCadastro.Location = new System.Drawing.Point(221, 163);
            this.lblNomePaginaCadastro.Name = "lblNomePaginaCadastro";
            this.lblNomePaginaCadastro.Size = new System.Drawing.Size(138, 19);
            this.lblNomePaginaCadastro.TabIndex = 1;
            this.lblNomePaginaCadastro.Text = "Nome Completo:";
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxTelefone.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtBoxTelefone.Location = new System.Drawing.Point(365, 315);
            this.txtBoxTelefone.Mask = "(00) 00000-0000";
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(102, 27);
            this.txtBoxTelefone.TabIndex = 6;
            this.txtBoxTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTelefonePaginaCadastro_MaskInputRejected);
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxNome.Location = new System.Drawing.Point(365, 162);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(235, 20);
            this.txtBoxNome.TabIndex = 1;
            // 
            // TelefonePaginaCadastro
            // 
            this.TelefonePaginaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TelefonePaginaCadastro.AutoSize = true;
            this.TelefonePaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TelefonePaginaCadastro.Location = new System.Drawing.Point(221, 319);
            this.TelefonePaginaCadastro.Name = "TelefonePaginaCadastro";
            this.TelefonePaginaCadastro.Size = new System.Drawing.Size(80, 19);
            this.TelefonePaginaCadastro.TabIndex = 4;
            this.TelefonePaginaCadastro.Text = "Telefone:";
            // 
            // lblRepitaSenhaPaginaCadastro
            // 
            this.lblRepitaSenhaPaginaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRepitaSenhaPaginaCadastro.AutoSize = true;
            this.lblRepitaSenhaPaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblRepitaSenhaPaginaCadastro.Location = new System.Drawing.Point(221, 286);
            this.lblRepitaSenhaPaginaCadastro.Name = "lblRepitaSenhaPaginaCadastro";
            this.lblRepitaSenhaPaginaCadastro.Size = new System.Drawing.Size(128, 19);
            this.lblRepitaSenhaPaginaCadastro.TabIndex = 5;
            this.lblRepitaSenhaPaginaCadastro.Text = "Repita a senha:";
            // 
            // lblSenhaPaginaCadastro
            // 
            this.lblSenhaPaginaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSenhaPaginaCadastro.AutoSize = true;
            this.lblSenhaPaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSenhaPaginaCadastro.Location = new System.Drawing.Point(221, 258);
            this.lblSenhaPaginaCadastro.Name = "lblSenhaPaginaCadastro";
            this.lblSenhaPaginaCadastro.Size = new System.Drawing.Size(64, 19);
            this.lblSenhaPaginaCadastro.TabIndex = 6;
            this.lblSenhaPaginaCadastro.Text = "Senha:";
            // 
            // lblEmailPaginaCadastro
            // 
            this.lblEmailPaginaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmailPaginaCadastro.AutoSize = true;
            this.lblEmailPaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmailPaginaCadastro.Location = new System.Drawing.Point(221, 227);
            this.lblEmailPaginaCadastro.Name = "lblEmailPaginaCadastro";
            this.lblEmailPaginaCadastro.Size = new System.Drawing.Size(62, 19);
            this.lblEmailPaginaCadastro.TabIndex = 7;
            this.lblEmailPaginaCadastro.Text = "E-mail:";
            // 
            // lblApelidoPaginaCadastro
            // 
            this.lblApelidoPaginaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApelidoPaginaCadastro.AutoSize = true;
            this.lblApelidoPaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblApelidoPaginaCadastro.Location = new System.Drawing.Point(221, 194);
            this.lblApelidoPaginaCadastro.Name = "lblApelidoPaginaCadastro";
            this.lblApelidoPaginaCadastro.Size = new System.Drawing.Size(73, 19);
            this.lblApelidoPaginaCadastro.TabIndex = 8;
            this.lblApelidoPaginaCadastro.Text = "Apelido:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEmail.Location = new System.Drawing.Point(365, 226);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(235, 20);
            this.txtBoxEmail.TabIndex = 3;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxSenha.Location = new System.Drawing.Point(365, 257);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(235, 20);
            this.txtBoxSenha.TabIndex = 4;
            // 
            // txtBoxApelido
            // 
            this.txtBoxApelido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxApelido.Location = new System.Drawing.Point(365, 193);
            this.txtBoxApelido.Name = "txtBoxApelido";
            this.txtBoxApelido.Size = new System.Drawing.Size(235, 20);
            this.txtBoxApelido.TabIndex = 2;
            // 
            // txtBoxRepitaSenha
            // 
            this.txtBoxRepitaSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxRepitaSenha.Location = new System.Drawing.Point(365, 285);
            this.txtBoxRepitaSenha.Name = "txtBoxRepitaSenha";
            this.txtBoxRepitaSenha.Size = new System.Drawing.Size(235, 20);
            this.txtBoxRepitaSenha.TabIndex = 5;
            // 
            // btnCadastrarUser
            // 
            this.btnCadastrarUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrarUser.BackColor = System.Drawing.Color.Gray;
            this.btnCadastrarUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarUser.Location = new System.Drawing.Point(513, 374);
            this.btnCadastrarUser.Name = "btnCadastrarUser";
            this.btnCadastrarUser.Size = new System.Drawing.Size(87, 33);
            this.btnCadastrarUser.TabIndex = 8;
            this.btnCadastrarUser.Text = "Cadastrar";
            this.btnCadastrarUser.UseVisualStyleBackColor = false;
            this.btnCadastrarUser.Click += new System.EventHandler(this.btnCadastroUser_Click);
            // 
            // btnVoltarPaginaCadastro
            // 
            this.btnVoltarPaginaCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVoltarPaginaCadastro.BackColor = System.Drawing.Color.Gray;
            this.btnVoltarPaginaCadastro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoltarPaginaCadastro.Location = new System.Drawing.Point(225, 374);
            this.btnVoltarPaginaCadastro.Name = "btnVoltarPaginaCadastro";
            this.btnVoltarPaginaCadastro.Size = new System.Drawing.Size(87, 33);
            this.btnVoltarPaginaCadastro.TabIndex = 7;
            this.btnVoltarPaginaCadastro.Text = "Voltar";
            this.btnVoltarPaginaCadastro.UseVisualStyleBackColor = false;
            this.btnVoltarPaginaCadastro.Click += new System.EventHandler(this.btnVoltarPaginaCadastro_Click);
            // 
            // panelEsquerdoPaginaCadastro
            // 
            this.panelEsquerdoPaginaCadastro.BackColor = System.Drawing.Color.Silver;
            this.panelEsquerdoPaginaCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerdoPaginaCadastro.Location = new System.Drawing.Point(0, 62);
            this.panelEsquerdoPaginaCadastro.Name = "panelEsquerdoPaginaCadastro";
            this.panelEsquerdoPaginaCadastro.Size = new System.Drawing.Size(189, 452);
            this.panelEsquerdoPaginaCadastro.TabIndex = 43;
            // 
            // panelDireitoPaginaCadastro
            // 
            this.panelDireitoPaginaCadastro.BackColor = System.Drawing.Color.Silver;
            this.panelDireitoPaginaCadastro.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDireitoPaginaCadastro.Location = new System.Drawing.Point(637, 62);
            this.panelDireitoPaginaCadastro.Name = "panelDireitoPaginaCadastro";
            this.panelDireitoPaginaCadastro.Size = new System.Drawing.Size(189, 452);
            this.panelDireitoPaginaCadastro.TabIndex = 44;
            // 
            // panelBottomPaginaCadastro
            // 
            this.panelBottomPaginaCadastro.BackColor = System.Drawing.Color.Silver;
            this.panelBottomPaginaCadastro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomPaginaCadastro.Location = new System.Drawing.Point(189, 427);
            this.panelBottomPaginaCadastro.Name = "panelBottomPaginaCadastro";
            this.panelBottomPaginaCadastro.Size = new System.Drawing.Size(448, 87);
            this.panelBottomPaginaCadastro.TabIndex = 45;
            this.panelBottomPaginaCadastro.Visible = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 514);
            this.Controls.Add(this.panelBottomPaginaCadastro);
            this.Controls.Add(this.panelDireitoPaginaCadastro);
            this.Controls.Add(this.panelEsquerdoPaginaCadastro);
            this.Controls.Add(this.btnVoltarPaginaCadastro);
            this.Controls.Add(this.btnCadastrarUser);
            this.Controls.Add(this.txtBoxRepitaSenha);
            this.Controls.Add(this.lblPaginaCadastro);
            this.Controls.Add(this.txtBoxApelido);
            this.Controls.Add(this.txtBoxSenha);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblApelidoPaginaCadastro);
            this.Controls.Add(this.lblEmailPaginaCadastro);
            this.Controls.Add(this.lblSenhaPaginaCadastro);
            this.Controls.Add(this.lblRepitaSenhaPaginaCadastro);
            this.Controls.Add(this.TelefonePaginaCadastro);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.txtBoxTelefone);
            this.Controls.Add(this.lblNomePaginaCadastro);
            this.Controls.Add(this.panelSuperiorUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panelSuperiorUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPaginaCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperiorUser;
        private System.Windows.Forms.Label lblPaginaCadastro;
        private System.Windows.Forms.Label lblNomePaginaCadastro;
        private System.Windows.Forms.MaskedTextBox txtBoxTelefone;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label TelefonePaginaCadastro;
        private System.Windows.Forms.Label lblRepitaSenhaPaginaCadastro;
        private System.Windows.Forms.Label lblSenhaPaginaCadastro;
        private System.Windows.Forms.Label lblEmailPaginaCadastro;
        private System.Windows.Forms.Label lblApelidoPaginaCadastro;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.TextBox txtBoxApelido;
        private System.Windows.Forms.TextBox txtBoxRepitaSenha;
        private System.Windows.Forms.Button btnCadastrarUser;
        private System.Windows.Forms.Button btnVoltarPaginaCadastro;
        private System.Windows.Forms.PictureBox pbLogoPaginaCadastro;
        private System.Windows.Forms.Panel panelEsquerdoPaginaCadastro;
        private System.Windows.Forms.Panel panelDireitoPaginaCadastro;
        private System.Windows.Forms.Panel panelBottomPaginaCadastro;
    }
}