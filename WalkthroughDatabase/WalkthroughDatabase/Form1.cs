using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkthroughDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sampleDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sampleDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.sampleDatabaseDataSet.Customers);

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipcodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void companyNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipcodeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
