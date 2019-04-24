using System;
using SMSApp.Models;
using SMSApp.DAL;
using SMSApp.BLL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.BLL
{
    public class StockInController
    {
        StockInRepository _stockINRepository = new StockInRepository();
        public bool SaveStockIN(StockIN stockIN, Item item)
        {
            bool isSave = false;
            isSave = _stockINRepository.SaveStockIN(stockIN, item);
            return isSave;
        }
    }
}
