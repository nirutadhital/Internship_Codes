namespace AllPrograms
{
    class Square
    {
       public int length { get; set; }
       public  Square(int length)
        {
            this.length = length;

        }
        public virtual void Show()
        {
            Console.WriteLine(length * length);

        }

        
    }
    class Rectangle : Square
    {
        int width;
       public  Rectangle(int length,int width) : base(length)
        {
            this.width = width;
        }
        
        public override void Show()
        {
            Console.WriteLine(length * width);

        }

    }
    // internal class Shape
    // {
    //     static void Main(string[] args)
    //     {
    //         Square s=new Square(5);
    //         s.Show();

    //         s = new Rectangle(3, 4);
    //         s.Show();
    //     }
    // }
}
