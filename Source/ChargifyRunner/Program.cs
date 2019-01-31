using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using ChargifyNET;

namespace ChargifyRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            PricePointFetch();
        }

        static void PricePointFetch()
        {
            var chargify = new ChargifyConnect(
                "http://flight-schedule-pro-sandbox.chargify.com", //billingSettings.SiteUrl,
                "", //billingSettings.ApiKey,
                "X", //billingSettings.ApiPassword,
                "" //billingSettings.SharedKey
            )
            {
                ProtocolType = SecurityProtocolType.Tls12
            };

            var pricePoints = chargify.GetPricePointsForComponent(403258); // .GetComponentInfoForSubscription(subscriptionId, componentId);


        }
    }
}
