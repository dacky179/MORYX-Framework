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
using System.Data.Entity.Validation;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using Marvin.Model;

namespace Marvin.Runtime.UserManagement.Model
{
    internal partial class EntityFrameworkMergedUnitOfWork  : IUnitOfWork
    {
        private Marvin.Runtime.UserManagement.Model.UserManagementContainer _context;
        private readonly IDictionary<Type, RepoBuilder> _repoBuilders;
        private readonly IUnitOfWork _mergedUow;

        public EntityFrameworkMergedUnitOfWork(Marvin.Runtime.UserManagement.Model.UserManagementContainer context, IDictionary<Type, RepoBuilder> repoBuilders, IUnitOfWork mergedUow)
        {
            _context = context;
            _repoBuilders = repoBuilders;
            _mergedUow = mergedUow;
        }

        protected void CloseContext()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }

        #region IDisposable Methods

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    CloseContext();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region IUnitOfWork Members
        public string ModelNamespace { get { return "Marvin.Runtime.UserManagement.Model";  } }

        public virtual T GetRepository<T>() where T : class, IRepository
        {
            var type = typeof (T);
            if (type.IsGenericType)
                type = type.GetGenericArguments()[0];

            T repo;
            if (type.Namespace == "Marvin.Runtime.UserManagement.Model") 
                repo = (T)_repoBuilders[typeof(T)](this, _context);
            else
                repo = _mergedUow.GetRepository<T>();
            return repo;
        }

        public ContextMode Mode
        {
            get { return _context.CurrentMode; }
            set
            {
                _mergedUow.Mode = value;
                _context.Configure(value);
            }
        }

        public virtual void Save()
        {
			try
			{
				_context.SaveChanges();
			}
			// Catch for validation error break point
			catch (DbEntityValidationException valEx)
			{
			    var validationError = valEx.EntityValidationErrors;
			    throw;
			}
			// Catch for other exception break points
			catch (Exception)
			{
				// Debug entity framework exceptions
				throw;
			}
        }
        #endregion
    }
}
