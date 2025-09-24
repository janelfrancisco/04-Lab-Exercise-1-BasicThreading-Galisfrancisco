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

namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        // 4. In the FrmBasicThread class, create two (2) threads named ThreadA and ThreadB
        private Thread ThreadA;
        private Thread ThreadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {
            ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            // 5. Use the Join() method to stop a calling thread until the thread terminates
            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "- End Of Thread -";
        }
    }
}
