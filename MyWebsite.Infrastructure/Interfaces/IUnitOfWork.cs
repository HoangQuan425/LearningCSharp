using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Infrastructure.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		//Call save change from db context
		void Commit();

	}
}
