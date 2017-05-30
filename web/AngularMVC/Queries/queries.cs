using AngularMVC.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AngularMVC.Queries
{
    public class queries
    { 

        //filtering from the buying rate
        //if need to fintered by the selling rate change the sql query to SR in all instances 
        public static LowestRate lowestUSD()
        {
            LowestRate USD = new LowestRate();


            using (SqlConnection connection = new SqlConnection("Data Source=OBHASHAP\\SQLEXPRESS;Initial Catalog=currency;Persist Security Info=True;Integrated Security=True;User ID=su;Password=su"))
            {
                connection.Open();
                //
                // Create new SqlCommand object.
                //
                using (SqlCommand command = new SqlCommand("select top 1 * from [currency].[dbo].[exchangeRates] where USBR  =(select MIN(NULLIF(USBR, 0)) from [currency].[dbo].[exchangeRates])", connection))
                {
                    //
                    // Invoke ExecuteReader method.
                    //
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {


                        USD.BuyingRate = reader.GetDouble(9);
                        USD.SellingRate = reader.GetDouble(10);
                        USD.BankLogo = reader.GetString(11);
                        USD.BankName = reader.GetString(2);

                    
                       // Console.WriteLine("  " + USDBR + " " + logo + " " + bank + " " + ASDBR);
                       // Console.ReadLine();

                    }
                }


            }
            return USD;

        }

        public static LowestRate lowestAD()
        {
            LowestRate AD = new LowestRate();


            using (SqlConnection connection = new SqlConnection("Data Source=OBHASHAP\\SQLEXPRESS;Initial Catalog=currency;Trusted_Connection=True;"))
            {
                connection.Open();
                //
                // Create new SqlCommand object.
                //
                using (SqlCommand command = new SqlCommand("select top 1 * from [currency].[dbo].[exchangeRates] where ADBR  =(select MIN(NULLIF(ADBR, 0)) from [currency].[dbo].[exchangeRates])", connection))
                {
                    //
                    // Invoke ExecuteReader method.
                    //
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {


                        AD.BuyingRate = reader.GetDouble(3);
                        AD.SellingRate = reader.GetDouble(4);
                        AD.BankLogo = reader.GetString(11);
                        AD.BankName = reader.GetString(2);


                        // Console.WriteLine("  " + USDBR + " " + logo + " " + bank + " " + ASDBR);
                        // Console.ReadLine();

                    }
                }


            }
            return AD;

        }

        public static LowestRate lowestEuro()
        {
            LowestRate ER = new LowestRate();


            using (SqlConnection connection = new SqlConnection("Data Source=OBHASHAP\\SQLEXPRESS;Initial Catalog=currency;Trusted_Connection=True;"))
            {
                connection.Open();
                //
                // Create new SqlCommand object.
                //
                using (SqlCommand command = new SqlCommand("select top 1 * from [currency].[dbo].[exchangeRates] where EUBR  =(select MIN(NULLIF(EUBR, 0)) from [currency].[dbo].[exchangeRates])", connection))
                {
                    //
                    // Invoke ExecuteReader method.
                    //
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {


                        ER.BuyingRate = reader.GetDouble(5);
                        ER.SellingRate = reader.GetDouble(6);
                        ER.BankLogo = reader.GetString(11);
                        ER.BankName = reader.GetString(2);


                        // Console.WriteLine("  " + USDBR + " " + logo + " " + bank + " " + ASDBR);
                        // Console.ReadLine();

                    }
                }


            }
            return ER;

        }
        public static LowestRate lowestNOR()
        {
            LowestRate NOR = new LowestRate();


            using (SqlConnection connection = new SqlConnection("Data Source=OBHASHAP\\SQLEXPRESS;Initial Catalog=currency;Trusted_Connection=True;"))
            {
                connection.Open();
                //
                // Create new SqlCommand object.
                //
                using (SqlCommand command = new SqlCommand("select top 1 * from [currency].[dbo].[exchangeRates] where NORBR  =(select MIN(NULLIF(NORBR, 0)) from [currency].[dbo].[exchangeRates])", connection))
                {
                    //
                    // Invoke ExecuteReader method.
                    //
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {


                        NOR.BuyingRate = reader.GetDouble(7);
                        NOR.SellingRate = reader.GetDouble(8);
                        NOR.BankLogo = reader.GetString(11);
                        NOR.BankName = reader.GetString(2);


                        // Console.WriteLine("  " + USDBR + " " + logo + " " + bank + " " + ASDBR);
                        // Console.ReadLine();

                    }
                }


            }
            return NOR;

        }

        //Quering all data to table

    }
}


    
