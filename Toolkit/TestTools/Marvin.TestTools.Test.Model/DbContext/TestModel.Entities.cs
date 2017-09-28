﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Serialization;
using Marvin.Model;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;

namespace Marvin.TestTools.Test.Model
{
    /// <summary>
    /// The DBContext of this database model.
    /// </summary>
    [DbConfigurationType(typeof(EntityFrameworkConfiguration))]
    public partial class Entities : DbContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities() : base(@"metadata=res://*/TestModel.csdl|res://*/TestModel.ssdl|res://*/TestModel.msl;provider=Devart.Data.PostgreSql;provider connection string=""""")
        {
            Configure(ContextMode.AllOn);
        }

        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public Entities(string connectionString, ContextMode mode) :
                base(connectionString)
        {
            Configure(mode);
        }

        /// <summary>
        /// Initializes a new Entities object using an exisiting connection.
		/// This constructor is used mainly for unit testing with the <a href="http://effort.codeplex.com/">Effort</a> in-memory database.
        /// </summary>
        public Entities(DbConnection connection, ContextMode mode) : base(connection, true)
        {
            Configure(mode);
        }

        
        internal ContextMode CurrentMode { get; private set; }
        internal void Configure(ContextMode mode)
        {
            Configuration.ProxyCreationEnabled = ((int)mode & 0x1) != 0;
            Configuration.LazyLoadingEnabled = ((int)mode & 0x2) != 0;
            Configuration.AutoDetectChangesEnabled = ((int)mode & 0x4) != 0; ;
            Configuration.ValidateOnSaveEnabled = true;
            CurrentMode = mode;
        }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            throw new UnintentionalCodeFirstException();
        }

    
        /// <summary>
        /// A huge poco
        /// </summary>
        /// <LongDescription>
        /// The huge poco contains a lot of pocos for test
        /// </LongDescription>
        public virtual DbSet<HugePoco> HugePocos { get; set; }
    
        /// <summary>
        /// There are no comments for RecursiveReference in the schema.
        /// </summary>
        public virtual DbSet<RecursiveReference> RecursiveReferences { get; set; }
    
        /// <summary>
        /// There are no comments for TopParent in the schema.
        /// </summary>
        public virtual DbSet<TopParent> TopParents { get; set; }
    
        /// <summary>
        /// There are no comments for JsonTester in the schema.
        /// </summary>
        public virtual DbSet<JsonTester> JsonTesters { get; set; }
    
        /// <summary>
        /// There are no comments for BaseClass in the schema.
        /// </summary>
        public virtual DbSet<BaseClass> BaseClasses { get; set; }
    
        /// <summary>
        /// There are no comments for ReferenceBase in the schema.
        /// </summary>
        public virtual DbSet<ReferenceBase> ReferenceBases { get; set; }
    }
}
