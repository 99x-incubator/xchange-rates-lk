using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using WebDriverScraping;
using System.Globalization;




namespace WebDriverTest
{

     
    class Program 
    {

        public static string link = null;
        public static string xPathsiteUpdated = null;
        public static int bankId = 0;
        public static string bankName = null;
        public static string xPathAUBR = null;
        public static string xPathAUSR = null;
        public static string xPathEUBR = null;
        public static string xPathEUSR = null;
        public static string xPathNORBR = null;
        public static string xPathNORSR = null;
        public static string xPathUSBR = null;
        public static string xPathUSSR = null;
        static void Main(string[] args)
        {

            Executor executor = new Executor();

            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 1:

                        bankId = 001;
                        bankName = "Peoples Bank";

                        link = configuration.linkRepository(bankName);
                        //Site Updated On
                        xPathsiteUpdated = "//*[@id='rightArea']/table/tbody/tr[1]/td[2]/strong";

                        //Austrailian Dollar Buying Rate
                        xPathAUBR = "//*[@id='rightArea']/table/tbody/tr[6]/td[7]";

                        //Austrailian Dollar Selling Rate
                        xPathAUSR = "//*[@id='rightArea']/table/tbody/tr[6]/td[8]";

                        //Euro Buying Rate
                        xPathEUBR = "//*[@id='rightArea']/table/tbody/tr[9]/td[7]";

                        //Euro Selling Rate
                        xPathEUSR = "//*[@id='rightArea']/table/tbody/tr[9]/td[8]";

                        //Nor Buying Rate
                        xPathNORBR = "//*[@id='rightArea']/table/tbody/tr[14]/td[7]";

                        //Nor Selling Rate
                        xPathNORSR = "//*[@id='rightArea']/table/tbody/tr[14]/td[8]";

                        //US Dollar Buying Rate
                        xPathUSBR = "//*[@id='rightArea']/table/tbody/tr[20]/td[7]";

                        //US Dollar Selling Rate
                        xPathUSSR = "//*[@id='rightArea']/table/tbody/tr[20]/td[8]";

                       
                                               
                        executor.webScrap(link, xPathsiteUpdated, bankId, bankName, xPathAUBR, xPathAUSR,  xPathEUBR, xPathEUSR, xPathNORBR, xPathNORSR,  xPathUSBR, xPathUSSR );
                        break;


                    case 2:

                        bankId = 002;
                        bankName = "Bank of Ceylon";

                        link = configuration.linkRepository(bankName);
                        //Site Updated On
                        xPathsiteUpdated = "/html/body/table/tbody/tr[1]/td[2]/div/font";

                        //Austrailian Dollar Buying Rate
                        xPathAUBR = "/html/body/table/tbody/tr[4]/td[6]/font";

                        //Austrailian Dollar Selling Rate
                        xPathAUSR = "/html/body/table/tbody/tr[4]/td[7]/font";

                        //Euro Buying Rate
                        xPathEUBR = "/html/body/table/tbody/tr[8]/td[6]/font";

                        //Euro Selling Rate
                        xPathEUSR = "/html/body/table/tbody/tr[8]/td[7]/font";

                        //Nor Buying Rate
                        xPathNORBR = "/html/body/table/tbody/tr[13]/td[6]/font";

                        //Nor Selling Rate
                        xPathNORSR = "/html/body/table/tbody/tr[13]/td[7]/font";

                        //US Dollar Buying Rate
                        xPathUSBR = "/html/body/table/tbody/tr[23]/td[6]/font";

                        //US Dollar Selling Rate
                        xPathUSSR = "/html/body/table/tbody/tr[23]/td[7]/font";
                                               
                        executor.webScrap(link, xPathsiteUpdated, bankId, bankName, xPathAUBR, xPathAUSR,  xPathEUBR, xPathEUSR, xPathNORBR, xPathNORSR,  xPathUSBR, xPathUSSR );
                        break;

                    case 3:

                        bankId = 003;
                        bankName = "Central Bank";

                        link = configuration.linkRepository(bankName);
                        //Site Updated On
                        xPathsiteUpdated = "//*[@id='top_Cur_Exch']/table/tbody/tr[1]/td[2]";

                        //Austrailian Dollar Buying Rate
                        xPathAUBR = "//*[@id='top_Cur_Exch']/table/tbody/tr[8]/td[2]/div";

                        //Austrailian Dollar Selling Rate
                        xPathAUSR = "//*[@id='top_Cur_Exch']/table/tbody/tr[3]/td[3]/div";

                        //Euro Buying Rate
                        xPathEUBR = "//*[@id='top_Cur_Exch']/table/tbody/tr[5]/td[2]/div";

                        //Euro Selling Rate
                        xPathEUSR = "//*[@id='top_Cur_Exch']/table/tbody/tr[5]/td[3]/div";

                        //Nor Buying Rate
                        xPathNORBR = "//*[@id='gulf_rates']/table/tbody/tr[34]/td[3]";

                        //Nor Selling Rate
                        xPathNORSR = "//*[@id='gulf_rates']/table/tbody/tr[34]/td[3]";

                        //US Dollar Buying Rate
                        xPathUSBR = "//*[@id='top_Cur_Exch']/table/tbody/tr[3]/td[2]/div";

                        //US Dollar Selling Rate
                        xPathUSSR = "//*[@id='top_Cur_Exch']/table/tbody/tr[3]/td[3]/div";



                        executor.webScrap(link, xPathsiteUpdated, bankId, bankName, xPathAUBR, xPathAUSR, xPathEUBR, xPathEUSR, xPathNORBR, xPathNORSR, xPathUSBR, xPathUSSR);
                        break;

                    case 4:

                        bankId = 004;
                        bankName = "Sampath Bank";

                        link = configuration.linkRepository(bankName);
                        //Site Updated On
                        xPathsiteUpdated = "//*[@id='rates']/div/div[1]/p[1]";

                        //Austrailian Dollar Buying Rate
                        xPathAUBR = "//*[@id='rates']/div/div[1]/table/tbody/tr[2]/td[2]";

                        //Austrailian Dollar Selling Rate
                        xPathAUSR = "//*[@id='rates']/div/div[1]/table/tbody/tr[2]/td[4]";

                        //Euro Buying Rate
                        xPathEUBR = "//*[@id='rates']/div/div[1]/table/tbody/tr[6]/td[2]";

                        //Euro Selling Rate
                        xPathEUSR = "//*[@id='rates']/div/div[1]/table/tbody/tr[6]/td[4]";

                        //Nor Buying Rate
                        xPathNORBR = "//*[@id='rates']/div/div[1]/table/tbody/tr[10]/td[2]";

                        //Nor Selling Rate
                        xPathNORSR = "//*[@id='rates']/div/div[1]/table/tbody/tr[10]/td[4]";

                        //US Dollar Buying Rate
                        xPathUSBR = "//*[@id='rates']/div/div[1]/table/tbody/tr[17]/td[2]";

                        //US Dollar Selling Rate
                        xPathUSSR = "//*[@id='rates']/div/div[1]/table/tbody/tr[17]/td[4]";



                        executor.webScrap(link, xPathsiteUpdated, bankId, bankName, xPathAUBR, xPathAUSR, xPathEUBR, xPathEUSR, xPathNORBR, xPathNORSR, xPathUSBR, xPathUSSR);
                        break;

                    case 5:

                        bankId = 005;
                        bankName = "NDB Bank";

                        link = configuration.linkRepository(bankName);
                        //Site Updated On
                        xPathsiteUpdated = "//*[@id='main_container']/div[4]/div[2]/div[2]/p";

                        //Austrailian Dollar Buying Rate
                        xPathAUBR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[7]/td[5]";

                        //Austrailian Dollar Selling Rate
                        xPathAUSR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[7]/td[6]";

                        //Euro Buying Rate
                        xPathEUBR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[6]/td[5]";

                        //Euro Selling Rate
                        xPathEUSR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[6]/td[6]";

                        //Nor Buying Rate
                        xPathNORBR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[13]/td[5]";

                        //Nor Selling Rate
                        xPathNORSR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[13]/td[6]";

                        //US Dollar Buying Rate
                        xPathUSBR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[3]/td[5]";

                        //US Dollar Selling Rate
                        xPathUSSR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[3]/td[6]";



                        executor.webScrap(link, xPathsiteUpdated, bankId, bankName, xPathAUBR, xPathAUSR, xPathEUBR, xPathEUSR, xPathNORBR, xPathNORSR, xPathUSBR, xPathUSSR);
                        break;

                    //case 6:

                    //    bankId = 006;
                    //    bankName = "NDB Bank";

                    //    link = configuration.linkRepository(bankName);
                    //    //Site Updated On
                    //    xPathsiteUpdated = "//*[@id='main_container']/div[4]/div[2]/div[2]/p";

                    //    //Austrailian Dollar Buying Rate
                    //    xPathAUBR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[7]/td[5]";

                    //    //Austrailian Dollar Selling Rate
                    //    xPathAUSR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[7]/td[6]";

                    //    //Euro Buying Rate
                    //    xPathEUBR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[6]/td[5]";

                    //    //Euro Selling Rate
                    //    xPathEUSR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[6]/td[6]";

                    //    //Nor Buying Rate
                    //    xPathNORBR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[13]/td[5]";

                    //    //Nor Selling Rate
                    //    xPathNORSR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[13]/td[6]";

                    //    //US Dollar Buying Rate
                    //    xPathUSBR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[3]/td[5]";

                    //    //US Dollar Selling Rate
                    //    xPathUSSR = "//*[@id='main_container']/div[4]/div[2]/div[2]/table/tbody/tr[3]/td[6]";



                    //    executor.webScrap(link, xPathsiteUpdated, bankId, bankName, xPathAUBR, xPathAUSR, xPathEUBR, xPathEUSR, xPathNORBR, xPathNORSR, xPathUSBR, xPathUSSR);
                    //    break;


                    //case 7:

                    //    bankId = 007;
                    //    bankName = "Pan Asia Bank";

                    //    link = configuration.linkRepository(bankName);
                    //    //Site Updated On
                    //    xPathsiteUpdated = "//*[@id='content_area']/div[3]/span";

                    //    //Austrailian Dollar Buying Rate
                    //    xPathAUBR = "//*[@id='content_area']/div[3]/table/tbody/tr[7]/td[5]";

                    //    //Austrailian Dollar Selling Rate
                    //    xPathAUSR = "//*[@id='content_area']/div[3]/table/tbody/tr[7]/td[6]";

                    //    //Euro Buying Rate
                    //    xPathEUBR = "//*[@id='content_area']/div[3]/table/tbody/tr[5]/td[5]";

                    //    //Euro Selling Rate
                    //    xPathEUSR = "//*[@id='content_area']/div[3]/table/tbody/tr[5]/td[6]";

                    //    //Nor Buying Rate
                    //    xPathNORBR = "//*[@id='content_area']/div[3]/table/tbody/tr[5]/td[5]";

                    //    //Nor Selling Rate
                    //    xPathNORSR = "//*[@id='content_area']/div[3]/table/tbody/tr[5]/td[5]";

                    //    //US Dollar Buying Rate
                    //    xPathUSBR = "//*[@id='content_area']/div[3]/table/tbody/tr[3]/td[5]";

                    //    //US Dollar Selling Rate
                    //    xPathUSSR = "//*[@id='content_area']/div[3]/table/tbody/tr[3]/td[6]";



                    //    executor.webScrap(link, xPathsiteUpdated, bankId, bankName, xPathAUBR, xPathAUSR, xPathEUBR, xPathEUSR, xPathNORBR, xPathNORSR, xPathUSBR, xPathUSSR);
                    //    break;
                        
                    case 8:

                        bankId = 008;
                        bankName = "Nations Trust Bank";

                        link = configuration.linkRepository(bankName);
                        //Site Updated On
                        xPathsiteUpdated = "/html/body/div[5]/div";

                        //Austrailian Dollar Buying Rate
                        xPathAUBR = "/html/body/div[5]/table/tbody/tr[3]/td[3]";

                        //Austrailian Dollar Selling Rate
                        xPathAUSR = "/html/body/div[5]/table/tbody/tr[3]/td[4]";

                        //Euro Buying Rate
                        xPathEUBR = "/html/body/div[5]/table/tbody/tr[8]/td[3]";

                        //Euro Selling Rate
                        xPathEUSR = "/html/body/div[5]/table/tbody/tr[8]/td[4]";

                        //Nor Buying Rate
                        xPathNORBR = "/html/body/div[5]/table/tbody/tr[15]/td[3]";

                        //Nor Selling Rate
                        xPathNORSR = "/html/body/div[5]/table/tbody/tr[15]/td[4]";

                        //US Dollar Buying Rate
                        xPathUSBR = "/html/body/div[5]/table/tbody/tr[23]/td[3]";

                        //US Dollar Selling Rate
                        xPathUSSR = "/html/body/div[5]/table/tbody/tr[23]/td[4]";



                        executor.webScrap(link, xPathsiteUpdated, bankId, bankName, xPathAUBR, xPathAUSR, xPathEUBR, xPathEUSR, xPathNORBR, xPathNORSR, xPathUSBR, xPathUSSR);
                        break;

                    case 9:

                        bankId = 009;
                        bankName = "Commerical Bank";

                        link = configuration.linkRepository(bankName);
                        //Site Updated On
                        xPathsiteUpdated = "//*[@id='rates-tables']/tbody/tr[1]/th[2]/div/span/b/span";

                        //Austrailian Dollar Buying Rate
                        xPathAUBR = "//*[@id='rates-tables']/tbody/tr[9]/td[6]";

                        //Austrailian Dollar Selling Rate
                        xPathAUSR = "//*[@id='rates-tables']/tbody/tr[9]/td[7]";

                        //Euro Buying Rate
                        xPathEUBR = "//*[@id='rates-tables']/tbody/tr[5]/td[6]";

                        //Euro Selling Rate
                        xPathEUSR = "//*[@id='rates-tables']/tbody/tr[5]/td[7]";

                        //Nor Buying Rate
                        xPathNORBR = "//*[@id='rates-tables']/tbody/tr[5]/td[6]";

                        //Nor Selling Rate
                        xPathNORSR = "//*[@id='rates-tables']/tbody/tr[5]/td[6]";

                        //US Dollar Buying Rate
                        xPathUSBR = "//*[@id='rates-tables']/tbody/tr[4]/td[6]";

                        //US Dollar Selling Rate
                        xPathUSSR = "//*[@id='rates-tables']/tbody/tr[4]/td[7]";



                        executor.webScrap(link, xPathsiteUpdated, bankId, bankName, xPathAUBR, xPathAUSR, xPathEUBR, xPathEUSR, xPathNORBR, xPathNORSR, xPathUSBR, xPathUSSR);
                        break;

                        
                }
                
            }






            Console.WriteLine("End");
            //Console.ReadLine();
           


        }
        class Executor
        {
            public void webScrap(string link, string xPathsiteUpdated,int xPathbankId, string xPathbankName, string xPathAUBR, string xPathAUSR, string xPathEUBR, string xPathEUSR, string xPathNORBR, string xPathNORSR,  string xPathUSBR, string xPathUSSR)
            {

                string DbsiteUpdated = null;
                string DbAUBR = null;
                string DbAUSR = null; 
                string DbEUBR = null;
                string DbEUSR = null;
                string DbNORBR = null;
                string DbNORSR = null;
                string DbUSBR = null;
                string DbUSSR = null;


                // Initialize the Chrome Driver
                using (var driver = new ChromeDriver())
                {

                    // Go to the home page
                    driver.Navigate().GoToUrl(link);

                    IWebElement baseTable = driver.FindElement(By.TagName("table"));

                    // gets all table rows
                    ICollection<IWebElement> rows = baseTable.FindElements(By.TagName("tr"));

                    // for every row
                    IWebElement matchedRow = null;

                    //Fetching Site Updated Date
                    IList<IWebElement> all1 = driver.FindElements(By.XPath(xPathsiteUpdated));

                    String[] allText1 = new String[all1.Count];
                    String usd1 = null;
                    foreach (IWebElement element in all1)
                    {
                        usd1 = element.Text;
                        DbsiteUpdated = usd1;
                        Console.WriteLine(DbsiteUpdated);
                    }

                    //Fetching AUBR
                    IList<IWebElement> all2 = driver.FindElements(By.XPath(xPathAUBR));

                    String[] allText2 = new String[all2.Count];
                    String usd2 = null;
                    foreach (IWebElement element in all2)
                    {
                        usd2 = element.Text;
                        DbAUBR = usd2;
                        Console.WriteLine(DbAUBR);
                    }

                    //Fetching AUSR
                    IList<IWebElement> all3 = driver.FindElements(By.XPath(xPathAUSR));

                    String[] allText3 = new String[all3.Count];
                    String usd3 = null;
                    foreach (IWebElement element in all3)
                    {
                        usd3 = element.Text;
                        DbAUSR = usd3;
                        Console.WriteLine(DbAUSR);
                    }

                    //Fetching EUBR
                    IList<IWebElement> all4 = driver.FindElements(By.XPath(xPathEUBR));

                    String[] allText4 = new String[all4.Count];
                    String usd4 = null;
                    foreach (IWebElement element in all4)
                    {
                        usd4 = element.Text;
                        DbEUBR = usd4;
                        Console.WriteLine(DbEUBR);
                    }

                    //Fetching EUSR
                    IList<IWebElement> all5 = driver.FindElements(By.XPath(xPathEUSR));

                    String[] allText5 = new String[all5.Count];
                    String usd5 = null;
                    foreach (IWebElement element in all5)
                    {
                        usd5 = element.Text;
                        DbEUSR = usd5;
                        Console.WriteLine(DbEUSR);
                    }

                    //Fetching NORBR
                    IList<IWebElement> all6 = driver.FindElements(By.XPath(xPathNORBR));

                    String[] allText6 = new String[all6.Count];
                    String usd6 = null;
                    foreach (IWebElement element in all6)
                    {
                        usd6 = element.Text;
                        DbNORBR = usd6;
                        Console.WriteLine(DbNORBR);
                    }

                    //Fetching NORSR
                    IList<IWebElement> all7 = driver.FindElements(By.XPath(xPathNORSR));

                    String[] allText7 = new String[all7.Count];
                    String usd7 = null;
                    foreach (IWebElement element in all7)
                    {
                        usd7 = element.Text;
                        DbNORSR = usd7;
                        Console.WriteLine(DbNORSR);
                    }


                    //Fetching USBR
                    IList<IWebElement> all8 = driver.FindElements(By.XPath(xPathUSBR));

                    String[] allText8 = new String[all8.Count];
                    String usd8 = null;
                    foreach (IWebElement element in all8)
                    {
                        usd8 = element.Text;
                        DbUSBR = usd8;
                        Console.WriteLine(DbUSBR);
                    }

                    //Fetching USSR
                    IList<IWebElement> all9 = driver.FindElements(By.XPath(xPathUSSR));

                    String[] allText9 = new String[all9.Count];
                    String usd9 = null;
                    foreach (IWebElement element in all9)
                    {
                        usd9 = element.Text;
                        DbUSSR = usd9;
                        Console.WriteLine(DbUSSR);
                    }



                    


                    //Sending USD rate to Db
                    DbConnection sql = new DbConnection();

                    float FDbAUBR = Convert.ToSingle(DbAUBR);
                    float FDbAUSR = Convert.ToSingle(DbAUSR);
                    float FDbEUBR = Convert.ToSingle(DbEUBR);
                    float FDbEUSR = Convert.ToSingle(DbEUSR);
                    float FDbNORBR = Convert.ToSingle(DbNORBR);
                    float FDbNORSR = Convert.ToSingle(DbNORSR);
                    float FDbUSBR = Convert.ToSingle(DbUSBR);
                    float FDbUSSR = Convert.ToSingle(DbUSSR);

                    sql.AddRecord(DbsiteUpdated, xPathbankId, xPathbankName, FDbAUBR, FDbAUSR, FDbEUBR, FDbEUSR , FDbNORBR, FDbNORSR, FDbUSBR, FDbUSSR);

                    //pausing console before exit
                
                    usd1 = null;
                    usd2 = null;
                    usd3 = null;
                    usd4 = null;
                    usd5 = null;
                    usd6 = null;
                    usd7 = null;
                    usd8 = null;
                    usd9 = null;

                    // Take a screenshot and save it into screen.png
                    //driver.GetScreenshot().SaveAsFile(@"screen.png", ImageFormat.Png);

                }
            }
        }


}

           
    }

    class DbConnection 
    {
       

        public void AddRecord(string DbxPathsiteUpdated,int DbbankId, string DbbankName, float DbxPathAUBR, float DbxPathAUSR, float DbxPathEUBR, float DbxPathEUSR , float DbxPathNORBR, float DbxPathNORSR, float DbxPathUSBR, float DbxPathUSSR)
        {
           
          

           //connection string
           string sConnectionString = "Server=OBHASHAP\\SQLEXPRESS; Database=currency;User Id=su;Password = su;";
     //   "Server=99XAPP30002; Database=currency; Trusted_Connection=True;";
           SqlConnection objConn = new SqlConnection(sConnectionString);
            objConn.Open();
       
            //SQL querryServer=OBHASHAP\\SQLEXPRESS;Database=currency;User Id=su;Password = su;
            if (DbbankId == 003) {
                DbxPathNORBR = 0;
                DbxPathNORSR = 0;
            }  else if(DbbankId == 007){
                DbxPathNORBR = 0;
                DbxPathNORSR = 0;
            } else if(DbbankId == 009){
                DbxPathNORBR = 0;
                DbxPathNORSR = 0;
            }

        //setting logo
        string bankLogo = "";
        switch(DbbankId){

            case 001:
                bankLogo = "http://www.peoplesbank.lk/images/globals/logo.png";
                break;
            case 002:
                bankLogo = "http://web.boc.lk/catalog/view/theme/default/images/new/logo.jpg";
                break;
            case 003:
                bankLogo = "http://fiusrilanka.gov.lk/images/cbsl_logo.gif";
                break;
            case 004:
                bankLogo = "http://travelpass.lk/v1/home/booking/images/online_payment/op_sampath_bank.png";
                break;
            case 005:
                bankLogo = "http://www.ndbbank.com/images/common/logo.png";
                break;
            case 006:
                bankLogo = "NDB link 2";
                break;
            case 007:
                bankLogo = "http://www.pabcbank.com/catalog/view/theme/default/image/logo.jpg";
                break;
            case 008:
                bankLogo = "https://upload.wikimedia.org/wikipedia/en/d/db/Nations_Trust_Bank_logo.png";
                break;
            case 009:
                bankLogo = "http://www.combank.net/newweb/images/logo.png";
                break;
        }
 
        string sSQL = "insert into exchangeRates (SiteUpdated,bankId,bankName,ADBR,ADSR,EUBR,EUSR,NORBR,NORSR,USBR,USSR,logo) values('" + DbxPathsiteUpdated + "', "+DbbankId+", '"+DbbankName+"', '" + DbxPathAUBR + "', '" + DbxPathAUSR + "' ,'" + DbxPathEUBR + "', '" + DbxPathEUSR + "', '" + DbxPathNORBR + "', '" + DbxPathNORSR + "', '" + DbxPathUSBR + "', '" + DbxPathUSSR + "', '" + bankLogo + "')";
            SqlCommand objCmd = new SqlCommand(sSQL, objConn);
            try
            {
                objCmd.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            objConn.Close();
            Console.WriteLine("Record Added");
        }

       
    } 

