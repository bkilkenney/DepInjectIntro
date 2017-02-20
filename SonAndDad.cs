using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjectIntro
{
    public class EldestSon : ISon
    {
        public void Help(string message)
        {
            //Gotta help my dad
        }
    }
    public class YoungestSon : ISon
    {
        public void Help(string message)
        {
            //Gotta help my dad
        }
    }

    public class Dad
    {
        ISon son = null;

        //Constructor
        //1. Example of constructor injection
        //Dad is injecting what son he wants to call in the constructor
        //public Dad(ISon selectedSon)
        //{
        //    son = selectedSon;
        //}


        //2. Example of method injection
        public void Notify(ISon selectedSon, string message)
        {
            selectedSon.Help(message);
        }


        //3. Example of Property injection
        //public ISon Son { get; set; }

        //public void Notify(string message)
        //{
        //    Son.Help(message);
        //}

    }
}
