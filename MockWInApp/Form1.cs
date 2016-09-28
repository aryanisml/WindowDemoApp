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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            FillList1();


        }



    internal void FillList1()
        {
            var lst = new List<string>();
            lst.Add("A");
            lst.Add("B");
            lst.Add("C");
            lst.Add("D");
            lst.Add("F");
            lstInputBox1.DataSource = lst;



        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var lstOPTemp = new List<string>();
            var lstInputTemp = new List<String>();
            if (lstInputBox1.SelectedItems.Count==0)
            {
                MessageBox.Show("Please Select");
                return;
            }
            foreach (var item in lstInputBox1.Items)
            {
                lstInputTemp.Add(item.ToString());
            }
            if (lstOutputBox.Items.Count>0)
            {
                foreach (var item in lstOutputBox.Items)
                {
                    lstOPTemp.Add(item.ToString());
                }
            }
            foreach (var item in lstInputBox1.SelectedItems)
            {
                lstOPTemp.Add(item.ToString());
                lstInputTemp.Remove(item.ToString());
            }

            lstInputBox1.DataSource = lstInputTemp;
            lstOutputBox.DataSource = lstOPTemp;





        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            var lstOPTemp = new List<string>();
            var lstInputTemp = new List<String>();
            if (lstOutputBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select");
                return;
            }
            foreach (var item in lstOutputBox.Items)
            {
                lstOPTemp.Add(item.ToString());
            }
            if (lstInputBox1.Items.Count > 0)
            {
                foreach (var item in lstInputBox1.Items)
                {
                    lstInputTemp.Add(item.ToString());
                }
            }
            foreach (var item in lstOutputBox.SelectedItems)
            {
                lstInputTemp.Add(item.ToString());
                lstOPTemp.Remove(item.ToString());
            }

            lstInputBox1.DataSource = lstInputTemp;
            lstOutputBox.DataSource = lstOPTemp;




        }

        private void lstInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                
                for (int i = 0; i < lstInputBox1.Items.Count; i++)
                {
                    lstInputBox1.SetSelected(i, true);
                }


            }
        }

        private void lstOutputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {


                for (int i = 0; i < lstOutputBox.Items.Count; i++)
                {
                    lstOutputBox.SetSelected(i, true);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelperMock.name = "Hello Swapnil";

            var form2 = new Form2();
            form2.MdiParent = this.ParentForm;
            this.Close();
            form2.Show();
        }
    }
}
