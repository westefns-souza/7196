using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandler : 
        Notifiable,
        IHandler<CreateTodoCommand>
    {
        private readonly ITodoRepository _repository;

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateTodoCommand command)
        {
            command.Validate();

            if (command.Invalid)
            {
                return new GenericCommandResult(false, "Parece que sua tarefa está errada!", command.Notifications);
            }

            var todoItem = new TodoItem(command.Title, command.Date, command.User);

            _repository.Create(todoItem);
            
            return new GenericCommandResult(true, "Tarefa salva!", todoItem);
        }
    }
}