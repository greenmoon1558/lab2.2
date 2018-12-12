using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab2DataSet1.Institutes' table. You can move, or remove it, as needed.
            this.institutesTableAdapter.Fill(this.lab2DataSet1.Institutes);
            // TODO: This line of code loads data into the 'lab2DataSet1.Chairs' table. You can move, or remove it, as needed.
            this.chairsTableAdapter.Fill(this.lab2DataSet1.Chairs);
            // TODO: This line of code loads data into the 'lab2DataSet1.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.lab2DataSet1.Teachers);
            // TODO: This line of code loads data into the 'lab2DataSet.Teachers' table. You can move, or remove it, as needed.
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
