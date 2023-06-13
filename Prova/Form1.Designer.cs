namespace Prova
{
    partial class Form1
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
            this.bt_correcao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_correcao
            // 
            this.bt_correcao.Location = new System.Drawing.Point(344, 295);
            this.bt_correcao.Name = "bt_correcao";
            this.bt_correcao.Size = new System.Drawing.Size(75, 23);
            this.bt_correcao.TabIndex = 0;
            this.bt_correcao.Text = "Correção";
            this.bt_correcao.UseVisualStyleBackColor = true;
            this.bt_correcao.Click += new System.EventHandler(this.bt_correcao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_correcao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_correcao;
    }
}

