using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.Models
{
    public class LogFile
    {
        public string Class { get; set; }
        public string MethodName { get; set; }
        public string Log { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
