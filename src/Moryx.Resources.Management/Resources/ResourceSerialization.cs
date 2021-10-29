// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Moryx.AbstractionLayer.Resources;
using Moryx.Configuration;
using Moryx.Container;
using Moryx.Runtime.Configuration;
using Moryx.Serialization;
using IContainer = Moryx.Container.IContainer;

namespace Moryx.Resources.Management
{
    /// <summary>
    /// Implementation of <see cref="ICustomSerialization"/> for types derived from <see cref="Resource"/>
    /// </summary>
    [Component(LifeCycle.Singleton, typeof(ICustomSerialization))]
    internal class ResourceSerialization : PossibleValuesSerialization
    {
        private static readonly EntrySerializeSerialization Serialization;

        static ResourceSerialization()
        {
            Serialization = new EntrySerializeSerialization();
        }

        public ResourceSerialization(IContainer container, IRuntimeConfigManager configManager) : base(container, configManager)
        {
        }

        /// <summary>
        /// Only export properties flagged with <see cref="EntrySerializeAttribute"/>
        /// </summary>
        public override IEnumerable<PropertyInfo> GetProperties(Type sourceType)
        {
            return typeof(Resource).IsAssignableFrom(sourceType)
                ? base.GetProperties(sourceType).Where(p => p.GetCustomAttribute<EntrySerializeAttribute>()?.Mode == EntrySerializeMode.Always)
                : Serialization.GetProperties(sourceType);
        }

        public override IEnumerable<MethodInfo> GetMethods(Type sourceType)
        {
            return Serialization.GetMethods(sourceType);
        }
    }
}
