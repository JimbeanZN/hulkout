﻿using System.Collections.Generic;
using System.Linq;

namespace HulkOut.Extensions
{
	public static class EnumerableExtensions
	{
		/// <summary>
		///   Determines whether a sequence is null or empty.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source">The source.</param>
		/// <returns></returns>
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
		{
			return source == null || !source.Any();
		}
	}
}