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
using System.Collections.Generic;
using Marvin.Model;


namespace Marvin.Runtime.UserManagement.Model
{
    /// <summary>
    /// The public API of the OperationGroup repository.
    /// </summary>
    public partial interface IOperationGroupRepository : IRepository<OperationGroup>
    {
		/// <summary>
        /// Get all OperationGroups from the database
        /// </summary>
		/// <returns>A collection of entities. The result may be empty but not null.</returns>
        ICollection<OperationGroup> GetAll();
        /// <summary>
        /// Get first OperationGroup that matches the given parameter 
        /// or null if no match was found.
        /// </summary>
        /// <param name="groupName">Value the entity has to match</param>
        /// <returns>First matching OperationGroup</returns>
        OperationGroup GetByGroupName(string groupName);
        /// <summary>
        /// Creates instance with all not nullable properties prefilled
        /// </summary>
        OperationGroup Create(string groupName); 
    }
}
