using ToDoApp.Models;

namespace ToDoApp.Components.Pages;

public partial class ToDoList
{
    private List<ToDoItem> items = ToDoItemRepository.GetItems();           // loade data fra repo


    private void AddTask()
    {
        ToDoItemRepository.AddItem(new ToDoItem { Name = "New Task" });     // her tilføjes ny item til listen
        
        items = ToDoItemRepository.GetItems();                              // bruges til at reloade listen igen

    }
}