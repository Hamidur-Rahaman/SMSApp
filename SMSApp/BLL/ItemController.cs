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
    public class ItemController
    {
        ItemRepository _itemRepository = new ItemRepository();

        public bool SaveItem(Item item)
        {
            bool isSave = false;
            bool isCheck= Exists(item.ItemName);
            if (!isCheck)
            {
                isSave = _itemRepository.SaveItem(item);
            }
            else
            {
                MessageBox.Show("All Ready Exsits!!");
            }

            return isSave;
        }

        public DataTable SearchItem(int Company, int Category)
        {
            DataTable list = new DataTable();
            list = _itemRepository.SearchItem(Company, Category);
            return list;
        }
        public DataTable GetLoadCategoryCombo()
        {
            DataTable dataTable = new DataTable();
            dataTable = _itemRepository.GetLoadCategoryCombo();
            return dataTable;
        }
        public DataTable GetLoadCompanyCombo()
        {
            DataTable dataTable = new DataTable();
            dataTable = _itemRepository.GetLoadCompanyCombo();
            return dataTable;
        }
        public bool Exists(string item)
        {
            bool isExist = false;
            isExist = _itemRepository.Exists(item);
            return isExist;
        }
    }
}
