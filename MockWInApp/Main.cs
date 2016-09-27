using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;


        }

        private void searchMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.MdiParent = this;        
            form.Show();

            
        }
    }
}
