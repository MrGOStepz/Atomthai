using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomThai
{
    class StructureAtom
    {
    }

    public class StuffAtom
    {
        private string _Name;
        private int _PremStuff;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int PremStuff
        {
            get { return _PremStuff; }
            set { _PremStuff = value; }
        }

        enum PremissionStuff
        {
            Admin = 1,
            Manager = 2,
            Stuff = 3
        }
    }

    public class DiscriptonDish
    {
        //private int 
    }
}
