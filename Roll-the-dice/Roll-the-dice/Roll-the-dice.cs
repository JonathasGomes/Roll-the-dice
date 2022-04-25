﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_the_dice
{
    public partial class Form1 : Form
    {

        //Shift significa Turno.

        public Form1()
        {
            InitializeComponent();
            StartImages();
            UpdateButton();
            ScoreNumber();
        }

        int scorePlayer1, scorePlayer2, playPlayer1, playPlayer2, nr, clicks;
        bool shiftPlayer1 = true, endGame;
        Image[] imagesDice = new Image[7];
        Image[] imagesNumber = new Image[7]; 
        Random rdn = new Random();
        
        private void StartImages()
        {
            imagesDice[0] = Properties.Resources.dado_0;
            imagesDice[1] = Properties.Resources.dado_1;
            imagesDice[2] = Properties.Resources.dado_2;
            imagesDice[3] = Properties.Resources.dado_3;
            imagesDice[4] = Properties.Resources.dado_4;
            imagesDice[5] = Properties.Resources.dado_5;
            imagesDice[6] = Properties.Resources.dado_6;
        }
        private void ScoreNumber()
        {
            imagesNumber[0] = Properties.Resources.numero_0;
            imagesNumber[1] = Properties.Resources.numero_1;
            imagesNumber[2] = Properties.Resources.numero_2;
            imagesNumber[3] = Properties.Resources.numero_3;
            imagesNumber[4] = Properties.Resources.numero_4;
            imagesNumber[5] = Properties.Resources.numero_5;
            imagesNumber[6] = Properties.Resources.numero_6;
        }

        private void ChangeShift()
        {
            // "!" faz a variável shiftPlayer1 ter o valor inverso
            //A variavél shiftPlayer armazena o turno do jogador
            shiftPlayer1 = !shiftPlayer1;
        }

        private void UpdateButton()
        {
            btnReset.Enabled = endGame;

            btnRollP1.Enabled = shiftPlayer1 && !endGame;
            btnRollP2.Enabled = !shiftPlayer1 && !endGame;
            ColorButton();
        }

        private void ColorButton()
        {
            btnRollP1.BackgroundImage = btnRollP1.Enabled ? Properties.Resources.roll_vermelho_ : Properties.Resources.roll_branco_;
            btnRollP2.BackgroundImage = btnRollP2.Enabled ? Properties.Resources.roll_vermelho_ : Properties.Resources.roll_branco_;

            btnReset.BackgroundImage = btnReset.Enabled ? Properties.Resources.reset_vermelho_ : Properties.Resources.reset_branco_;
        }

        private void ChangeImage()
        {
            if (shiftPlayer1)
            {
                pbDice_1.Image = imagesDice[nr];
            }
            else
            {
                pbDice_2.Image = imagesDice[nr];
            }
        }


        //Esse método sorteia o número que vai cair no dado
        private void DrawValor()
        {
            //Esse código limita os números, o número maior que pode cair é 6, e o ++ faz que nunca caia no 0
            nr = (int)Math.Truncate((rdn.NextDouble() * 10) % 6);
            nr++;
            ChangeImage();
            EndRound();
        }

        private void ShowWinner()
        {
            endGame = true;

            lblWinner.Text += " " + string.Format(playPlayer1 > playPlayer2 ? "Player 1" :
                (playPlayer1 < playPlayer2 ? "Player 2" : "Empate!"));

            if(playPlayer1 > playPlayer2)
            {
                if(pbScoreNumberP1.Image != imagesNumber[6])
                {
                    scorePlayer1++;
                    pbScoreNumberP1.Image = imagesNumber[scorePlayer1];
                    pictureBox1.Image = Properties.Resources.P1_;
                }
                else
                {

                }
            }
            else if (playPlayer1 < playPlayer2)
            {
                if(pbScoreNumberP2.Image != imagesNumber[6])
                {
                    scorePlayer2++;
                    pbScoreNumberP2.Image = imagesNumber[scorePlayer2];
                    pictureBox1.Image = Properties.Resources.P2_;
                }
                else
                {

                }
            }

            ShowScore();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Hotkeys();
        }

        private void ShowScore()
        {
            //lblScoreP1.Text = "Score:  " + scorePlayer1.ToString();
            //lblScoreP2.Text = "Score:  " + scorePlayer2.ToString();
        }

        private void pbScoreP1_Click(object sender, EventArgs e)
        {

        }

        private void EndRound()
        {
            if (shiftPlayer1)
            {
                playPlayer1 = nr;
            }
            else
            {
                playPlayer2 = nr;
            }

            if(clicks == 2)
            {
                ShowWinner();
            }
            else
            {
                ChangeShift();
            }

            UpdateButton();
        }

        private void Clicks(object sender, EventArgs e)
        {
            clicks++;
            DrawValor();
        }

        private void Reset(object sender, EventArgs e)
        {
            endGame = false;
            playPlayer1 = playPlayer2 = clicks = 0;
            lblWinner.Text = "Vencedor: ";
            pbDice_1.Image = imagesDice[0];
            pbDice_2.Image = imagesDice[0];
            UpdateButton();
        }

        private void Hotkeys()
        {
            //Teclas de atalhos P1, P2 e Reset
            if (btnRollP1.Enabled == true)
            {
                if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
                {
                    btnRollP1.PerformClick();
                }
            }

            if (btnRollP2.Enabled == true)
            {
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    btnRollP2.PerformClick();
                }
            }

            if (btnReset.Enabled == true)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    btnReset.PerformClick();
                }
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
