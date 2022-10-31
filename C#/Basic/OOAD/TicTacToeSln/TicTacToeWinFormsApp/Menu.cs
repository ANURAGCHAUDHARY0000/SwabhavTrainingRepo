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
    public partial class Menu : Form
    {
        private static string _player1Name;
        private static string _player2Name;
       
        public Menu()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(MarkType));
            comboBox2.DataSource = Enum.GetValues(typeof(MarkType));
          
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = MarkType.X;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = MarkType.O;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Please enter player name!!");
            }
            else
            {
                _player1Name = textBox1.Text;
                _player2Name = textBox2.Text;
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }

        public static string Player1Name { get { return _player1Name; } }

        public static string Player2Name { get { return _player2Name; } }
       
    }
}
