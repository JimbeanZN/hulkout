using HulkOut.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HulkOut.Models.Enums.AuditEnums;

namespace HulkOut.Interfaces.DataAccess.Auditing
{
	public interface IAuditSerivce
	{
		/// <summary>
		/// Writes the audit.
		/// </summary>
		/// <param name="description">The description.</param>
		/// <param name="auditAction">The audit action.</param>
		void WriteAudit(string description, AuditAction auditAction);

		/// <summary>
		/// Writes the audit.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="description">The description.</param>
		/// <param name="auditAction">The audit action.</param>
		/// <param name="originalObject">The original object.</param>
		/// <param name="newObject">The new object.</param>
		void WriteAudit<T>(string description, AuditAction action, T originalObject, T newObject);

		/// <summary>
		/// Gets the audit.
		/// </summary>
		/// <param name="Id">The identifier.</param>
		/// <returns></returns>
		Audit GetAudit(Guid Id);

		/// <summary>
		/// Gets the audit list.
		/// </summary>
		/// <param name="Entity">The entity.</param>
		/// <param name="EntityId">The entity identifier.</param>
		/// <returns></returns>
		IEnumerable<Audit> GetAuditList(string Entity, Guid EntityId);
	}
}
