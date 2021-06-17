
namespace Xpaco.view
{
    partial class Personagem
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btListar = new System.Windows.Forms.Button();
            this.listViewXpaco = new System.Windows.Forms.ListView();
            this.cHindice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldDesc = new System.Windows.Forms.TextBox();
            this.btlAtualiza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(84, 83);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 17);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(161, 80);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(275, 23);
            this.txtDescricao.TabIndex = 2;
            // 
            // btListar
            // 
            this.btListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.Location = new System.Drawing.Point(663, 139);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(100, 23);
            this.btListar.TabIndex = 4;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // listViewXpaco
            // 
            this.listViewXpaco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHindice,
            this.chId,
            this.cHDescricao});
            this.listViewXpaco.HideSelection = false;
            this.listViewXpaco.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listViewXpaco.Location = new System.Drawing.Point(79, 168);
            this.listViewXpaco.Name = "listViewXpaco";
            this.listViewXpaco.Size = new System.Drawing.Size(684, 198);
            this.listViewXpaco.TabIndex = 5;
            this.listViewXpaco.UseCompatibleStateImageBehavior = false;
            this.listViewXpaco.View = System.Windows.Forms.View.Details;
            // 
            // cHindice
            // 
            this.cHindice.Text = "Id";
            this.cHindice.Width = 50;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            // 
            // cHDescricao
            // 
            this.cHDescricao.Text = "Descrição";
            this.cHDescricao.Width = 200;
            // 
            // btIncluir
            // 
            this.btIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluir.Location = new System.Drawing.Point(557, 139);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(100, 23);
            this.btIncluir.TabIndex = 4;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Módulo de Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição Antiga";
            // 
            // txtOldDesc
            // 
            this.txtOldDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldDesc.Location = new System.Drawing.Point(161, 109);
            this.txtOldDesc.Name = "txtOldDesc";
            this.txtOldDesc.Size = new System.Drawing.Size(275, 23);
            this.txtOldDesc.TabIndex = 2;
            // 
            // btlAtualiza
            // 
            this.btlAtualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlAtualiza.Location = new System.Drawing.Point(451, 139);
            this.btlAtualiza.Name = "btlAtualiza";
            this.btlAtualiza.Size = new System.Drawing.Size(100, 23);
            this.btlAtualiza.TabIndex = 4;
            this.btlAtualiza.Text = "Alterar";
            this.btlAtualiza.UseVisualStyleBackColor = true;
            this.btlAtualiza.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // Personagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewXpaco);
            this.Controls.Add(this.btlAtualiza);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.txtOldDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Name = "Personagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.ListView listViewXpaco;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.ColumnHeader cHindice;
        private System.Windows.Forms.ColumnHeader cHDescricao;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldDesc;
        private System.Windows.Forms.Button btlAtualiza;
    }
}