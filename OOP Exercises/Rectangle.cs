namespace NamespaceImportTest
{
    class Rectangle
    {
        private int height=1;
        private int width=1;

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public int Height
        {
            get => height;
            set => height = Height;
        }
        public int Width
        {
            get => width;
            set => width = Width;
        }
        public int Area
        {
            get { return this.height * this.width; }
        }
    }
}
