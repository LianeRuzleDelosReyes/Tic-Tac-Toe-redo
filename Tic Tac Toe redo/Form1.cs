using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_redo
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        public int players = 2;
        public int chances = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
       

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text == "")
            {
                if (players % 2 == 0)
                {
                    btn.Text = "X";
                    players++;
                    chances++;
                }
                else
                {
                    btn.Text = "O";
                    players++;
                    chances++;
                }

                if(CheckForDraw() == true)
                {
                    MessageBox.Show("It's a tie", "Sorry");
                    sd++;
                    NGame();
                    
                }

                if(CheckForWinner() == true)
                {
                    if(btn.Text == "X")
                    {
                        MessageBox.Show("Player X won!", "Congratulations");
                        s1++;
                        NGame();
                    }

                    else
                    {
                        MessageBox.Show("Player O won!", "Congratulations");
                        s2++;
                        NGame();
                    }
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            XWin.Text = "Player X: " + s1;
            OWin.Text = "Player O: " + s2;
            Drawn.Text = "Draws: " + sd;
        }

        void NGame()
        {
            players = 2;
            chances = 0;
            A1.Text = A2.Text = A3.Text = B1.Text = B2.Text = B3.Text = C1.Text = C2.Text = C3.Text = "";
            XWin.Text = "Player X: " + s1;
            OWin.Text = "Player O: " + s2;
            Drawn.Text = "Draws: " + sd;
        }

        private void ngameBtn_Click(object sender, EventArgs e)
        {
            NGame();
        }

        bool CheckForDraw()
        {
            if ((chances == 9)&&CheckForWinner()==false)
                return true;
            else
                return false;
        }

        bool CheckForWinner()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && A1.Text != "")
                return true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && B1.Text != "")
                return true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && C1.Text != "")
                return true;

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && A1.Text != "")
                return true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && A2.Text != "")
                return true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && A3.Text != "")
                return true;

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && A1.Text != "")
                return true;
            else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && C1.Text != "")
                return true;

            else
                return false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            s1 = 0;
            s2 = 0;
            sd = 0;
            NGame();

        }
    }
}
