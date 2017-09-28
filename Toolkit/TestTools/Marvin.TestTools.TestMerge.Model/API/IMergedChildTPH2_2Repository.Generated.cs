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
using Marvin.TestTools.Test.Model;


namespace Marvin.TestTools.TestMerge.Model
{
    /// <summary>
    /// The public API of the MergedChildTPH2_2 repository.
    /// </summary>
    public partial interface IMergedChildTPH2_2Repository : IRepository<MergedChildTPH2_2>
    {
		/// <summary>
        /// Get all MergedChildTPH2_2s from the database
        /// </summary>
		/// <param name="deleted">Include deleted entities in result</param>
		/// <returns>A collection of entities. The result may be empty but not null.</returns>
        ICollection<MergedChildTPH2_2> GetAll(bool deleted);
        /// <summary>
        /// Get first MergedChildTPH2_2 that matches the given parameter 
        /// or null if no match was found.
        /// </summary>
        /// <param name="b">Value the entity has to match</param>
        /// <returns>First matching MergedChildTPH2_2</returns>
        MergedChildTPH2_2 GetByB(global::System.Nullable<int> b);
        /// <summary>
        /// Get first MergedChildTPH2_2 that matches the given parameter 
        /// or null if no match was found.
        /// </summary>
        /// <param name="temp">Value the entity has to match</param>
        /// <returns>First matching MergedChildTPH2_2</returns>
        MergedChildTPH2_2 GetByTemp(global::System.Nullable<double> temp);
        /// <summary>
        /// This method returns all matching MergedChildTPH2_2s for given parameters
        /// </summary>
        /// <param name="combinedChildTPH">Value for CombinedChildTPH the MergedChildTPH2_2s have to match</param>
        IEnumerable<MergedChildTPH2_2> GetCombiTPHInheritance(global::System.Nullable<int> combinedChildTPH);

    }
}
