using System.Collections.Generic;

namespace UnitTestsDemoPart2
{
    public class TodoListManager
    {
        public List<string> TodoList { get; set; } = new List<string>();
        public void AddTodo(string task)
        {
            TodoList.Add(task);
        }
    }
}
