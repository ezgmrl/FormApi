using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;


namespace FormApi
{
    internal class Roots
    {
        public string Films { get; set; }
        public string People { get; set; }
        public string Planets { get; set; }
        public string Species { get; set; }
        public string Starships { get; set; }
        public string Vehicles { get; set; }
    }
}
