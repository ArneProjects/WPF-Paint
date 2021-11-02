using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Paint
{
    interface IColor
    {
        int R
        {
            get;
            set;
        }

        int G
        {
            get;
            set;
        }

        int B
        {
            get;
            set;
        }
    }
}
