using log4net;
using System.Diagnostics;
using System;
using System.Net;

namespace GeoAggregator
{
    class GeoAggregationManager
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        enum DTMErrors
        {
            webRequestFailure = 16002,
            nullExeption = 16001
        }
        static void Main(string[] args)
        {
            
        }
    }
}
