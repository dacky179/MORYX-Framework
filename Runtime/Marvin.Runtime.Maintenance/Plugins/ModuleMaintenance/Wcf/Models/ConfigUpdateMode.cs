﻿namespace Marvin.Runtime.Maintenance.Plugins.ModuleMaintenance.Wcf
{
    /// <summary>
    /// Enum for the update behavior of a plugin on a configuration save.
    /// </summary>
    public enum ConfigUpdateMode
    {
        /// <summary>
        /// Only save changes and use them with next plugin start
        /// </summary>
        OnlySave,

        /// <summary>
        /// Save changes and reincarnate plugin so changes take effect
        /// </summary>
        SaveAndReincarnate,

        /// <summary>
        /// Update current config object live while plugin is still running
        /// </summary>
        UpdateLiveAndSave
    }
}
