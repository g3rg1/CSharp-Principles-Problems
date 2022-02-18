using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    /// <summary>
    /// Felidae is latin for "Cat".
    /// </summary>
    public class Felidae
    {
        private bool male;
        public Felidae() : this(true) { }

        public Felidae(bool male)
        {
            this.male = male;
        }
        public bool Male
        {
            get => this.male;
            set => this.male = value;
        }

    }
}
