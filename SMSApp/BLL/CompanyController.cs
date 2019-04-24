using System;
using SMSApp.Models;
using SMSApp.DAL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApp.BLL
{
    
    public class CompanyController
    {
        CompanyRepository _companyRepository = new CompanyRepository();

        public bool SaveCompany(Company company)
        {
            bool isSave = false;
            if (company.ID > 0)
            {
                isSave = _companyRepository.SaveCompany(company);
            }
            else
            {
                bool isCheck = NameExists(company);
                if (!isCheck)
                {
                    isSave = _companyRepository.SaveCompany(company);
                }
                else
                {
                    MessageBox.Show("All Ready Exsits!!");
                }
            }
            
            return isSave;
        }

        public DataTable LoadCompany()
        {
            DataTable dt = new DataTable();
            dt = _companyRepository.LoadCompany();
            return dt;
        }

        public bool NameExists(Company company)
        {
            bool isExsit = false;
            isExsit = _companyRepository.NameExists(company);
            return isExsit;
        }
    }
}
