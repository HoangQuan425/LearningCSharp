using Microsoft.EntityFrameworkCore;
using MyWebsite.Core.Sharedkernel;
using MyWebsite.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.EF
{
	public class EFRepository<T, K> : IRepository<T, K>, IDisposable where T : DomainEntity<K>
	{
		private readonly AppDbContext _context;

		public EFRepository(AppDbContext context)
		{
			_context = context;
		}

		public void Add(T entity)
		{
			_context.Add(entity);
		}

		public async Task AddAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
		}

		public void Dispose()
		{
			if (_context != null)
			{
				_context.Dispose();
			}
		}

		public T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
		{
			return GetAll(includeProperties).SingleOrDefault(predicate);
		}

		public T Get(K id, params Expression<Func<T, object>>[] includeProperties)
		{
			return GetAll(includeProperties).SingleOrDefault(x=>x.Id.Equals(id));
		}

		public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> items = _context.Set<T>();
			if(includeProperties != null){
				foreach(var includeProperty in includeProperties)
				{
					items = items.Include(includeProperty);
				}
			}
			return items;
		}

		public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> items = _context.Set<T>();
			if (includeProperties != null)
			{
				foreach (var includeProperty in includeProperties)
				{
					items = items.Include(includeProperty);
				}
			}
			return items.Where(predicate);
		}

		public void Remove(K id)
		{
			_context.Remove(Get(id));
		}

		public void Remove(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

		public async Task RemoveAsync(K id)
		{
			var entity = await _context.Set<T>().FindAsync(id);
			if (entity != null)
			{
				_context.Set<T>().Remove(entity);
			}
		}

		public async Task RemoveAsync(T entity)
		{
			_context.Set<T>().Remove(entity);
			await Task.CompletedTask;
		}

		public void RemoveMultiple(List<T> entities)
		{
			_context.Set<T>().RemoveRange(entities);
		}

		public void Update(T entity)
		{
			_context.Set<T>().Update(entity);
		}

		public async Task UpdateAsync(T entity)
		{
			_context.Set<T>().Update(entity);
			await Task.CompletedTask;
		}
	}
}
