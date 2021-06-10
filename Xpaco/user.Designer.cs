
namespace Xpaco
{
    partial class user
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
            this.panelSuperiorUser = new System.Windows.Forms.Panel();
            this.lblPaginaCadastro = new System.Windows.Forms.Label();
            this.lblNomePaginaCadastro = new System.Windows.Forms.Label();
            this.mtbTelefonePaginaCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCompletoPaginaCadastro = new System.Windows.Forms.TextBox();
            this.TelefonePaginaCadastro = new System.Windows.Forms.Label();
            this.lblRepitaSenhaPaginaCadastro = new System.Windows.Forms.Label();
            this.lblSenhaPaginaCadastro = new System.Windows.Forms.Label();
            this.lblEmailPaginaCadastro = new System.Windows.Forms.Label();
            this.lblApelidoPaginaCadastro = new System.Windows.Forms.Label();
            this.txtEmailPaginaCadastro = new System.Windows.Forms.TextBox();
            this.txtSenhaPaginaCadastro = new System.Windows.Forms.TextBox();
            this.txtApelidoPaginaCadastro = new System.Windows.Forms.TextBox();
            this.txtRepitaSenhaPaginaCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrarPaginaCadastro = new System.Windows.Forms.Button();
            this.btnVoltarPaginaCadastro = new System.Windows.Forms.Button();
            this.panelSuperiorUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperiorUser
            // 
            this.panelSuperiorUser.BackColor = System.Drawing.Color.Gray;
            this.panelSuperiorUser.Controls.Add(this.lblPaginaCadastro);
            this.panelSuperiorUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperiorUser.Location = new System.Drawing.Point(0, 0);
            this.panelSuperiorUser.Name = "panelSuperiorUser";
            this.panelSuperiorUser.Size = new System.Drawing.Size(800, 80);
            this.panelSuperiorUser.TabIndex = 0;
            // 
            // lblPaginaCadastro
            // 
            this.lblPaginaCadastro.AutoSize = true;
            this.lblPaginaCadastro.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaginaCadastro.Location = new System.Drawing.Point(239, 30);
            this.lblPaginaCadastro.Name = "lblPaginaCadastro";
            this.lblPaginaCadastro.Size = new System.Drawing.Size(156, 23);
            this.lblPaginaCadastro.TabIndex = 1;
            this.lblPaginaCadastro.Text = "Página de cadastro";
            // 
            // lblNomePaginaCadastro
            // 
            this.lblNomePaginaCadastro.AutoSize = true;
            this.lblNomePaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomePaginaCadastro.Location = new System.Drawing.Point(92, 117);
            this.lblNomePaginaCadastro.Name = "lblNomePaginaCadastro";
            this.lblNomePaginaCadastro.Size = new System.Drawing.Size(138, 19);
            this.lblNomePaginaCadastro.TabIndex = 1;
            this.lblNomePaginaCadastro.Text = "Nome Completo:";
            // 
            // mtbTelefonePaginaCadastro
            // 
            this.mtbTelefonePaginaCadastro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbTelefonePaginaCadastro.Location = new System.Drawing.Point(239, 289);
            this.mtbTelefonePaginaCadastro.Mask = "(00) 00000-0000";
            this.mtbTelefonePaginaCadastro.Name = "mtbTelefonePaginaCadastro";
            this.mtbTelefonePaginaCadastro.Size = new System.Drawing.Size(118, 27);
            this.mtbTelefonePaginaCadastro.TabIndex = 2;
            this.mtbTelefonePaginaCadastro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtNomeCompletoPaginaCadastro
            // 
            this.txtNomeCompletoPaginaCadastro.Location = new System.Drawing.Point(239, 113);
            this.txtNomeCompletoPaginaCadastro.Name = "txtNomeCompletoPaginaCadastro";
            this.txtNomeCompletoPaginaCadastro.Size = new System.Drawing.Size(273, 23);
            this.txtNomeCompletoPaginaCadastro.TabIndex = 3;
            // 
            // TelefonePaginaCadastro
            // 
            this.TelefonePaginaCadastro.AutoSize = true;
            this.TelefonePaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TelefonePaginaCadastro.Location = new System.Drawing.Point(92, 297);
            this.TelefonePaginaCadastro.Name = "TelefonePaginaCadastro";
            this.TelefonePaginaCadastro.Size = new System.Drawing.Size(80, 19);
            this.TelefonePaginaCadastro.TabIndex = 4;
            this.TelefonePaginaCadastro.Text = "Telefone:";
            // 
            // lblRepitaSenhaPaginaCadastro
            // 
            this.lblRepitaSenhaPaginaCadastro.AutoSize = true;
            this.lblRepitaSenhaPaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepitaSenhaPaginaCadastro.Location = new System.Drawing.Point(92, 259);
            this.lblRepitaSenhaPaginaCadastro.Name = "lblRepitaSenhaPaginaCadastro";
            this.lblRepitaSenhaPaginaCadastro.Size = new System.Drawing.Size(128, 19);
            this.lblRepitaSenhaPaginaCadastro.TabIndex = 5;
            this.lblRepitaSenhaPaginaCadastro.Text = "Repita a senha:";
            // 
            // lblSenhaPaginaCadastro
            // 
            this.lblSenhaPaginaCadastro.AutoSize = true;
            this.lblSenhaPaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenhaPaginaCadastro.Location = new System.Drawing.Point(92, 223);
            this.lblSenhaPaginaCadastro.Name = "lblSenhaPaginaCadastro";
            this.lblSenhaPaginaCadastro.Size = new System.Drawing.Size(64, 19);
            this.lblSenhaPaginaCadastro.TabIndex = 6;
            this.lblSenhaPaginaCadastro.Text = "Senha:";
            this.lblSenhaPaginaCadastro.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblEmailPaginaCadastro
            // 
            this.lblEmailPaginaCadastro.AutoSize = true;
            this.lblEmailPaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailPaginaCadastro.Location = new System.Drawing.Point(92, 191);
            this.lblEmailPaginaCadastro.Name = "lblEmailPaginaCadastro";
            this.lblEmailPaginaCadastro.Size = new System.Drawing.Size(62, 19);
            this.lblEmailPaginaCadastro.TabIndex = 7;
            this.lblEmailPaginaCadastro.Text = "E-mail:";
            // 
            // lblApelidoPaginaCadastro
            // 
            this.lblApelidoPaginaCadastro.AutoSize = true;
            this.lblApelidoPaginaCadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApelidoPaginaCadastro.Location = new System.Drawing.Point(92, 153);
            this.lblApelidoPaginaCadastro.Name = "lblApelidoPaginaCadastro";
            this.lblApelidoPaginaCadastro.Size = new System.Drawing.Size(73, 19);
            this.lblApelidoPaginaCadastro.TabIndex = 8;
            this.lblApelidoPaginaCadastro.Text = "Apelido:";
            // 
            // txtEmailPaginaCadastro
            // 
            this.txtEmailPaginaCadastro.Location = new System.Drawing.Point(239, 187);
            this.txtEmailPaginaCadastro.Name = "txtEmailPaginaCadastro";
            this.txtEmailPaginaCadastro.Size = new System.Drawing.Size(273, 23);
            this.txtEmailPaginaCadastro.TabIndex = 9;
            // 
            // txtSenhaPaginaCadastro
            // 
            this.txtSenhaPaginaCadastro.Location = new System.Drawing.Point(239, 223);
            this.txtSenhaPaginaCadastro.Name = "txtSenhaPaginaCadastro";
            this.txtSenhaPaginaCadastro.Size = new System.Drawing.Size(273, 23);
            this.txtSenhaPaginaCadastro.TabIndex = 10;
            // 
            // txtApelidoPaginaCadastro
            // 
            this.txtApelidoPaginaCadastro.Location = new System.Drawing.Point(239, 149);
            this.txtApelidoPaginaCadastro.Name = "txtApelidoPaginaCadastro";
            this.txtApelidoPaginaCadastro.Size = new System.Drawing.Size(273, 23);
            this.txtApelidoPaginaCadastro.TabIndex = 11;
            // 
            // txtRepitaSenhaPaginaCadastro
            // 
            this.txtRepitaSenhaPaginaCadastro.Location = new System.Drawing.Point(239, 255);
            this.txtRepitaSenhaPaginaCadastro.Name = "txtRepitaSenhaPaginaCadastro";
            this.txtRepitaSenhaPaginaCadastro.Size = new System.Drawing.Size(273, 23);
            this.txtRepitaSenhaPaginaCadastro.TabIndex = 12;
            // 
            // btnCadastrarPaginaCadastro
            // 
            this.btnCadastrarPaginaCadastro.BackColor = System.Drawing.Color.Gray;
            this.btnCadastrarPaginaCadastro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarPaginaCadastro.Location = new System.Drawing.Point(410, 362);
            this.btnCadastrarPaginaCadastro.Name = "btnCadastrarPaginaCadastro";
            this.btnCadastrarPaginaCadastro.Size = new System.Drawing.Size(102, 38);
            this.btnCadastrarPaginaCadastro.TabIndex = 13;
            this.btnCadastrarPaginaCadastro.Text = "Cadastrar";
            this.btnCadastrarPaginaCadastro.UseVisualStyleBackColor = false;
            this.btnCadastrarPaginaCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltarPaginaCadastro
            // 
            this.btnVoltarPaginaCadastro.BackColor = System.Drawing.Color.Gray;
            this.btnVoltarPaginaCadastro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarPaginaCadastro.Location = new System.Drawing.Point(92, 362);
            this.btnVoltarPaginaCadastro.Name = "btnVoltarPaginaCadastro";
            this.btnVoltarPaginaCadastro.Size = new System.Drawing.Size(102, 38);
            this.btnVoltarPaginaCadastro.TabIndex = 42;
            this.btnVoltarPaginaCadastro.Text = "Voltar";
            this.btnVoltarPaginaCadastro.UseVisualStyleBackColor = false;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.btnVoltarPaginaCadastro);
            this.Controls.Add(this.btnCadastrarPaginaCadastro);
            this.Controls.Add(this.txtRepitaSenhaPaginaCadastro);
            this.Controls.Add(this.txtApelidoPaginaCadastro);
            this.Controls.Add(this.txtSenhaPaginaCadastro);
            this.Controls.Add(this.txtEmailPaginaCadastro);
            this.Controls.Add(this.lblApelidoPaginaCadastro);
            this.Controls.Add(this.lblEmailPaginaCadastro);
            this.Controls.Add(this.lblSenhaPaginaCadastro);
            this.Controls.Add(this.lblRepitaSenhaPaginaCadastro);
            this.Controls.Add(this.TelefonePaginaCadastro);
            this.Controls.Add(this.txtNomeCompletoPaginaCadastro);
            this.Controls.Add(this.mtbTelefonePaginaCadastro);
            this.Controls.Add(this.lblNomePaginaCadastro);
            this.Controls.Add(this.panelSuperiorUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user";
            this.Text = "cadastro";
            this.Load += new System.EventHandler(this.user_Load);
            this.panelSuperiorUser.ResumeLayout(false);
            this.panelSuperiorUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperiorUser;
        private System.Windows.Forms.Label lblPaginaCadastro;
        private System.Windows.Forms.Label lblNomePaginaCadastro;
        private System.Windows.Forms.MaskedTextBox mtbTelefonePaginaCadastro;
        private System.Windows.Forms.TextBox txtNomeCompletoPaginaCadastro;
        private System.Windows.Forms.Label TelefonePaginaCadastro;
        private System.Windows.Forms.Label lblRepitaSenhaPaginaCadastro;
        private System.Windows.Forms.Label lblSenhaPaginaCadastro;
        private System.Windows.Forms.Label lblEmailPaginaCadastro;
        private System.Windows.Forms.Label lblApelidoPaginaCadastro;
        private System.Windows.Forms.TextBox txtEmailPaginaCadastro;
        private System.Windows.Forms.TextBox txtSenhaPaginaCadastro;
        private System.Windows.Forms.TextBox txtApelidoPaginaCadastro;
        private System.Windows.Forms.TextBox txtRepitaSenhaPaginaCadastro;
        private System.Windows.Forms.Button btnCadastrarPaginaCadastro;
        private System.Windows.Forms.Button btnVoltarPaginaCadastro;
    }
}