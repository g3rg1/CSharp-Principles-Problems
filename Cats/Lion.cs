using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Lion : Felidae
    {
        private int weight;
        public Lion(bool male, int weight) : base(male)
        {
            this.weight = weight;
        }

        public int Weight
        {
            get => this.weight;
            set => this.weight = value;
        }
    }
}
