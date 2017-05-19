using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using HulkOut.Interfaces.Auditing;
using HulkOut.Models.Data;
using HulkOut.Models.Enums;

namespace HulkOut.Logic
{
	/// <summary>
	/// </summary>
	/// <seealso cref="IAuditSerivce" />
	public class AuditService : IAuditSerivce
	{
		/// <summary>
		///   Deletes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public bool Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///   Gets the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns></returns>
		public Audit Get(Guid id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///   Get all by the specified filter.
		/// </summary>
		/// <param name="filter">The filter.</param>
		/// <returns></returns>
		public IEnumerable<Audit> GetAll(Expression<Func<Audit, bool>> filter)
		{
			throw new ArgumentNullException(nameof(filter));
		}

		/// <summary>
		///   Inserts the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public Audit Insert(Audit model)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///   Updates the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public Audit Update(Audit model)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///   Writes the audit.
		/// </summary>
		/// <param name="description">The description.</param>
		/// <param name="auditAction">The audit action.</param>
		/// <exception cref="NotImplementedException"></exception>
		public void WriteAudit(string description, AuditEnums.AuditAction auditAction)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///   Writes the audit.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="description">The description.</param>
		/// <param name="action"></param>
		/// <param name="originalObject">The original object.</param>
		/// <param name="newObject">The new object.</param>
		/// <exception cref="NotImplementedException"></exception>
		public void WriteAudit<T>(string description, AuditEnums.AuditAction action, T originalObject, T newObject)
		{
			throw new NotImplementedException();
		}
	}
}