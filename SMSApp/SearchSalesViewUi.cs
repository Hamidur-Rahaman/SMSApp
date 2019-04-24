using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SMSApp.Models;
using SMSApp.BLL;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace SMSApp
{
    public partial class SearchSalesViewUi : Form
    {
        StockOutManager _stOutManager = new StockOutManager();
        private StockOut _stockOut;
        public SearchSalesViewUi()
        {
            InitializeComponent();
        }
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            _stockOut = new StockOut();
            try
            {
                dataGridView.AutoGenerateColumns = false;
                _stockOut.StockOutDate = Convert.ToDateTime(fromDateTimePicker.Text);
                _stockOut.StockOutDate.ToShortDateString();
                _stockOut.StockToDate = Convert.ToDateTime(toDateTimePicker.Text);
                _stockOut.StockToDate.ToShortDateString();
                DataTable dataTable = _stOutManager.DateWiseSearch(_stockOut);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

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

        private void ItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ItemSetupUi().ShowDialog();
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

        private void StockInSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchItemViewUi().ShowDialog();
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
