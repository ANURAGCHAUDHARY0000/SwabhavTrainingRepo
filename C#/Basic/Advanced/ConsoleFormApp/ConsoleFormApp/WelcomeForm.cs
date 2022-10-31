using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;


namespace ConsoleFormApp
{
    internal class WelcomeForm : Form
    {
       
        public WelcomeForm()
       {
            this.Text = "Welcome";
            this.Width = 500;
            this.Height = 500;
            this.BackColor = Color.Azure;

            Button btnHello = new Button();
            btnHello.Text = "hello";
            btnHello.Width = 60;
            btnHello.Height = 30;
            btnHello.Location = new Point(10,20);

            Button btnPrint = new Button();
            btnPrint.Text = "Print";
            btnPrint.Width = 60;
            btnPrint.Height = 30;
            btnPrint.Location = new Point(100,20);
            btnPrint.Click += SomeLongRunningTask;


            Button btnPrintThread = new Button();
            btnPrintThread.Text = "Print Via Thread";
            btnPrintThread.Width = 80;
            btnPrintThread.Height = 40;
            btnPrintThread.Location = new Point(200, 20);
            btnPrintThread.Click += (s, e) =>
            {
                Thread t = new Thread(() => SomeLongRunningTask(s ,e));
                t.Start();
            };

            btnHello.Click += DevilListner;
            btnHello.Click += (s, e) =>
            {
                Button button = (Button)s;
                Console.WriteLine("God is listening to btn with text value " + button.Text);
            };

            this.Controls.Add(btnHello);
            this.Controls.Add(btnPrint);
            this.Controls.Add(btnPrintThread);
       }

        private void DevilListner(object sender, EventArgs e)
        {
            Button btnHello = new Button();
            Console.WriteLine("Devil is listnening to button with text value "+btnHello.Text);
        }
        
        
        private void SomeLongRunningTask(object sender, EventArgs e)
        {
            while(true)
            {
                Console.WriteLine(DateTime.Now.ToString("hh : mm: ss"));
            }
        }



    }
}
