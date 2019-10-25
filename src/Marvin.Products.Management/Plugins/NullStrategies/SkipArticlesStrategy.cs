﻿using Marvin.AbstractionLayer;
using Marvin.Container;
using Marvin.Products.Model;

namespace Marvin.Products.Management.NullStrategies
{
    /// <summary>
    /// Strategiy for articles that should not be saved to the database
    /// </summary>
    [PropertylessStrategyConfiguration(typeof(ProductInstance), DerivedTypes = true)]
    [Plugin(LifeCycle.Transient, typeof(IProductInstanceStrategy), Name = nameof(SkipArticlesStrategy))]
    public class SkipArticlesStrategy : InstanceStrategyBase
    {
        public SkipArticlesStrategy() : base(true)
        {
        }

        public override void Initialize(ProductInstanceConfiguration config)
        {
            base.Initialize(config);

            SkipInstances = true;
        }

        public sealed override void SaveInstance(ProductInstance source, IGenericColumns target)
        {
            // Not necessary
        }

        public sealed override void LoadInstance(IGenericColumns source, ProductInstance target)
        {
            // Nothing
        }
    }
}