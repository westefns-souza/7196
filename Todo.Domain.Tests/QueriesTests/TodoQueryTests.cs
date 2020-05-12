using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Tests.QueriesTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "usuarioB"));
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "usuarioB"));
        }

        [TestMethod]
        public void Dado_a_consulta_deve_retornar_tarefas_apenas_do_usuario_a()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("usuarioA"));

            Assert.AreEqual(3, result.Count());
        }
    }
}