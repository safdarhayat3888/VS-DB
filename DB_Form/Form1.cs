﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NCTC-Safdar\Documents\logintest.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*)from Login where username = '" + textBox1.Text + "' and password = '"+ textBox2.Text+ "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main mm = new Main();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
