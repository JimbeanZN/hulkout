using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkOut.Core.Extensions
{
	public static class EnumerableExtensions
	{
		/// <summary>
		/// Determines whether a sequence is not null and empty.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source">The source.</param>
		/// <returns></returns>
		public static bool IsNotNullAndEmpty<T>(this IEnumerable<T> source)
		{
			return source != null && source.Any();
		}
	}
}
