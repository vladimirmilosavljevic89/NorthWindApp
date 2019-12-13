using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
  public  class Product
    {
        private int ProductID;
        private string ProductName;
        private int SupplierID;
        private int CategoryID;
        private string QuantityPerUnit;
        private decimal UnitPrice;
        private short? UnitsInStock;
        private short? UnitsOnOrder;
        private short? ReorderLevel;
        private bool Discontinued;

        public int ProductID1
        {
            get
            {
                return ProductID;
            }

            set
            {
                ProductID = value;
            }
        }

        public string ProductName1
        {
            get
            {
                return ProductName;
            }

            set
            {
                ProductName = value;
            }
        }

        public int SupplierID1
        {
            get
            {
                return SupplierID;
            }

            set
            {
                SupplierID = value;
            }
        }

        public int CategoryID1
        {
            get
            {
                return CategoryID;
            }

            set
            {
                CategoryID = value;
            }
        }

        public string QuantityPerUnit1
        {
            get
            {
                return QuantityPerUnit;
            }

            set
            {
                QuantityPerUnit = value;
            }
        }

        public decimal UnitPrice1
        {
            get
            {
                return UnitPrice;
            }

            set
            {
                UnitPrice = value;
            }
        }

        public short? UnitsInStock1
        {
            get
            {
                return UnitsInStock;
            }

            set
            {
                UnitsInStock = value;
            }
        }

        public short? UnitsOnOrder1
        {
            get
            {
                return UnitsOnOrder;
            }

            set
            {
                UnitsOnOrder = value;
            }
        }

        public short? ReorderLevel1
        {
            get
            {
                return ReorderLevel;
            }

            set
            {
                ReorderLevel = value;
            }
        }

        public bool Discontinued1
        {
            get
            {
                return Discontinued;
            }

            set
            {
                Discontinued = value;
            }
        }
    }
}
