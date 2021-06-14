lobal refers to the global namespace, it can be used to solve problems whereby you may redefine types. For example:

class foo
{
    class System
    {

    }

}
If you were to use System where it would be locally scoped in the foo class, you could use:

global::System.Console.WriteLine("foobar");
to access the global namespace.

Example

using System;

class Foo
{
    public void baz()
    {
        Console.WriteLine("Foo 1");
    }
}

namespace Demo
{
    class Foo
    {
        public void baz()
        {
            Console.WriteLine("Foo 2");
        }
    }

    class Program
    {
        protected static global::Foo bar = new global::Foo();

        static void Main(string[] args)
        {
            bar.baz(); // would write Foo 1 to console as it refers to global scope
            Foo qux = new Foo();
            qux.baz(); // would write Foo 2 to the console as it refers to the Demo namespace
        }
    }
}