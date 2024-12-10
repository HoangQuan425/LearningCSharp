using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Infrastructure.Interfaces
{
	public interface IRepository<T, K> where T : class 
	{
		T Get(K id, params Expression<Func<T, object>>[] includeProperties);
		T FindSingle(Expression<Func<T, bool>>predicate, params Expression<Func<T, Object>>[] includeProperties);
		IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);
		IQueryable<T> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
		void Add(T entity);
		void Update(T entity);
		void Remove(K id);
		void Remove(T entity);
		void RemoveMultiple(List<T> entities);
		Task AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task RemoveAsync(K id);
		Task RemoveAsync(T entity);

	}
}
