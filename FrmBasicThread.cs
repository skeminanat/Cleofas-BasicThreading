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

namespace FrmBasicThread
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;
        
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("-Before starting thread-");
                ThreadA = new Thread(MyThreadClass.Thread1);
                ThreadA.Name = "Thread A";
                ThreadB = new Thread(MyThreadClass.Thread1);
                ThreadB.Name = "Thread B";
                ThreadA.Start();
                ThreadB.Start();

                ThreadA.Join();
                ThreadB.Join();
                Console.WriteLine("-End of Thread-");

                label1.Text = "-End Of Thread-";

            }catch(ThreadAbortException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
