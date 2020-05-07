using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult() { }
        
        public GenericCommandResult(bool success, string nessage, object data)
        {
            Success = success;
            Nessage = nessage;
            Data = data;
        }

        public bool Success { get; set; }
        public string Nessage { get; set; }
        public object Data { get; set; }
    }
}