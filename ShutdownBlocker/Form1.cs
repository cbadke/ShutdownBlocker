using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShutdownBlocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
        }
        
        private void Form1_Closing(
            System.Object sender,
            FormClosingEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.WindowsShutDown))
            {
                e.Cancel = true;
            }
        }
    }

}
