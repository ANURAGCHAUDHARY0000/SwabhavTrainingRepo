namespace WinLoginFormsApp
{
    public partial class Form1 : Form
    {

        public static string Text1;
        public static string Text2;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text1 = textBox1.Text;
            Text2 = textBox2.Text;

            if(Text1.Length == 0 || Text2.Length == 0)
            {
                MessageBox.Show("Pls enter username or password");
            }
            else { Authenticate(); }

            void Authenticate()
            {
                if(Text1 == Text2)
                {
                    WelcomeForm welcomeForm = new WelcomeForm();
                    welcomeForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username Or Password");
                }
            }


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}