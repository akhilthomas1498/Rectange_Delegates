using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Rectange_Delegates.Rectange;

namespace Rectange_Delegates
{
    public class Rectange
    {
        public delegate void RectDelegate(Double h, Double w);
        public void area(Double h, Double w)
        {
            Console.Write("\nArea = {0}", w * h);
        }
        public void peri(Double h, Double w)
        {
            Console.Write("\nPerimeter = {0}", 2*(w + h));
        }
   
        static void Main(string[] args)
        {
            Rectange rect = new Rectange();
            RectDelegate rectdel = new RectDelegate(rect.area);
            rectdel += rect.peri;
            rectdel.Invoke(5,8);
            Console.Read();
        }
    }
}
