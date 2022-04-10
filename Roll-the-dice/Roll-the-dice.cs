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
            startImages();
            updateButton();
        }

        int scorePlayer1, scorePlayer2, playPlayer1, playPlayer2, nr, clicks;
        bool shiftPlayer1 = true, endGame;
        Image[] imagesDice = new Image[7];
        Random rdn = new Random();
        
        private void startImages()
        {
            imagesDice[0] = Properties.Resources._120px_Dice_0;
            imagesDice[1] = Properties.Resources.Alea_1;
            imagesDice[2] = Properties.Resources.Alea_2;
            imagesDice[3] = Properties.Resources.Alea_3;
            imagesDice[4] = Properties.Resources.Alea_4;
            imagesDice[5] = Properties.Resources.Alea_5;
            imagesDice[6] = Properties.Resources.Alea_6;
        }

        private void changeShift()
        {
            // "!" faz a variável turnPlayer1 ter o valor inverso
            shiftPlayer1 = !shiftPlayer1;
        }

        private void updateButton()
        {
            btnPlay1.Enabled = shiftPlayer1 && !endGame;
            btnPlay2.Enabled = !shiftPlayer1 && !endGame;
        }

        private void colorButton()
        {
            btnPlay1.BackColor = btnPlay1.Enabled ? Color.Red : Color.White;
            btnPlay2.BackColor = btnPlay2.Enabled ? Color.Red : Color.White;
        }

        private void changeImage()
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
        private void drawValor()
        {
            //Esse código limita os números, o número maior que pode cair é 6, e o ++ faz que nunca caia no 0
            nr = (int)Math.Truncate((rdn.NextDouble() * 10) % 6);
            nr++;
            changeImage();
        }

        private void showWinner()
        {
            endGame = true;

            lblWinner.Text += " " + string.Format(playPlayer1 > playPlayer2 ? "Player 1" :
                (playPlayer1 < playPlayer2 ? "Player 2" : "Empate!"));

            if(playPlayer1 > playPlayer2)
            {
                scorePlayer1++;
            }
            else if (playPlayer1 < playPlayer2)
            {
                playPlayer2++;
            }

            showScore();
        }

        private void showScore()
        {
            lblPlayer1.Text = "Score:  " + scorePlayer1.ToString();
            lblPlayer2.Text = "Score:  " + scorePlayer2.ToString();

        }

        private void endShift()
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
                showWinner();
            }
            else
            {
                changeShift();
            }
        }

        private void Clicks(object sender, EventArgs e)
        {
            clicks++;
            drawValor();
        }
    }
}
