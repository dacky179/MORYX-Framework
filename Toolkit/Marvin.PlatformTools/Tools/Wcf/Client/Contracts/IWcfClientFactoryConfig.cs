﻿namespace Marvin.Tools.Wcf
{
    /// <summary>
    /// Public API of the WCF client factory configuration.
    /// </summary>
    public interface IWcfClientFactoryConfig
    {
        /// <summary>
        /// Hostname or IP-Adress of the server to connect to.
        /// </summary>
        string Host { get; }

        /// <summary>
        /// The port number of the version service on the server to connect to.
        /// </summary>
        int Port { get; }

        /// <summary>
        /// Unique ClientId
        /// </summary>
        string ClientId { get; }
    }
}