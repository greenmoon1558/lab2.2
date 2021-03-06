﻿using System;
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
        private DataTable institutes;
        private DataTable departments;
        private DataTable teachers;
        private DataView viewteachers;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab2DataSet1.Institutes' table. You can move, or remove it, as needed.
            this.institutesTableAdapter.Fill(this.lab2DataSet1.Institutes);
            // TODO: This line of code loads data into the 'lab2DataSet1.Chairs' table. You can move, or remove it, as needed.
            this.chairsTableAdapter.Fill(this.lab2DataSet1.Chairs);
            // TODO: This line of code loads data into the 'lab2DataSet1.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.lab2DataSet1.Teachers);
            // TODO: This line of code loads data into the 'lab2DataSet.Teachers' table. You can move, or remove it, as needed.
            this.institutes = new DataTable("institutes");
            DataColumn name = new DataColumn("Name", typeof(string));
            name.Unique = true;
            name.AllowDBNull = false;
            institutes.Columns.Add(name);
            institutes.Columns.Add("Id", typeof(int));
            institutes.PrimaryKey = new DataColumn[] { institutes.Columns["Id"] };
            this.departments = new DataTable("department");
            
            departments.Columns.Add("Name", typeof(string));
            departments.Columns.Add("InstituteId", typeof(int));
            departments.Columns.Add("Id", typeof(Guid));
            departments.PrimaryKey = new DataColumn[] { departments.Columns["Id"] };
           
            this.teachers = new DataTable("teachers");
           teachers.Columns.Add("Name", typeof(string));
            teachers.Columns.Add("SurName", typeof(string));
            teachers.Columns.Add("Id", typeof(Guid));
            teachers.PrimaryKey = new DataColumn[] { teachers.Columns["Id"] };
            lab2DataSet1.Tables.Add(departments);
            lab2DataSet1.Tables.Add(institutes);
            lab2DataSet1.Tables.Add(teachers);
            lab2DataSet1.Relations.Add("institute to department", institutes.Columns["Id"], departments.Columns["InstituteId"]);
            //lab2DataSet1.Relations.Add("teachers to departments", departments.Columns["Name"], teachers.Columns["City"]);
            // add data
            institutes.Rows.Add("Lp", 1);
            institutes.Rows.Add("Nau", 2);
            institutes.Rows.Add("KPI", 3);
            institutes.Rows.Add("ITI", 4);
            institutes.Rows.Add("FVT", 5);

            departments.Rows.Add("EI", 1, Guid.NewGuid());
            departments.Rows.Add("Ai", 1, Guid.NewGuid());
            departments.Rows.Add("TU", 1, Guid.NewGuid());
            departments.Rows.Add("RT", 1, Guid.NewGuid());
            departments.Rows.Add("PF", 1, Guid.NewGuid());

            teachers.Rows.Add("Anna", "Klevskaja", Guid.NewGuid());
            teachers.Rows.Add("Jhon", "Donn", Guid.NewGuid());
            teachers.Rows.Add("Jan", "Maklein", Guid.NewGuid());
            teachers.Rows.Add("Nil", "Voichch", Guid.NewGuid());

            dataGridView1.DataSource = institutes;
            dataGridView2.DataSource = departments;
            dataGridView3.DataSource = teachers;
            viewteachers = new DataView(teachers);
            viewteachers.Sort = "Name ASC";
            dataGridView4.DataSource = viewteachers;




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
