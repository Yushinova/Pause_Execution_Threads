using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        //public CancellationTokenSource cancelTokenSource;
        //public CancellationToken token;
        //public CancellationTokenSource cancelTokenSource2;
        //public CancellationToken token2;
        ManualResetEvent resetEvent1 = new ManualResetEvent(true);
        public ThreadStart ts1;
        public Thread t1;

        ManualResetEvent resetEvent2 = new ManualResetEvent(true);
        public ThreadStart ts2;
        public Thread t2;

        public int a;
        public int b;

       public int current = 1;
        public Form1()
        {
            InitializeComponent();
            ts1 = new ThreadStart(FindSimple);
            t1 = new Thread(ts1);

            ts2 = new ThreadStart(FindFib);
            t2 = new Thread(ts2);
        }

        private void minInput_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(minInput.Text);
        }

        private void startSimple_Click(object sender, EventArgs e)
        {
            //cancelTokenSource = new CancellationTokenSource();
            //token = cancelTokenSource.Token;
            //
           // resetEvent1 = new ManualResetEvent(true);
            resetEvent1.Set();
            if(!t1.IsAlive)
            {
               
                t1.Start();
            }
              
            //await Task.Run(() => FindSimple(), token);
        }

        private void maxInput_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(maxInput.Text);
        }
       public void FindSimple()
        {
           
            if (minInput.Text==String.Empty) a = 2;
         
            if(maxInput.Text==String.Empty) b = int.MaxValue;
            for(int i=a;  i<b; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Invoke(new Action(()=> outputSimple.Text = i.ToString()));
                   // a = i;
                    resetEvent1.WaitOne();
                    Thread.Sleep(500);
                   //if(token.IsCancellationRequested) break;
                }
            }
        }
        private static bool IsPrimeNumber(int number)
        {
            int sqrtNumber = (int)(Math.Sqrt(number));
            for (int i = 2; i <= sqrtNumber; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public void FindFib()
        {
            int prev = 0;
            
            int temp;

            for (int i = 0; i <= int.MaxValue; i++)
            {
                Invoke(new Action(() => outputFib.Text = current.ToString()));
                //a = i;
                temp = current;
                current = current + prev;
                prev = temp;
                resetEvent2.WaitOne();
                Thread.Sleep(500);
               
                //if (token2.IsCancellationRequested) break;

            }
        }
        private void stopSimple_Click(object sender, EventArgs e)
        {
            resetEvent1.Reset();
            //t1.Abort(); 
            //cancelTokenSource.Cancel();
            //startSimple_Click
        }

        private void Restart_Click(object sender, EventArgs e)//TODO
        {
            //cancelTokenSource.Cancel();
            t1.Abort();
            t2.Abort();
            a = 0; b=0;
            current = 1;
           // outputFib.Text = resetEvent1.Handle.ToString();
           
            resetEvent1.Close();
            resetEvent2.Close();
            resetEvent1.Dispose();
            resetEvent2.Dispose();
            ts1 = new ThreadStart(FindSimple);
            t1 = new Thread(ts1);
           

            ts2 = new ThreadStart(FindFib);
            t2 = new Thread(ts2);

            resetEvent1 = new ManualResetEvent(true);
            resetEvent2 = new ManualResetEvent(true);
           

        }

        private void startFib_Click(object sender, EventArgs e)
        {
            resetEvent2.Set();
            if (!t2.IsAlive) t2.Start();
          
            //cancelTokenSource2 = new CancellationTokenSource();
            //token2 = cancelTokenSource.Token;
            //
            //ts1 = new ThreadStart(FindSimple);
            // t1 = new Thread(ts1);
            // t1.Start();
            //await Task.Run(() => FindFib(), token2);
        }

        private void stopFib_Click(object sender, EventArgs e)
        {
            resetEvent2.Reset();
            //cancelTokenSource2.Cancel();
        }
    }
}
