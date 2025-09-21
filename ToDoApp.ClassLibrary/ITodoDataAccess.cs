
namespace ToDoApp.ClassLibrary
{
    public interface ITodoDataAccess
    {
        List<TodoModel> LoadTodoItems();
        void SaveTodoItems(List<TodoModel> todoListitems);
    }
}