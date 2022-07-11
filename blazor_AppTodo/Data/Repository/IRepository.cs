using System;
using System.Collections.Generic;
using System.Linq;
using blazor_todo_app.Models;

namespace blazor_todo_app.Data.Repository
{
	public interface IRepository
	{
		IEnumerable<TodoItem> GetAllItems();
		void AddTodo(string todoName);
		void ValueChanged(TodoItem changedItem);
		void DeleteItem(int id);
	}
}

