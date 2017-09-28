﻿using System;
using Marvin.Testing;

namespace Marvin.Container
{
    /// <summary>
    /// Attribute for properties in Castle using named components
    /// </summary>
    [OpenCoverIgnore]
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
    public class NamedAttribute : Attribute
    {
        /// <summary>
        /// Create a new instance of the <see cref="NamedAttribute"/>
        /// </summary>
        /// <param name="name">Name of the component that shall be injected</param>
        public NamedAttribute(string name)
        {
            ComponentName = name;
        }

        /// <summary>
        /// Name of component to inject at this point
        /// </summary>
        public string ComponentName { get; set; }
    }
}
