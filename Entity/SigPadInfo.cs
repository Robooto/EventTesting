using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SigPadInfo
    {
        public string AuthName { get; set; }

        public string AuthTitle { get; set; }

        public int SigpadStatus { get; set; }
    }

    public class SigPadArgs : EventArgs
    {
        public int CurrentStatus { get; set; }
        public int NewStatus { get; set; }
    }
}
