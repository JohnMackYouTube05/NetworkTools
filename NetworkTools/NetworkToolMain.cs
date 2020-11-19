using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using Whois;
using System.Net.NetworkInformation;
using IpData;

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
        public async Task<string> GetIPInfoAsync(string url)
        {
            var client = new IpDataClient("d5f45345b8720164c887e8be9efb9528755068443079bc87bd4c6fd5");

            var ipInfo = await client.Lookup(url);
            StringBuilder ipString = new StringBuilder();
            ipString.AppendLine("IP Address: " + ipInfo.Ip);
            ipString.AppendLine("ASN: " + ipInfo.Asn);
            ipString.AppendLine("Calling Code: " + ipInfo.CallingCode);
            ipString.AppendLine("Continent: " + ipInfo.ContinentName);
            ipString.AppendLine("Country: " + ipInfo.CountryName);
            ipString.AppendLine("City: " + ipInfo.City);
            ipString.AppendLine("Currency: " + ipInfo.Currency.ToString());
            ipString.AppendLine("Flag Image: " + ipInfo.Flag);
            ipString.AppendLine("Is Europe: " + ipInfo.IsEu.Value.ToString());
            ipString.AppendLine("Latitude: " + ipInfo.Latitude);
            ipString.AppendLine("Longitude: " + ipInfo.Longitude);
            ipString.AppendLine("Organization: " + ipInfo.Organisation);
            ipString.AppendLine("ZIP Code:" + ipInfo.Postal);
            ipString.AppendLine("Region: " + ipInfo.Region);
            ipString.AppendLine("Current Time + Time Zone: " + ipInfo.TimeZone.CurrentTime.Value.DateTime.ToString() + ipInfo.TimeZone.Name);
            ipString.AppendLine("Is Tor?: " + ipInfo.Threat.IsTor);
            ipString.AppendLine("Is Bogon?: " + ipInfo.Threat.IsBogon.ToString());
            ipString.AppendLine("Is Anonymous?: " + ipInfo.Threat.IsAnonymous.ToString());
            ipString.AppendLine("Is Known Abuser?: " + ipInfo.Threat.IsKnownAbuser.ToString());
            ipString.AppendLine("Is Known Attacker?: " + ipInfo.Threat.IsKnownAttacker.ToString());
            ipString.AppendLine("Is Proxy?: " + ipInfo.Threat.IsProxy.ToString());
            ipString.AppendLine("Is Other Threat?: " + ipInfo.Threat.IsThreat);
            return ipString.ToString();

        }
    }
}
