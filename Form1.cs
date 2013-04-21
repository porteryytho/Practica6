using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practica6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prod1 = double.Parse(this.prod1.Text);
            double prod2 = double.Parse(this.prod3.Text);
            double prod3 = double.Parse(this.prod3.Text);

            double sub = prod1 + prod2 + prod3;
            this.sub.Text = sub.ToString();

            double iva = sub * .16;
            this.iva.Text = iva.ToString();

            double total = iva + sub;
            this.total.Text = total.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            prod1.Clear();
            prod2.Clear();
            prod3.Clear();
            sub.Clear(); 
            iva.Clear();
            total.Clear();
        }
    }
}
