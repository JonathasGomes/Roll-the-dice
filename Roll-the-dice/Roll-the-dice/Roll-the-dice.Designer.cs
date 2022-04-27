
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
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pbScoreNumberP1 = new System.Windows.Forms.PictureBox();
            this.pbScoreNumberP2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRollP1 = new System.Windows.Forms.Button();
            this.btnRollP2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoreNumberP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoreNumberP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDice_1
            // 
            this.pbDice_1.BackColor = System.Drawing.Color.Transparent;
            this.pbDice_1.Image = global::Roll_the_dice.Properties.Resources.dado_0;
            this.pbDice_1.Location = new System.Drawing.Point(90, 250);
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
            this.pbDice_2.Location = new System.Drawing.Point(381, 250);
            this.pbDice_2.Name = "pbDice_2";
            this.pbDice_2.Size = new System.Drawing.Size(44, 43);
            this.pbDice_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDice_2.TabIndex = 1;
            this.pbDice_2.TabStop = false;
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
            // pbScoreNumberP1
            // 
            this.pbScoreNumberP1.BackColor = System.Drawing.Color.Transparent;
            this.pbScoreNumberP1.Image = global::Roll_the_dice.Properties.Resources.numero_0;
            this.pbScoreNumberP1.Location = new System.Drawing.Point(170, 117);
            this.pbScoreNumberP1.Name = "pbScoreNumberP1";
            this.pbScoreNumberP1.Size = new System.Drawing.Size(20, 28);
            this.pbScoreNumberP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbScoreNumberP1.TabIndex = 16;
            this.pbScoreNumberP1.TabStop = false;
            // 
            // pbScoreNumberP2
            // 
            this.pbScoreNumberP2.BackColor = System.Drawing.Color.Transparent;
            this.pbScoreNumberP2.Image = global::Roll_the_dice.Properties.Resources.numero_0;
            this.pbScoreNumberP2.Location = new System.Drawing.Point(463, 117);
            this.pbScoreNumberP2.Name = "pbScoreNumberP2";
            this.pbScoreNumberP2.Size = new System.Drawing.Size(20, 28);
            this.pbScoreNumberP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbScoreNumberP2.TabIndex = 17;
            this.pbScoreNumberP2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Roll_the_dice.Properties.Resources.p1_turn;
            this.pictureBox1.Location = new System.Drawing.Point(203, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnRollP1
            // 
            this.btnRollP1.BackgroundImage = global::Roll_the_dice.Properties.Resources.roll_branco_;
            this.btnRollP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRollP1.FlatAppearance.BorderSize = 0;
            this.btnRollP1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRollP1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRollP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollP1.Location = new System.Drawing.Point(64, 349);
            this.btnRollP1.Name = "btnRollP1";
            this.btnRollP1.Size = new System.Drawing.Size(96, 32);
            this.btnRollP1.TabIndex = 22;
            this.btnRollP1.UseVisualStyleBackColor = true;
            this.btnRollP1.Click += new System.EventHandler(this.Clicks);
            // 
            // btnRollP2
            // 
            this.btnRollP2.BackgroundImage = global::Roll_the_dice.Properties.Resources.roll_branco_;
            this.btnRollP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRollP2.FlatAppearance.BorderSize = 0;
            this.btnRollP2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRollP2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRollP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollP2.Location = new System.Drawing.Point(360, 349);
            this.btnRollP2.Name = "btnRollP2";
            this.btnRollP2.Size = new System.Drawing.Size(96, 32);
            this.btnRollP2.TabIndex = 23;
            this.btnRollP2.UseVisualStyleBackColor = true;
            this.btnRollP2.Click += new System.EventHandler(this.Clicks);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::Roll_the_dice.Properties.Resources.reset_branco_;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(206, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 32);
            this.btnReset.TabIndex = 24;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImage = global::Roll_the_dice.Properties.Resources.botao_ok;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(333, 69);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(37, 23);
            this.btnOK.TabIndex = 25;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.Newgame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 451);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRollP2);
            this.Controls.Add(this.btnRollP1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbScoreNumberP2);
            this.Controls.Add(this.pbScoreNumberP1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbDice_2);
            this.Controls.Add(this.pbDice_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoreNumberP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScoreNumberP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDice_1;
        private System.Windows.Forms.PictureBox pbDice_2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox pbScoreNumberP1;
        private System.Windows.Forms.PictureBox pbScoreNumberP2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRollP1;
        private System.Windows.Forms.Button btnRollP2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOK;
    }
}

