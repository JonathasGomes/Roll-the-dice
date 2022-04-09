using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        int scorePlayer1, scorePlayer2, playPlayer1, playPlayer2, nr, clicks;
        bool turnPlayer1 = true, endGame;
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

        private void changeTurn()
        {
            turnPlayer1 = !turnPlayer1;
        }

        private void updateButton()
        {

        }
    }
}
