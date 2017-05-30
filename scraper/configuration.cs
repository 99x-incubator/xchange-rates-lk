using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebDriverScraping
{
    class configuration
    {
        public static string linkRepository(string bankName)
        {
            if (bankName.Equals("Peoples Bank"))
            {
               return "http://www.peoplesbank.lk/exchangerates";
            }
            else if(bankName.Equals("Bank of Ceylon")){
                return "https://www.boc.web.lk/ExRates";
            }
            else if (bankName.Equals("Central Bank"))
            {
                return "http://www.cbsl.gov.lk/htm/english/_cei/er/e_1.asp";
            }
            else if (bankName.Equals("Sampath Bank"))
            {
                return "http://www.sampath.lk/en/exchange-rates";
            }
            else if (bankName.Equals("NDB Bank"))
            {
                return "http://www.ndbbank.com/pages/english/rates/exchange_rates.jsp";
            }
            else if (bankName.Equals("Pan Asia Bank"))
            {
                return "http://www.pabcbank.com/reports/exchange_rates/info";
            }
            else if (bankName.Equals("Nations Trust Bank"))
            {
                return "http://www.nationstrust.com/foreign-exchange-rates";
            }
            else if (bankName.Equals("Commerical Bank"))
            {
                return "http://www.combank.lk/newweb/rates-tariffs/exchange-rates";
            }
        



            return null;

        }
        







    }
}
