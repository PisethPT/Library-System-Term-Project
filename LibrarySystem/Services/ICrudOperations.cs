using System.Collections.Generic;

namespace LibrarySystem.Services
{
	public interface ICrudOperations<T>
	{
		List<T> GetAll();
		string Insert(T entity);
		string Update(int Id, T entity);
		string Delete(int Id, T entity);
		T GetById(int Id);
	}
}
