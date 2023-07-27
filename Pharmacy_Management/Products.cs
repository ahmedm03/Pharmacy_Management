using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management
{
    public class Products
    {
        private string ID_of_Product , Name_of_Products, Production_Date, Expire_date;
        private double Amount , Product_price;

        public Products ()
        {
            this.ID_of_Product = this.Name_of_Products = Production_Date = this.Expire_date = " ";
            this.Amount = this.Product_price = 0.0;
            
        }
        public Products (string ID_of_Products, string Name_of_Products, double Product_price , double Amount, string Production_Date, string Expire_date)
        {
            this.ID_of_Product = ID_of_Products;
            this.Name_of_Products = Name_of_Products;
            this.Product_price = Product_price;
            this.Amount = Amount;
            this.Production_Date = Production_Date;
            this.Expire_date = Expire_date;

        }
        public string getID_of_Products()
        {
            return this.ID_of_Product;
        }
        public void setID_of_Products(string ID_of_Products)
        {
            this.ID_of_Product = ID_of_Products;
        }
        public string getName_of_Products()
        {
            return this.Name_of_Products;
        }
        public void setName_of_Products(string Name_of_Products)
        {
            this.Name_of_Products = Name_of_Products;
        }
        public double getProduct_price()
        {
            return this.Product_price;
        }
        public void setProduct_price(double Product_price)
        {
            this.Product_price = Product_price;
        }
        public double getAmount()
        {
            return this.Amount;
        }
        public void setAmount(double Amount)
        {
            this.Amount = Amount;
        }
        public string getProduction_Date()
        {
            return this.Production_Date;
        }
        public void setProduction_Date(string Production_Date)
        {
            this.Production_Date = Production_Date;
        }
        public string getExpire_date()
        {
            return this.Expire_date;
        }
        public void setExpire_date(string Expire_date)
        {
            this.Expire_date = Expire_date;
        }

        }
    }

