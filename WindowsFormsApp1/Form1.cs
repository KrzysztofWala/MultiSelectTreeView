using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            multiSelectTreeView.Nodes.Add("Element 1");
            multiSelectTreeView.Nodes.Add("Element 2");
            multiSelectTreeView.Nodes.Add("Element 3");
            multiSelectTreeView.Nodes.Add("Element 4");
            multiSelectTreeView.Nodes.Add("Element 5");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.multiSelectTreeView.Refresh();
        }
    }
}
