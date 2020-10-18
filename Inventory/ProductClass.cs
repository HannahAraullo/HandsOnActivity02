using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Inventory
{

    class ProductClass
    {
        public int _Quantity;
        public double _SellingPrice;
        public string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;

        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate,
            double Price, int Quantity, string Description)
        {
            _Quantity = Quantity;
            _SellingPrice = Price;
            _ProductName = ProductName;
            _Category = Category;
            _ManufacturingDate = MfgDate;
            _ExpirationDate = ExpDate;
            _Description = Description;
        }
        public string ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                _ProductName = value;
            }
        }
        public string Category
        {
            get
            {
                return _Category;
            }
            set
            {
                _Category = value;
            }
        }

        public string ManufacturingDate
        {
            get
            {
                return _ManufacturingDate;
            }
            set
            {
                _ManufacturingDate = value;
            }
        }

        public string ExpirationDate
        {
            get
            {
                return _ExpirationDate;
            }
            set
            {
                _ExpirationDate = value;
            }
        }
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
        public int Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                _Quantity = value;
            }
        }
        public double SellingPrice
        {
            get
            {
                return _SellingPrice;
            }
            set
            {
                _SellingPrice = value;
            }
        }
    }

}
