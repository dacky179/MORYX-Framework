﻿using System.ComponentModel;
using System.Runtime.Serialization;
using Marvin.Runtime.Maintenance.Contracts;
using Marvin.Tools.Wcf;

namespace Marvin.Runtime.Maintenance.Plugins.LogMaintenance
{
    /// <summary>
    /// Configuration for the logging of the maintenance.
    /// </summary>
    [DataContract]
    public class LoggingMaintenanceConfig : MaintenancePluginConfig
    {
        /// <summary>
        /// Constructor for the logging maintenance config. Creates an endpoint "LogMaintenance" with binding type "BasicHttp"
        /// </summary>
        public LoggingMaintenanceConfig()
        {
            ProvidedEndpoint = new HostConfig
            {
                Endpoint = "LogMaintenance",
                BindingType = ServiceBindingType.BasicHttp,
                MetadataEnabled = true
            };
        }

        /// <summary>
        /// The name of the plugin.
        /// </summary>
        public override string PluginName
        {
            get { return LoggingAppenderPlugin.PluginName; }
        }

        /// <summary>
        /// If a logging appender exceeds this timeouts its config stream is closed
        /// </summary>
        [DataMember]
        [Description("If a logging appender exceeds this timeouts its config stream is closed")]
        [DefaultValue(30000)]
        public int AppenderTimeOut { get; set; }
    }
}
