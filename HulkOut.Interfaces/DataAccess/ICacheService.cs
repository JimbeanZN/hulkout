using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HulkOut.Interfaces.DataAccess
{
	public interface ICacheService
	{
		T Get<T>(string key);
		T Set<T>(string key, T value);
		bool Delete(string key);
		bool Exists(string key);

		bool FlushAll();
		bool FlushCurrent();
	}
}