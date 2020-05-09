using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {
        }

        public TodoItem GetById(Guid id, string user)
        {
            return new TodoItem("Titulo", DateTime.Now, "Westefns");
        }

        public void Update(TodoItem todo)
        {
        }
    }
}