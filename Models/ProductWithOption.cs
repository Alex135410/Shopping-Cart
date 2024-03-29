using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartV2.Models
{
    public class ProductWithOption
    {
        public int ProductID { get; set; }

        public string ProductTab { get; set; }

        public string ProductName { get; set; }

        public string ImageFile { get; set; }

        public decimal UnitPrice { get; set; }

        public int MaxAmount { get; set; }

        public int DefaultAmount { get; set; }

        public string ColumnLabel { get; set; }

        public string TableString { get; set; }

    }
}