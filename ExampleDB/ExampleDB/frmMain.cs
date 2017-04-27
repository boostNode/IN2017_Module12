using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tblLanguageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblLanguageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Languages);

        }

        private void tblLanguageBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblLanguageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Languages);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Languages.tblLanguagePROS' table. You can move, or remove it, as needed.
            this.tblLanguagePROSTableAdapter.Fill(this.dataSet_Languages.tblLanguagePROS);
            // TODO: This line of code loads data into the 'dataSet_Languages.tblLanguagePROS' table. You can move, or remove it, as needed.
            this.tblLanguagePROSTableAdapter.Fill(this.dataSet_Languages.tblLanguagePROS);
            // TODO: This line of code loads data into the 'dataSet_Languages.tblLanguageCONS' table. You can move, or remove it, as needed.
            this.tblLanguageCONSTableAdapter.Fill(this.dataSet_Languages.tblLanguageCONS);
            // TODO: This line of code loads data into the 'dataSet_Languages.tblLanguage' table. You can move, or remove it, as needed.
            this.tblLanguageTableAdapter.Fill(this.dataSet_Languages.tblLanguage);

        }

        private void languageStronglyTypedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tblLanguagePROSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
