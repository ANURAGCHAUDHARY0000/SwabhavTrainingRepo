using AsyncProgrammingApproach;

namespace WinFormsThreadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello" + DateTime.Now.ToString("hh:mm:ss"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TimePrinter().Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new TimePrinter().Print);
            thread.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task.Run(new TimePrinter().Print);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task<int> r = new TimePrinter().PrintAsync();

            MessageBox.Show("end of btnasync click : result is :" + r.ToString());
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            int r = await new TimePrinter().PrintAsync();
            MessageBox.Show(r.ToString());
        }

         
    }
}