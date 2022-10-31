using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeWinFormsApp.CustomException;
using TicTacToeWinFormsApp.Model;


namespace TicTacToeWinFormsApp
{
    public partial class Form1 : Form
    {

        Player[] players = new Player[2];
        Board board;
        ResultAnalyzer resultAnalyzer;
        Game game;
        public Form1()
        {
            InitializeComponent();
            players[0] = new Player(Menu.Player1Name, MarkType.X);
            players[1] = new Player(Menu.Player2Name, MarkType.O);
            board = new Board();
            resultAnalyzer = new ResultAnalyzer(board);
            game = new Game(players, board, resultAnalyzer);
          
            GetName();
            GetMark();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = " ";
            game.Play(button1.ImageIndex);
            button1.Text = game.GetBoard.GetCells[0].GetMark.ToString();
            GetGameStatus();
            GetName();
            GetMark();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = " ";
            game.Play(button2.ImageIndex);
            button2.Text = game.GetBoard.GetCells[1].GetMark.ToString();
            GetGameStatus();
            GetName();
            GetMark();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = " ";
            game.Play(button3.ImageIndex);
            button3.Text = game.GetBoard.GetCells[2].GetMark.ToString();
            GetGameStatus();
            GetName();
            GetMark();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = " ";
            game.Play(button4.ImageIndex);
            button4.Text = game.GetBoard.GetCells[3].GetMark.ToString();
            GetGameStatus();
            GetName();
            GetMark();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = " ";
            game.Play(button5.ImageIndex);
            button5.Text = game.GetBoard.GetCells[4].GetMark.ToString();
            GetGameStatus();
            GetName();
            GetMark();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = " ";
            game.Play(button6.ImageIndex);
            button6.Text = game.GetBoard.GetCells[5].GetMark.ToString();
            GetGameStatus();
            GetName();
            GetMark();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = " ";
            game.Play(button7.ImageIndex);
            button7.Text = game.GetBoard.GetCells[6].GetMark.ToString();
            GetGameStatus();
            GetName();
            GetMark();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = " ";
            game.Play(button8.ImageIndex);
            button8.Text = game.GetBoard.GetCells[7].GetMark.ToString();
            GetGameStatus();
            GetName();
            GetMark();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = " ";
            game.Play(button9.ImageIndex);
            button9.Text = game.GetBoard.GetCells[8].GetMark.ToString();
            GetGameStatus();
            GetName();

            GetMark();
        }

        private void GetGameStatus()
        {
            if (game.GetStatus().Equals(ResultType.WIN))
            {
                game.SwitchPlayer();
                MessageBox.Show(game.GetCurrentPlayer() + " wins the game");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
               

            }
            else if (game.GetStatus().Equals(ResultType.DRAW))
            {
                MessageBox.Show("Match is Draw");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
           // Application.Restart();
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            board.ResetBoard();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
          
            

        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetName();   
        }

        private void GetName()
        {
            textBox1.Text = game.GetCurrentPlayer();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            GetMark();  
        }

        private void GetMark()
        {
            textBox2.Text = game.GetCurrentPLayerMark().ToString();
        }
    }
}
