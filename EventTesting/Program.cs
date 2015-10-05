using BAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTesting
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var sigpad = new SigPadInfo() {AuthName = "Test", AuthTitle = "Mr", SigpadStatus = 4};
            var logger = new Logger();

            var _sigpadBal = new SigPad();
            _sigpadBal.StatusUpdated += logger.OnStatusUpdated;
            _sigpadBal.CallDB(sigpad);
        }
    }
}
