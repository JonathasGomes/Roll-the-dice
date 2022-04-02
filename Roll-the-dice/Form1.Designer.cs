
namespace Roll_the_dice
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
            this.pbDice_1 = new System.Windows.Forms.PictureBox();
            this.pbDice_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDice_1
            // 
            this.pbDice_1.Location = new System.Drawing.Point(228, 104);
            this.pbDice_1.Name = "pbDice_1";
            this.pbDice_1.Size = new System.Drawing.Size(102, 98);
            this.pbDice_1.TabIndex = 0;
            this.pbDice_1.TabStop = false;
            // 
            // pbDice_2
            // 
            this.pbDice_2.Location = new System.Drawing.Point(472, 104);
            this.pbDice_2.Name = "pbDice_2";
            this.pbDice_2.Size = new System.Drawing.Size(102, 98);
            this.pbDice_2.TabIndex = 1;
            this.pbDice_2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbDice_2);
            this.Controls.Add(this.pbDice_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDice_1;
        private System.Windows.Forms.PictureBox pbDice_2;
    }
}

