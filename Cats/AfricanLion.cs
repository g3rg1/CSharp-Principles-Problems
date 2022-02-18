using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class AfricanLion : Lion
    {
        public AfricanLion(bool male, int weight) : base(male, weight) { }

        public override string ToString()
        => $"(AfricanLion, male: {this.Male}, weight: {this.Weight})";
    }
}
