﻿using System.Runtime.Serialization;

namespace Marvin.Configuration
{
    /// <summary>
    /// Base implementation of IConfig to reduce redundant code
    /// </summary>
    [DataContract]
    public class ConfigBase : UpdatableEntry, IConfig
    {
        /// <summary>
        /// Current state of the config object
        /// </summary>
        [DataMember]
        public ConfigState ConfigState { get; set; }

        /// <summary>
        /// Exception message if load failed
        /// </summary>
        public string LoadError { get; set; }

        /// <summary>
        /// Method called if no file was found and the config was generated
        /// </summary>
        protected internal virtual void Initialize()
        {
        }
    }
}
