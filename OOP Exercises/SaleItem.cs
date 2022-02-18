using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceImportTest
{
    class SaleItem
    {
        private int id = 0;
        private string name = "Undefined";
        private decimal cost = 0.0M;

        public SaleItem(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public decimal Cost
        {
            get => cost;
            set => cost = value;
        }
    }
}
