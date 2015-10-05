using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BAL
{
    public class SigPad
    {
        
        public event EventHandler<SigPadArgs> StatusUpdated;

        public void CallDB(SigPadInfo sigPadInfo)
        {
            Console.WriteLine("Writing to DB.");
            Thread.Sleep(2000);

            OnStatusUpdated(sigPadInfo);
        }

        protected virtual void OnStatusUpdated(SigPadInfo sigPadInfo)
        {
            if (StatusUpdated != null)
                StatusUpdated(this, new SigPadArgs() {CurrentStatus = 1, NewStatus = sigPadInfo.SigpadStatus});
        }
    }
}
