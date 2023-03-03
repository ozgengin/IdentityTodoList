namespace IdentityTodoList.Data
{
    public class NewTodoItemViewModel
    {
        public string Title { get; set; } = null!;

        public List<TodoItem> TodoItems { get; set; } = new();
    }
}
