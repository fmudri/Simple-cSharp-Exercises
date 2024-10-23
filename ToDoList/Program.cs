using System;
using System.Reflection;
Console.WriteLine("Hello!");

static string DisplayMenu()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    Console.WriteLine();

    string userInput = Console.ReadLine().ToLower().Trim();
    return userInput;
}
var userInput = "";
string description = "";
List<string> todos = [];

do
{
    userInput = DisplayMenu();

    if (userInput == "s")
    {
        SeeAllTodos();
    }
    if (userInput == "a")
    {
        AddTodo();
    }
    if (userInput == "r")
    {
        RemoveTodo();
    }
    if (userInput != "e" && userInput != "s" && userInput != "a" && userInput != "r")
    {
        Console.WriteLine("Incorrect input");
    }
}
while (userInput != "e");

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter TODO description:");
        description = Console.ReadLine();
    }
    while (!IsDescriptionValid(description));

    todos.Add(description);
    Console.WriteLine($"TODO added: {description}");
}
void RemoveTodo()
{
    if (todos.Count != 0)
    {
        int index;

        do
        {
            Console.WriteLine("Select the index of the TODO you want to remove:");
            SeeAllTodos();
        }
        while (!TryReadIndex(out index));
        RemoveTodoAtIndex(index - 1);
    }
    else
    {
        ShowNoTodosMessage();
        return;
    }
}
void SeeAllTodos()
{
    if (todos.Count < 1)
    {
        ShowNoTodosMessage();
        return;
    }

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}
bool TryReadIndex(out int index)
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        index = 0;
        Console.WriteLine("Input cannot be empty. Please enter a valid index.");
        return false;
    }
    else
    {
        if (int.TryParse(input, out index) && index > 0 && index <= todos.Count)
        {
            return true;
        }
        Console.WriteLine("Invalid index. Please try again.");
        return false;
    }
}
bool IsDescriptionValid(string description)
{
    if (string.IsNullOrEmpty(description))
    {
        Console.WriteLine("Description cannot be empty.");
        return false;
    }
    if (todos.Contains(description))
    {
        Console.WriteLine("Description must be unique.");
        return false;
    }
    return true;
}
void RemoveTodoAtIndex(int index)
{
    description = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine($"TODO removed: {description}");
}
static void ShowNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}