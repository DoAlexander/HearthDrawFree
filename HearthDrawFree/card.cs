using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthDrawFree
{
    [DelimitedRecord(",")]
    public class card
    {
        public int id;
        public string imageName;
        public string name;

        public string myName
        {
            get
            {
                return name;
            }
        }

        public card() { }

        public card(int fid, string fimageName, string fname)
        {
            id = fid;
            imageName = fimageName;
            name = fname;
        }

        public bool checkName(string fname)
        {
            if (name == fname)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
