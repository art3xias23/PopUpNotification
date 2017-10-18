using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopUpNotification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int timeout = 1000;
            notifyIcon1.BalloonTipTitle = "Title";
            notifyIcon1.BalloonTipText = "Actual Notification";
            notifyIcon1.ShowBalloonTip(timeout);
        }

       
    }
}
