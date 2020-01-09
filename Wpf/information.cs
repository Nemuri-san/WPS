using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf
{
    public class information
    {
        private string txtdata1;
        private string txtdata2;
        private string txtdata3;

        public string Pos
        {
            get { return txtdata1; }
            set { txtdata1 = value; }
        }

        public string Sal
        {
            get { return txtdata2; }
            set { txtdata2 = value; }
        }
    }
}
