using HulkOut.Interfaces.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkOut.Core.DataAccess.Cache
{
	public class RedisCacheService : ICacheService
	{
		public bool Delete(string key)
		{
			throw new NotImplementedException();
		}

		public bool Exists(string key)
		{
			throw new NotImplementedException();
		}

		public T Get<T>(string key)
		{
			throw new NotImplementedException();
		}

		public T Set<T>(string key, T value)
		{
			throw new NotImplementedException();
		}
	}
}
