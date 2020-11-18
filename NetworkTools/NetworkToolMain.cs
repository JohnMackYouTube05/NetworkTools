using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using Whois;

namespace NetworkTools
{
    public class NetworkToolMain
    {
        ///<summary>
        ///Gets the whois information.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        private string GetWhoIsInformation(string url)
        {
            WhoisLookup lookup = new WhoisLookup();
            var response = lookup.Lookup(url);

            return response.ToString();
            
        }
    }
}
