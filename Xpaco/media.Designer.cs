
namespace Xpaco
{
    partial class media
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(media));
            this.panelPaginaMidia = new System.Windows.Forms.Panel();
            this.lblPaginaMidia = new System.Windows.Forms.Label();
            this.pbPaginaMidia = new System.Windows.Forms.PictureBox();
            this.lblDescricaoPaginaMidia = new System.Windows.Forms.Label();
            this.lblUrlPaginaMidia = new System.Windows.Forms.Label();
            this.txtUrlPaginaMidia = new System.Windows.Forms.TextBox();
            this.txtDescricaoPaginaMidia = new System.Windows.Forms.TextBox();
            this.btnSalvarPaginaMidia = new System.Windows.Forms.Button();
            this.btnVoltarPaginaMidia = new System.Windows.Forms.Button();
            this.panelPaginaMidia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaginaMidia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPaginaMidia
            // 
            this.panelPaginaMidia.BackColor = System.Drawing.SystemColors.Control;
            this.panelPaginaMidia.Controls.Add(this.lblPaginaMidia);
            this.panelPaginaMidia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaginaMidia.Location = new System.Drawing.Point(0, 0);
            this.panelPaginaMidia.Name = "panelPaginaMidia";
            this.panelPaginaMidia.Size = new System.Drawing.Size(941, 80);
            this.panelPaginaMidia.TabIndex = 1;
            // 
            // lblPaginaMidia
            // 
            this.lblPaginaMidia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPaginaMidia.AutoSize = true;
            this.lblPaginaMidia.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaginaMidia.Location = new System.Drawing.Point(403, 33);
            this.lblPaginaMidia.Name = "lblPaginaMidia";
            this.lblPaginaMidia.Size = new System.Drawing.Size(130, 23);
            this.lblPaginaMidia.TabIndex = 1;
            this.lblPaginaMidia.Text = "Página de mídia";
            // 
            // pbPaginaMidia
            // 
            this.pbPaginaMidia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPaginaMidia.Image = ((System.Drawing.Image)(resources.GetObject("pbPaginaMidia.Image")));
            this.pbPaginaMidia.Location = new System.Drawing.Point(287, 156);
            this.pbPaginaMidia.Name = "pbPaginaMidia";
            this.pbPaginaMidia.Size = new System.Drawing.Size(100, 53);
            this.pbPaginaMidia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPaginaMidia.TabIndex = 2;
            this.pbPaginaMidia.TabStop = false;
            // 
            // lblDescricaoPaginaMidia
            // 
            this.lblDescricaoPaginaMidia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescricaoPaginaMidia.AutoSize = true;
            this.lblDescricaoPaginaMidia.Location = new System.Drawing.Point(403, 156);
            this.lblDescricaoPaginaMidia.Name = "lblDescricaoPaginaMidia";
            this.lblDescricaoPaginaMidia.Size = new System.Drawing.Size(61, 15);
            this.lblDescricaoPaginaMidia.TabIndex = 3;
            this.lblDescricaoPaginaMidia.Text = "Descrição:";
            this.lblDescricaoPaginaMidia.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUrlPaginaMidia
            // 
            this.lblUrlPaginaMidia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUrlPaginaMidia.AutoSize = true;
            this.lblUrlPaginaMidia.Location = new System.Drawing.Point(403, 194);
            this.lblUrlPaginaMidia.Name = "lblUrlPaginaMidia";
            this.lblUrlPaginaMidia.Size = new System.Drawing.Size(25, 15);
            this.lblUrlPaginaMidia.TabIndex = 4;
            this.lblUrlPaginaMidia.Text = "Url:";
            // 
            // txtUrlPaginaMidia
            // 
            this.txtUrlPaginaMidia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUrlPaginaMidia.Location = new System.Drawing.Point(470, 186);
            this.txtUrlPaginaMidia.Name = "txtUrlPaginaMidia";
            this.txtUrlPaginaMidia.Size = new System.Drawing.Size(183, 23);
            this.txtUrlPaginaMidia.TabIndex = 5;
            // 
            // txtDescricaoPaginaMidia
            // 
            this.txtDescricaoPaginaMidia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricaoPaginaMidia.Location = new System.Drawing.Point(470, 148);
            this.txtDescricaoPaginaMidia.Name = "txtDescricaoPaginaMidia";
            this.txtDescricaoPaginaMidia.Size = new System.Drawing.Size(183, 23);
            this.txtDescricaoPaginaMidia.TabIndex = 6;
            // 
            // btnSalvarPaginaMidia
            // 
            this.btnSalvarPaginaMidia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarPaginaMidia.BackColor = System.Drawing.Color.Gray;
            this.btnSalvarPaginaMidia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarPaginaMidia.Location = new System.Drawing.Point(551, 279);
            this.btnSalvarPaginaMidia.Name = "btnSalvarPaginaMidia";
            this.btnSalvarPaginaMidia.Size = new System.Drawing.Size(102, 38);
            this.btnSalvarPaginaMidia.TabIndex = 26;
            this.btnSalvarPaginaMidia.Text = "Salvar";
            this.btnSalvarPaginaMidia.UseVisualStyleBackColor = false;
            // 
            // btnVoltarPaginaMidia
            // 
            this.btnVoltarPaginaMidia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltarPaginaMidia.BackColor = System.Drawing.Color.Gray;
            this.btnVoltarPaginaMidia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarPaginaMidia.Location = new System.Drawing.Point(285, 279);
            this.btnVoltarPaginaMidia.Name = "btnVoltarPaginaMidia";
            this.btnVoltarPaginaMidia.Size = new System.Drawing.Size(102, 38);
            this.btnVoltarPaginaMidia.TabIndex = 42;
            this.btnVoltarPaginaMidia.Text = "Voltar";
            this.btnVoltarPaginaMidia.UseVisualStyleBackColor = false;
            // 
            // media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 460);
            this.Controls.Add(this.btnVoltarPaginaMidia);
            this.Controls.Add(this.btnSalvarPaginaMidia);
            this.Controls.Add(this.txtDescricaoPaginaMidia);
            this.Controls.Add(this.txtUrlPaginaMidia);
            this.Controls.Add(this.lblUrlPaginaMidia);
            this.Controls.Add(this.lblDescricaoPaginaMidia);
            this.Controls.Add(this.pbPaginaMidia);
            this.Controls.Add(this.panelPaginaMidia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "media";
            this.Text = "media";
            this.panelPaginaMidia.ResumeLayout(false);
            this.panelPaginaMidia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaginaMidia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPaginaMidia;
        private System.Windows.Forms.Label lblPaginaMidia;
        private System.Windows.Forms.PictureBox pbPaginaMidia;
        private System.Windows.Forms.Label lblDescricaoPaginaMidia;
        private System.Windows.Forms.Label lblUrlPaginaMidia;
        private System.Windows.Forms.TextBox txtUrlPaginaMidia;
        private System.Windows.Forms.TextBox txtDescricaoPaginaMidia;
        private System.Windows.Forms.Button btnSalvarPaginaMidia;
        private System.Windows.Forms.Button btnVoltarPaginaMidia;
    }
}