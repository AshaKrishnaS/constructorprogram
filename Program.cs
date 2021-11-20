using System;

namespace constructorprograms
{
    class Program
    {
        public string model;
        public Program()
        {

            model = "Mustang";    
           }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.model);

        }
    }
}
