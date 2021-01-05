using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
  public partial class frmMainForm : Form
  {
    public frmMainForm()
    {
      InitializeComponent();
    }
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        private void btnStart_Click(object sender, EventArgs e)
        {
            sw.Start();
            txtStart.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (txtStart.Text != "")
            {
                sw.Stop();
                txtStop.Text = DateTime.Now.ToString("h:mm:ss tt");
                txtElapsedTime.Text = sw.Elapsed.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
