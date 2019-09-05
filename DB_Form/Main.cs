using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Form
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logintestDataSet1.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter1.Fill(this.logintestDataSet1.Data);
            // TODO: This line of code loads data into the 'logintestDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.logintestDataSet.Data);

        }
    }
}
