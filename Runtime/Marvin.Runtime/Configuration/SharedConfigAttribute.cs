﻿using System;
using Marvin.Configuration;
using Marvin.Testing;

namespace Marvin.Runtime.Configuration
{
    /// <summary>
    /// Attribute used to reference another <see cref="IConfig"/>. Do not decorate the property with data member as it will write a copy of the config to your xml.
    /// </summary>
    [OpenCoverIgnore]
    [AttributeUsage(AttributeTargets.Property)]
    public class SharedConfigAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of the <see cref="SharedConfigAttribute"/>
        /// </summary>
        /// <param name="useCopy">Flag if the injected object shall be a copy</param>
        public SharedConfigAttribute(bool useCopy)
        {
            UseCopy = useCopy;
        }

        /// <summary>
        /// Flag if the injected object shall be a copy
        /// </summary>
        public bool UseCopy
        {
            get; 
            private set;
        }        
    }
}
