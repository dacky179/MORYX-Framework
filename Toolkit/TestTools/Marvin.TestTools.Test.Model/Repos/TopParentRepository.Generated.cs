﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the Marvin template for generating Repositories and a Unit of Work for Entity Framework.
// If you have any questions or suggestions for improvement regarding this code, contact Thomas Fuchs. I allways need feedback to improve.
//
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. So even when you think you can do better,
// don't touch it.
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using Marvin.Model;

namespace Marvin.TestTools.Test.Model
{
    internal partial class TopParentRepository : EntityFrameworkRepository<TopParent>, ITopParentRepository
    {
        public static IRepository Create(IUnitOfWork uow, DbContext context)
        {
            var instance = new TopParentRepository();
            instance.UnitOfWork = uow;
            instance.Context = context;
            instance.DbSet = context.Set<TopParent>();
            return instance;
        }

        public ICollection<TopParent> GetAll(bool deleted)
		{
			return DbSet.Where(e => e.Deleted == null || deleted).ToList();
		}
        public virtual ICollection<TopParent> GetAllByUpdated(global::System.DateTime updated)
        {
			return DbSet.Where(e => e.Updated == updated && e.Deleted == null).ToList();
        }
        public virtual TopParent GetByNumber(int number)
        {
		    return DbSet.FirstOrDefault(e => e.Number == number && e.Deleted == null);
        }

        public TopParent Create(int number) 
        {
            var entity = Create();
            entity.Number = number;
            return entity;
        }
        public TopParent GetCreatedAndUpdated(global::System.DateTime created, global::System.DateTime updated)
        {
		    return DbSet.FirstOrDefault(e => e.Created == created && e.Updated == updated);
        }

        public IEnumerable<TopParent> GetUpdatedAndNumber(global::System.DateTime updated, int number)
        {
			return DbSet.Where(e => e.Updated == updated && e.Number == number).ToList();
        }

        protected override void ExecuteRemove(TopParent entity, bool permanent)
        {
            if (permanent)
                base.ExecuteRemove(entity, permanent);
            else
                entity.Deleted = DateTime.Now;
		}

		protected override void ExecuteRemoveRange(IEnumerable<TopParent> entities, bool permanent)
		{
            if (permanent)
            {
                base.ExecuteRemoveRange(entities, permanent);
            }
            else
            {
                foreach (var entity in entities)
                {
                    entity.Deleted = DateTime.Now;
                }
            }
		}

    }
}
