using EFCodeFirstTut.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstTut
{
    class Program
    {
        public static object ApplicationDbCOntext { get; private set; }

        static void Main(string[] args)
        {

            ApplicationDbContext context = new ApplicationDbContext();

        }
    }
}
