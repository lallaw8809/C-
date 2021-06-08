using System;

namespace Program
{ 
    /* Abstract class  */
    abstract public class baseClass
    {
        public string str = "Abstarct class";

        public virtual int addTwoNumber(int x, int y)
        {
            return 0;
        }

        public virtual int multiplyTwoNumber(int x, int y)
        {
            return x * y;
        }
    }

    // Abstarct class can be used in drived class
    public class subClass : baseClass
    {
        public override int addTwoNumber(int x, int y)
        {
            return x + y;
        }

        public override int multiplyTwoNumber(int x, int y)
        {
            return base.multiplyTwoNumber(x,y);
        }
    }

    class mainClass
    {
        static void Main(string[] args)
        {
            var x = new subClass();

            Console.WriteLine(x.str);
            Console.WriteLine(x.addTwoNumber(10, 23));
            Console.WriteLine(x.multiplyTwoNumber(10, 23));
        }
    }
}
