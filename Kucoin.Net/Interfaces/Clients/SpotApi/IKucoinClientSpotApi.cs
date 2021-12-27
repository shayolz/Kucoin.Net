﻿using CryptoExchange.Net.ExchangeInterfaces;
using System;

namespace Kucoin.Net.Interfaces.Clients.SpotApi
{
    /// <summary>
    /// Spot API endpoints
    /// </summary>
    public interface IKucoinClientSpotApi : IDisposable
    {
        /// <summary>
        /// Endpoints related to account settings, info or actions
        /// </summary>
        IKucoinClientSpotApiAccount Account { get; }

        /// <summary>
        /// Endpoints related to retrieving market and system data
        /// </summary>
        IKucoinClientSpotApiExchangeData ExchangeData { get; }

        /// <summary>
        /// Endpoints related to orders and trades
        /// </summary>
        IKucoinClientSpotApiTrading Trading { get; }

        /// <summary>
        /// Get the IExchangeClient for this client. This is a common interface which allows for some basic operations without knowing any details of the exchange.
        /// </summary>
        /// <returns></returns>
        IExchangeClient AsExchangeClient();
    }
}
