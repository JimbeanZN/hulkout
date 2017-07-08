using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HulkOut.Tests
{
	public static class AssertExceptionAsync
	{
		public static async Task ThrowsExceptionAsync<TException>(Func<Task> code)
		{
			try
			{
				await code();
			}
			catch (Exception ex)
			{
				if (ex.GetType() == typeof(TException))
					return;
				throw new AssertFailedException("Incorrect type; expected ... got ...", ex);
			}

			throw new AssertFailedException("Did not see expected exception ...");
		}
	}
}
