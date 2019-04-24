using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApp
{
    public partial class MainFormUi : Form
    {
        public MainFormUi()
        {
            InitializeComponent();
        }

        private void StockINButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StockInUi().ShowDialog();
        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StockOutUi().ShowDialog();
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ItemSetupUi().ShowDialog();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategorySetupUi().ShowDialog();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CompanySetupUi().ShowDialog();
        }

        private void StockInSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchItemViewUi().ShowDialog();
        }

        private void DateWiseSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchSalesViewUi().ShowDialog();
        }
    }
}
