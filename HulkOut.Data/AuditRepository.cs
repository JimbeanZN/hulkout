﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using HulkOut.Interfaces.DataAccess.Auditing;
using HulkOut.Models.Data;

namespace HulkOut.Data.EF
{
	public class AuditRepository : IAuditRepository
	{
		/// <summary>
		/// Gets the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		public IEnumerable<Audit> Get(Expression<Func<Audit, bool>> filter)
		{
			using (var db = new HulkOutDbContext())
			{
				return db.Audits.Where(filter).ToList();
			}
		}

		/// <summary>
		/// Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		public Audit Insert(Audit model)
		{
			using (var db = new HulkOutDbContext())
			{
				db.Audits.Add(model);
				db.SaveChanges();

				return model;
			}
		}

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public Audit Update(Audit model)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public bool Delete(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}