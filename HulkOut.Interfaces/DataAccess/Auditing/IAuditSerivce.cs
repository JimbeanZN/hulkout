using System;
using System.Collections.Generic;
using HulkOut.Models.Data;
using static HulkOut.Models.Enums.AuditEnums;

namespace HulkOut.Interfaces.DataAccess.Auditing
{
	public interface IAuditSerivce : IBaseService<Audit>
	{
		/// <summary>
		///   Writes the audit.
		/// </summary>
		/// <param name="description">The description.</param>
		/// <param name="auditAction">The audit action.</param>
		void WriteAudit(string description, AuditAction auditAction);

		/// <summary>
		///   Writes the audit.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="description">The description.</param>
		/// <param name="auditAction">The audit action.</param>
		/// <param name="originalObject">The original object.</param>
		/// <param name="newObject">The new object.</param>
		void WriteAudit<T>(string description, AuditAction action, T originalObject, T newObject);
	}
}