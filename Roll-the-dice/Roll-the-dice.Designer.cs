
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbDice_1 = new System.Windows.Forms.PictureBox();
            this.pbDice_2 = new System.Windows.Forms.PictureBox();
            this.lblScoreP1 = new System.Windows.Forms.Label();
            this.lblScoreP2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.btnPlay2 = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDice_1
            // 
            this.pbDice_1.BackColor = System.Drawing.Color.Transparent;
            this.pbDice_1.Image = global::Roll_the_dice.Properties.Resources.dado_0;
            this.pbDice_1.Location = new System.Drawing.Point(58, 192);
            this.pbDice_1.Name = "pbDice_1";
            this.pbDice_1.Size = new System.Drawing.Size(44, 43);
            this.pbDice_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDice_1.TabIndex = 0;
            this.pbDice_1.TabStop = false;
            // 
            // pbDice_2
            // 
            this.pbDice_2.BackColor = System.Drawing.Color.Transparent;
            this.pbDice_2.Image = global::Roll_the_dice.Properties.Resources.dado_0;
            this.pbDice_2.Location = new System.Drawing.Point(389, 192);
            this.pbDice_2.Name = "pbDice_2";
            this.pbDice_2.Size = new System.Drawing.Size(44, 43);
            this.pbDice_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDice_2.TabIndex = 1;
            this.pbDice_2.TabStop = false;
            // 
            // lblScoreP1
            // 
            this.lblScoreP1.AutoSize = true;
            this.lblScoreP1.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP1.Location = new System.Drawing.Point(42, 87);
            this.lblScoreP1.Name = "lblScoreP1";
            this.lblScoreP1.Size = new System.Drawing.Size(82, 29);
            this.lblScoreP1.TabIndex = 2;
            this.lblScoreP1.Text = "Score";
            // 
            // lblScoreP2
            // 
            this.lblScoreP2.AutoSize = true;
            this.lblScoreP2.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP2.Location = new System.Drawing.Point(369, 87);
            this.lblScoreP2.Name = "lblScoreP2";
            this.lblScoreP2.Size = new System.Drawing.Size(82, 29);
            this.lblScoreP2.TabIndex = 3;
            this.lblScoreP2.Text = "Score";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(54, 142);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(386, 142);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Player 2";
            // 
            // btnPlay1
            // 
            this.btnPlay1.Location = new System.Drawing.Point(47, 312);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(104, 41);
            this.btnPlay1.TabIndex = 6;
            this.btnPlay1.Text = "PLAY!";
            this.btnPlay1.UseVisualStyleBackColor = true;
            this.btnPlay1.Click += new System.EventHandler(this.Clicks);
            // 
            // btnPlay2
            // 
            this.btnPlay2.Location = new System.Drawing.Point(374, 312);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(102, 41);
            this.btnPlay2.TabIndex = 7;
            this.btnPlay2.Text = "PLAY!";
            this.btnPlay2.UseVisualStyleBackColor = true;
            this.btnPlay2.Click += new System.EventHandler(this.Clicks);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(180, 33);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(113, 33);
            this.lblWinner.TabIndex = 8;
            this.lblWinner.Text = "Winner";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(196, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(124, 39);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(472, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 24);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Location = new System.Drawing.Point(440, 22);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 24);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblScoreP2);
            this.Controls.Add(this.lblScoreP1);
            this.Controls.Add(this.pbDice_2);
            this.Controls.Add(this.pbDice_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDice_1;
        private System.Windows.Forms.PictureBox pbDice_2;
        private System.Windows.Forms.Label lblScoreP1;
        private System.Windows.Forms.Label lblScoreP2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Button btnPlay2;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
    }
}

