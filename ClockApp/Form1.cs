using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateTick_Tick(object sender, EventArgs e)
        {
            TimeSpan secSpan = DateTime.Now - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            clockBar.Text = DateTime.Now.ToString("HH:mm:ss");
            clockBar.Value = (int) secSpan.TotalSeconds;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            TimeSpan secSpan = DateTime.Now - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            clockBar.Text = DateTime.Now.ToString("HH:mm:ss");
            clockBar.Value = (int)secSpan.TotalSeconds;
        }
    }
}
