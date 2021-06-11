
namespace Xpaco
{
    partial class login
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
            this.panelPaginaLogin = new System.Windows.Forms.Panel();
            this.lblPaginaLogin = new System.Windows.Forms.Label();
            this.txtSenhaPaginaLogin = new System.Windows.Forms.TextBox();
            this.txtEmailPaginaLogin = new System.Windows.Forms.TextBox();
            this.lblSenhaPaginaLogin = new System.Windows.Forms.Label();
            this.lblEmailPaginaLogin = new System.Windows.Forms.Label();
            this.btnLogarPaginaLogin = new System.Windows.Forms.Button();
            this.panelPaginaLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPaginaLogin
            // 
            this.panelPaginaLogin.BackColor = System.Drawing.Color.Gray;
            this.panelPaginaLogin.Controls.Add(this.lblPaginaLogin);
            this.panelPaginaLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaginaLogin.Location = new System.Drawing.Point(0, 0);
            this.panelPaginaLogin.Name = "panelPaginaLogin";
            this.panelPaginaLogin.Size = new System.Drawing.Size(544, 80);
            this.panelPaginaLogin.TabIndex = 2;
            // 
            // lblPaginaLogin
            // 
            this.lblPaginaLogin.AutoSize = true;
            this.lblPaginaLogin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaginaLogin.Location = new System.Drawing.Point(204, 29);
            this.lblPaginaLogin.Name = "lblPaginaLogin";
            this.lblPaginaLogin.Size = new System.Drawing.Size(127, 23);
            this.lblPaginaLogin.TabIndex = 1;
            this.lblPaginaLogin.Text = "Página de login";
            // 
            // txtSenhaPaginaLogin
            // 
            this.txtSenhaPaginaLogin.Location = new System.Drawing.Point(293, 177);
            this.txtSenhaPaginaLogin.Name = "txtSenhaPaginaLogin";
            this.txtSenhaPaginaLogin.Size = new System.Drawing.Size(162, 23);
            this.txtSenhaPaginaLogin.TabIndex = 3;
            // 
            // txtEmailPaginaLogin
            // 
            this.txtEmailPaginaLogin.Location = new System.Drawing.Point(293, 123);
            this.txtEmailPaginaLogin.Name = "txtEmailPaginaLogin";
            this.txtEmailPaginaLogin.Size = new System.Drawing.Size(162, 23);
            this.txtEmailPaginaLogin.TabIndex = 4;
            // 
            // lblSenhaPaginaLogin
            // 
            this.lblSenhaPaginaLogin.AutoSize = true;
            this.lblSenhaPaginaLogin.Location = new System.Drawing.Point(229, 185);
            this.lblSenhaPaginaLogin.Name = "lblSenhaPaginaLogin";
            this.lblSenhaPaginaLogin.Size = new System.Drawing.Size(42, 15);
            this.lblSenhaPaginaLogin.TabIndex = 5;
            this.lblSenhaPaginaLogin.Text = "Senha:";
            // 
            // lblEmailPaginaLogin
            // 
            this.lblEmailPaginaLogin.AutoSize = true;
            this.lblEmailPaginaLogin.Location = new System.Drawing.Point(229, 131);
            this.lblEmailPaginaLogin.Name = "lblEmailPaginaLogin";
            this.lblEmailPaginaLogin.Size = new System.Drawing.Size(44, 15);
            this.lblEmailPaginaLogin.TabIndex = 6;
            this.lblEmailPaginaLogin.Text = "E-mail:";
            // 
            // btnLogarPaginaLogin
            // 
            this.btnLogarPaginaLogin.BackColor = System.Drawing.Color.Gray;
            this.btnLogarPaginaLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogarPaginaLogin.Location = new System.Drawing.Point(293, 236);
            this.btnLogarPaginaLogin.Name = "btnLogarPaginaLogin";
            this.btnLogarPaginaLogin.Size = new System.Drawing.Size(122, 31);
            this.btnLogarPaginaLogin.TabIndex = 38;
            this.btnLogarPaginaLogin.Text = "Logar";
            this.btnLogarPaginaLogin.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 359);
            this.Controls.Add(this.btnLogarPaginaLogin);
            this.Controls.Add(this.lblEmailPaginaLogin);
            this.Controls.Add(this.lblSenhaPaginaLogin);
            this.Controls.Add(this.txtEmailPaginaLogin);
            this.Controls.Add(this.txtSenhaPaginaLogin);
            this.Controls.Add(this.panelPaginaLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.panelPaginaLogin.ResumeLayout(false);
            this.panelPaginaLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPaginaLogin;
        private System.Windows.Forms.Label lblPaginaLogin;
        private System.Windows.Forms.TextBox txtSenhaPaginaLogin;
        private System.Windows.Forms.TextBox txtEmailPaginaLogin;
        private System.Windows.Forms.Label lblSenhaPaginaLogin;
        private System.Windows.Forms.Label lblEmailPaginaLogin;
        private System.Windows.Forms.Button btnLogarPaginaLogin;
    }
}