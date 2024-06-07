
namespace Xpaco.view
{
    partial class ValidaJson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCampo1 = new System.Windows.Forms.TextBox();
            this.textCampo2 = new System.Windows.Forms.TextBox();
            this.textCampo3 = new System.Windows.Forms.TextBox();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnDesserializar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Campo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Campo 3";
            // 
            // textCampo1
            // 
            this.textCampo1.Location = new System.Drawing.Point(115, 31);
            this.textCampo1.Name = "textCampo1";
            this.textCampo1.Size = new System.Drawing.Size(322, 20);
            this.textCampo1.TabIndex = 3;
            // 
            // textCampo2
            // 
            this.textCampo2.Location = new System.Drawing.Point(116, 72);
            this.textCampo2.Name = "textCampo2";
            this.textCampo2.Size = new System.Drawing.Size(322, 20);
            this.textCampo2.TabIndex = 4;
            // 
            // textCampo3
            // 
            this.textCampo3.Location = new System.Drawing.Point(115, 106);
            this.textCampo3.Name = "textCampo3";
            this.textCampo3.Size = new System.Drawing.Size(322, 20);
            this.textCampo3.TabIndex = 5;
            // 
            // btnSerializar
            // 
            this.btnSerializar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializar.Location = new System.Drawing.Point(65, 162);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(151, 43);
            this.btnSerializar.TabIndex = 6;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnDesserializar
            // 
            this.btnDesserializar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesserializar.Location = new System.Drawing.Point(289, 162);
            this.btnDesserializar.Name = "btnDesserializar";
            this.btnDesserializar.Size = new System.Drawing.Size(151, 43);
            this.btnDesserializar.TabIndex = 7;
            this.btnDesserializar.Text = "Desserializar";
            this.btnDesserializar.UseVisualStyleBackColor = true;
            this.btnDesserializar.Click += new System.EventHandler(this.btnDesserializar_Click);
            // 
            // ValidaJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 309);
            this.Controls.Add(this.btnDesserializar);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.textCampo3);
            this.Controls.Add(this.textCampo2);
            this.Controls.Add(this.textCampo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ValidaJson";
            this.Text = "ValidaJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCampo1;
        private System.Windows.Forms.TextBox textCampo2;
        private System.Windows.Forms.TextBox textCampo3;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnDesserializar;
    }
}