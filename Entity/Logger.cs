using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Logger
    {
        public void OnStatusUpdated(object source, SigPadArgs e)
        {
            if (e.CurrentStatus != e.NewStatus)
                CreateLog();
        }

        public void CreateLog()
        {
            Console.WriteLine("Logging create info to a place.");
        }
    }
}
