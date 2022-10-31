using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToelib.CustomException;
using TicTacToelib.Model;


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
            textBox1.Text = game.GetCurrentPlayer();
            textBox2.Text = game.GetCurrentPLayerMark().ToString();

        }

     
        private void buttonClick(object sender, EventArgs e)
        {

            Button clickedbutton = (Button)sender;
            int position = clickedbutton.ImageIndex;
            textBox1.Text = game.GetCurrentPlayer();
            textBox2.Text = game.GetCurrentPLayerMark().ToString();
            clickedbutton.Text = game.GetCurrentPLayerMark().ToString();
            clickedbutton.Enabled = false;
            game.Play(position);
            GetGameStatus();
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
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
            else if (game.GetStatus().Equals(ResultType.DRAW))
            {
                MessageBox.Show("Match is Draw");
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
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
            
        }

     
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

            
    }
}



