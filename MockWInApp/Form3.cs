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
    public partial class Form3 : Form
    {
        public Form3(string s)
        {
            InitializeComponent();
            this.ControlBox = false;
            MessageBox.Show(s);
            FillDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HelperMock.name.ToString());
            var form2 = new Form2();
            form2.MdiParent = this.ParentForm;
            this.Close();
            form2.Show();
        }

        internal void FillDataGrid()
        {
            List<Employee> emp = new List<Employee>( );
            emp.Add(new Employee { Name = "A", Jobs = "B" });
            emp.Add(new Employee { Name = "B", Jobs = "BX" });
            emp.Add(new Employee { Name = "C", Jobs = "BD" });
            emp.Add(new Employee { Name = "AD", Jobs = "BF" });
            dataGridView1.DataSource = emp;
            



        }

        public class Employee {


            public string Name { get; set; }
            public string Jobs { get; set; }


        }

    }
}
