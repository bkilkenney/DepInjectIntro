using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjectIntro
{

    class Program
    {
        static void Main(string[] args)
        {
            EldestSon eldestSon = new EldestSon();
            YoungestSon youngestSon = new YoungestSon();

            //Example 1 implementation, Constructor injection
            //Less Common for me
            //Dad dad = new Dad(eldestSon);
            //dad.Notify("Hello son.");


            //Example 2 implementation of Method injection
            //Preferred by me
            Dad dad = new Dad();
            dad.Notify(eldestSon, "Hello son.");


            //Example 3 implementation of Property injection
            //LessCommon for me
            //Dad dad = new Dad();
            //dad.Son = youngestSon;
            //dad.Notify("Hello my youngest son.");

        }
    }
}
