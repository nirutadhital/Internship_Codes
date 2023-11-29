namespace ShapeDemo
{
    public interface IShape {
        public double getArea();
    }

    public class XYZ : IShape {
        public double getArea() {
            return 8;
        }
    }

    public abstract class Shape : IShape {
        protected double area;
        public double getArea() {
            return area;
        }
    }

    public class Square : Shape {
        public int length;

        public Square(int length) {
            this.length = length;
            this.area = length * length;
        }
    }

    public class Rectangle : Shape {
        public int length;
        public int breadth;
        public Rectangle(int length, int breadth) {
            this.length = length;
            this.breadth = breadth;
            this.area = length * breadth;
        }
    }

    public class Circle : Shape {
        public double radius;
    }

    public class CompositeShape : IShape {
        private IShape s1;
        private IShape s2;

        public CompositeShape(IShape s1, IShape s2) {
            this.s1 = s1;
            this.s2 = s2;
        }

        public double getArea() {
            return this.s1.getArea() + this.s2.getArea();
        }
    }

    // public class ShapeDemo {
    //     static void Main() {
    //         Shape s1, s2;
    //         s1 = new Square(3);
    //         s2 = new Rectangle(2, 3);
    //         CompositeShape c = new CompositeShape(s1, s2);
    //         Console.WriteLine(c.getArea());
    //     }
    // }
}