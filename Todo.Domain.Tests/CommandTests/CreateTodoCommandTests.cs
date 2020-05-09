using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            command.Validate();
            Assert.AreEqual(command.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            var command = new CreateTodoCommand("Titulo da tarefe", "westefns", DateTime.Now);
            command.Validate();
            Assert.AreEqual(command.Valid, true);
        }
    }
}