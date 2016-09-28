using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockWInApp
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
         //   this.MinimumSize = this.Size;
         //   this.MaximumSize = this.Size;


        }

        private void searchMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.MdiParent = this;        
            form.Show();

            
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Process.GetCurrentProcess().Kill();
            }


        }
    }
}
