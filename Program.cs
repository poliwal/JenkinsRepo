using System;

namespace prjSecondApplication
{
    class Something
    {
        internal int v;
        internal string name { get; set; }
        public string Word { get; set; }
    }
    class Program
    {
        void display()
        {
            Something something = new Something();
            something.v = 2;
            something.name = "something";
            something.Word = "word";
            Console.WriteLine($"{something.v} \n{something.name} \n{something.Word}");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Something something = new Something();
            
            program.display();
        }
    }
}
