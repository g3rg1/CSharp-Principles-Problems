using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceImportTest
{
    class Cat
    {
        private string name = "";
        private int legs = 4;
        private bool isFat = false;
        private string furColor = "Undefined";

        public Cat()
        {

        }
        public Cat(string name): this()
        {
            this.name = name;
        }
        public Cat(string name, int legs, bool isFat, string furColor)
        {
            this.name = name;
            this.legs = legs;
            this.isFat = isFat;
            this.furColor = furColor;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Legs
        {
            get => legs;
            set => legs = value;
        }

        public bool IsFat
        {
            get => isFat;
            set => isFat = value;
        }

        public string FurColor
        {
            get => furColor;
            set => furColor = value;
        }
    }
}
