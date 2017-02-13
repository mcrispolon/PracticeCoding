using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Alphabet
    {

        public List<Letter> LetterList
        {
            get;
            set;
        }
    }


    public class Letter
    {
        public char letter
        {
            get;
            set;
        }

        public int count
        {
            get;
            set;
        }
    }
}
