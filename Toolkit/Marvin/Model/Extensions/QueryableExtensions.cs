﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Marvin.Model
{
    /// <summary>
    /// Extensions for the <see cref="IQueryable{T}"/>
    /// </summary>
    public static class QueryableExtensions
    {
        /// <summary>
        /// Queries all entities wich are not deleted
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="query">The current query</param>
        /// <returns>Filtered query with no deleted items</returns>
        public static IQueryable<TSource> Active<TSource>(this IQueryable<TSource> query)
            where TSource : class, IModificationTrackedEntity
        {
            return query.Where(element => element.Deleted == null);
        }

        /// <summary>
        /// Queries all entities wich are not deleted
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="query">The current query</param>
        /// <param name="predicate">>A function to test each element for a condition.</param>
        /// <returns>Filtered query with no deleted items</returns>
        public static IQueryable<TSource> Active<TSource>(this IQueryable<TSource> query, Expression<Func<TSource, bool>> predicate)
            where TSource : class, IModificationTrackedEntity
        {
            return query.Active().Where(predicate);
        }

        /// <summary>
        /// Queries only deleted entities.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="query">The current query.</param>
        /// <returns>Deleted items</returns>
        public static IQueryable<TSource> Deleted<TSource>(this IQueryable<TSource> query) 
            where TSource : class, IModificationTrackedEntity
        {
            return query.Where(element => element.Deleted != null);
        }

        /// <summary>
        /// Queries only deleted entities.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="query">The current query.</param>
        /// <param name="predicate">>A function to test each element for a condition.</param>
        /// <returns>Deleted items</returns>
        public static IQueryable<TSource> Deleted<TSource>(this IQueryable<TSource> query, Expression<Func<TSource, bool>> predicate)
            where TSource : class, IModificationTrackedEntity
        {
            return query.Deleted().Where(predicate);
        }

        /// <summary>
        /// Queries all entities which are modififed since a specified date.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="query">The current query.</param>
        /// <param name="date">The start date to query</param>
        /// <returns>Filtered query</returns>
        public static IQueryable<TSource> ModifiedSince<TSource>(this IQueryable<TSource> query, DateTime date)
            where TSource : class, IModificationTrackedEntity
        {
            return ModifiedSince(query, date, false);
        }

        /// <summary>
        /// Queries all items which are modififed since a specified date.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="query">The current query.</param>
        /// <param name="date">The start date to query</param>
        /// <param name="withDeleted">Determines if the query should contain deleted entities</param>
        /// <returns>Filtered query</returns>
        public static IQueryable<TSource> ModifiedSince<TSource>(this IQueryable<TSource> query, DateTime date, bool withDeleted)
            where TSource : class, IModificationTrackedEntity
        {
            return query.Active().Where(e => e.Updated > date && ((e.Deleted == null) || withDeleted));
        }

        /// <summary>
        /// Queries all items which are created since a specified date.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="query">The current query.</param>
        /// <param name="date">The start date to query</param>
        /// <returns>Filtered query</returns>
        public static IQueryable<TSource> CreatedSince<TSource>(this IQueryable<TSource> query, DateTime date)
            where TSource : class, IModificationTrackedEntity
        {
            return CreatedSince(query, date, false);
        }

        /// <summary>
        /// Queries all items which are created since a specified date.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="query">The current query.</param>
        /// <param name="date">The start date to query</param>
        /// <param name="withDeleted">Determines if the query should contain deleted entities</param>
        /// <returns>Filtered query</returns>
        public static IQueryable<TSource> CreatedSince<TSource>(this IQueryable<TSource> query, DateTime date, bool withDeleted)
            where TSource : class, IModificationTrackedEntity
        {
            return query.Active().Where(e => e.Created > date && (e.Deleted != null) == withDeleted);
        }

        /// <summary>
        /// Queries all items with the given keys.
        /// Keys which cannot be found will be ignored!
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="query">The current query.</param>
        /// <param name="keys">The keys to find</param>
        /// <returns>Filtered query</returns>
        public static IQueryable<TSource> ByKeys<TSource>(this IQueryable<TSource> query, long[] keys)
            where TSource : class, IEntity
        {
            return query.Where(e => keys.Contains(e.Id));
        }
    }
}