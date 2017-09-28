//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the Marvin template for generating Repositories and a Unit of Work for Entity Framework model.
// If you have any questions or suggestions for improvement regarding this code, contact Thomas Fuchs.
// Code is generated on: 25.09.2013 15:01:35
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Marvin.Model
{
    /// <summary>
    /// Base contract for all repositories defining UnitOfWork property
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Unit of work this repository controls access to
        /// </summary>
        IUnitOfWork UnitOfWork { get; }
    }

    /// <summary>
    /// Generic base repository for typed entity access
    /// </summary>
    /// <typeparam name="T">Type of entity</typeparam>
    public interface IRepository<T> : IRepository
    {
        /// <summary>
        /// Linq queryable collection
        /// </summary>
        IQueryable<T> Linq { get; }

        /// <summary>
        /// Get the entity with this key
        /// </summary>
        T GetByKey(long id);

        /// <summary>
        /// Get all entities with this ids
        /// </summary>
        ICollection<T> GetByKeys(long[] ids); 

        /// <summary>
        /// Create a new instance of this type and add it to the context
        /// </summary>
        T Create();
        /// <summary>
        /// Create a new instance but specify, if it should be added to the context
        /// </summary>
        /// <param name="addToContext"><value>True</value>Instance is added to the context. <value>False</value>Instance is not added to the context</param>
        T Create(bool addToContext);

        /// <summary>
        /// Remove entity. ModificationTracked entities will only update the
        /// Deleted flag.
        /// </summary>
        void Remove(T entity);

        /// <summary>
        /// Remove the entity and specifiy whether to remove permanenent or 
        /// simply flag it as deleted if possible.
        /// </summary>
        void Remove(T entity, bool permanent);

        /// <summary>
        /// Remove a range of entities from the context
        /// </summary>
        void RemoveRange(IEnumerable<T> entities);

        /// <summary>
        /// Remove a range of entities permanent
        /// </summary>
        void RemoveRange(IEnumerable<T> entities, bool permanent);

        /// <summary>
        /// Load a reference property of an entity
        /// </summary>
        /// <param name="entity">Entity to load for</param>
        /// <param name="loadExpression">Expression to pass to context for loading</param>
        void Load<TOut>(T entity, Expression<Func<T, TOut>> loadExpression)
            where TOut : class;

        /// <summary>
        /// Load related parts of an entity
        /// </summary>
        /// <param name="entity">Entity to load for</param>
        /// <param name="loadExpression">Expression to pass to context for loading</param>
        void Load<TOut>(T entity, Expression<Func<T, ICollection<TOut>>> loadExpression)
            where TOut : class;

        /// <summary>
        /// Load related parts of an entity
        /// </summary>
        /// <param name="entity">Entity to load for</param>
        /// <param name="loadExpression">Expression to pass to context for loading</param>
        /// <param name="filter"></param>
        void Load<TOut>(T entity, Expression<Func<T, ICollection<TOut>>> loadExpression, Expression<Func<TOut, bool>> filter)
            where TOut : class;
    }
}
