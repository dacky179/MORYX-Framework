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

namespace Marvin.Runtime.UserManagement.Model
{
    internal partial class LibraryAccessRepository : EntityFrameworkRepository<LibraryAccess>, ILibraryAccessRepository
    {
        public static IRepository Create(IUnitOfWork uow, DbContext context)
        {
            var instance = new LibraryAccessRepository();
            instance.UnitOfWork = uow;
            instance.Context = context;
            instance.DbSet = context.Set<LibraryAccess>();
            return instance;
        }

        public ICollection<LibraryAccess> GetAll()
		{
			return DbSet.ToList();
		}
    }
}
