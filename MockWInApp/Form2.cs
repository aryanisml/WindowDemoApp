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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HelperMock.name.ToString());
            string s = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            var form3 = new Form3(s);
            form3.MdiParent = this.ParentForm;
            this.Close();
            form3.Show();
        }
    }
}
