using System;
using System.Collections.Generic;
using System.ComponentModel;
using SMSApp.BLL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMSApp.Models;

namespace SMSApp
{
    public partial class CompanySetupUi : Form
    {
        private Company company;
        CompanyController _companyController = new CompanyController();
        private int id = 0;
        public CompanySetupUi()
        {
            InitializeComponent();
            LoadCompanyData();
            SaveButton.Text = "Save";
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            company = new Company();
            if (!String.IsNullOrEmpty(companySetupTextBox.Text))
            {
                company.Name = companySetupTextBox.Text;
                company.ID = id;
                bool isSaved = _companyController.SaveCompany(company);
                
                if (isSaved)
                {
                    MessageBox.Show("Comapany Information Saved.");
                    SaveButton.Text = "Save";
                    LoadCompanyData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Comapany Information Not Saved.");
                }
            }
            else
            {
                MessageBox.Show("Name Can't be Empty, Enter A Name!");
            }

        }

        public void LoadCompanyData()
        {
            DataTable dt = new DataTable();
            showDataGridView.AutoGenerateColumns = false;
            dt = _companyController.LoadCompany();
            showDataGridView.DataSource = dt;
        }
        

        private void Clear()
        {
            companySetupTextBox.Text = "";
            id = 0;
        }

        private void CompanySetupUi_Load(object sender, EventArgs e)
        {
            LoadCompanyData();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategorySetupUi().ShowDialog();
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

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StockOutUi().ShowDialog();
        }

        private void showDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                company = new Company();
                showDataGridView.CurrentRow.Selected = true;
                id = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells["CopanyID"].FormattedValue);
                companySetupTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                SaveButton.Text = "Update";
            }
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }


    }
}
