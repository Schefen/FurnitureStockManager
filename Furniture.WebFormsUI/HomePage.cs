using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture.WebFormsUI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Transactions transactionsFrm = new Transactions();
            transactionsFrm.Show();
            this.Hide();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            CategoryManagement categoryManagementFrm = new CategoryManagement();
            categoryManagementFrm.Show();
            this.Hide();
        }
    }
}
