// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using System.Collections.Generic;
using System.Linq;
using Marvin.AbstractionLayer;
using Marvin.Model;
using Marvin.Products.Model;
using Marvin.Tools;

namespace Marvin.Products.Management
{
    /// <summary>
    /// Default part accessor without model merge
    /// </summary>
    public abstract class LinkStrategyBase : LinkStrategyBase<ProductLinkConfiguration>
    {
    }

    /// <summary>
    /// Default part accessor without model merge
    /// </summary>
    public abstract class LinkStrategyBase<TConfig> : StrategyBase<TConfig, ProductLinkConfiguration>, IProductLinkStrategy
        where TConfig : ProductLinkConfiguration
    {
        /// <summary>
        /// Name of the parts property
        /// </summary>
        public string PropertyName { get; private set; }

        /// <summary>
        /// Strategy to determine how article instances are loaded as parts
        /// </summary>
        public PartSourceStrategy PartCreation { get; private set; }

        /// <inheritdoc />
        public override void Initialize(ProductLinkConfiguration config)
        {
            base.Initialize(config);
            
            PropertyName = config.PartName;
            PartCreation = config.PartCreation;

            TargetType = ReflectionTool.GetPublicClasses<ProductType>(p => p.Name == config.TargetType).FirstOrDefault();
        }

        /// <inheritdoc />
        public abstract void LoadPartLink(IGenericColumns linkEntity, IProductPartLink target);

        /// <inheritdoc />
        public abstract void SavePartLink(IProductPartLink source, IGenericColumns target);

        /// <inheritdoc />
        public virtual void DeletePartLink(IReadOnlyList<IGenericColumns> deprecatedEntities)
        {
        }
    }
}
