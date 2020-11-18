using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using Whois;
using System.Net.NetworkInformation;

namespace NetworkTools
{
    public class NetworkToolMain
    {
        ///<summary>
        ///Gets the whois information.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public string GetWhoIsInformation(string url)
        {
            WhoisLookup lookup = new WhoisLookup();
            var response = lookup.Lookup(url);

            return response.Content;
            
        }
        ///<summary>
        ///Pings the specified URL or IP Address.
        /// </summary>
        /// <param name="url">The URL to ping.</param>
        /// <param name="milliseconds">The amount of time in milliseconds between pings.</param>
        /// <returns></returns>
        public string Ping(string url, int milliseconds)
        { 
            
                Ping ping = new Ping();
                PingReply reply = ping.Send(url, milliseconds);
                
                return reply.Status.ToString();
            
            
        }
    }
}
