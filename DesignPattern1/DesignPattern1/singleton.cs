using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    public sealed class singleton
    {
        private static int counter = 0;
        private static singleton instance = null;
        public static singleton GetInstance
        {
            get
            {
                if(instance==null)
                    instance= new singleton();  
                return instance;
            }
        }
        private singleton()
        {
            counter++;
            Console.WriteLine("counter Value : "+counter.ToString());
        }
        public void Printdetails(string message)
        {
            Console.WriteLine(message);
        }

    }

    class Program
    {
        static void Main()
        {
            singleton fromTwitter = singleton.GetInstance;
            fromTwitter.Printdetails("from Twitter");
            singleton fromInstagram = singleton.GetInstance;
            fromInstagram.Printdetails("from Instagram");
            Console.ReadLine();

        }
    }
}
