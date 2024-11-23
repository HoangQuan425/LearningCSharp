using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Sharedkernel
{
	public abstract class DomainEntity<T>
	{
		public T Id { get; set; }

		//true if domain entity has an identity
		public bool IsTrasient() {
			return Id.Equals(default(T));
		}
	}
}
