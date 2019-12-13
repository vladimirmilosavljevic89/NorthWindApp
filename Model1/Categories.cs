using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
   public class Categories
    {
        private int categoryID;
        private string categoryName;
        private string description;
        private byte[] picture;

        public int CategoryID
        {
            get
            {
                return categoryID;
            }

            set
            {
                categoryID = value;
            }
        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public byte[] Picture
        {
            get
            {
                return picture;
            }

            set
            {
                picture = value;
            }
        }
    }
}
