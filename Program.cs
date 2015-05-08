using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3d a = new Vector3d(1, 2, 3);
            Vector3d b = new Vector3d(5, 6, 7);

            Vector3d sum = a + b;

            Console.Write(sum); 
        }
    }
}
