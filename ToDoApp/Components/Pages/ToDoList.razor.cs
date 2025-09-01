using ToDoApp.Models;

namespace ToDoApp.Components.Pages;

public partial class ToDoList
{
    // loade data fra repo
    private List<ToDoItem> items = ToDoItemRepository.GetItems();

    private void AddTask()
    {
        // her tilføjes ny item til listen
        ToDoItemRepository.AddItem(new ToDoItem { Name = "New Task" });

        // bruges til at reloade listen igen
        items = ToDoItemRepository.GetItems();
    }
}