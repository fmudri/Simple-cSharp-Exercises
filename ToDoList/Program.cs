using System;
using System.Reflection;
Console.WriteLine("Hello!");
Console.WriteLine();

static string DisplayMenu()
{
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
string todoDescription = "";
List<string> todos = [];

do
{
    userInput = DisplayMenu();

    if (userInput == "s")
    {
        if (todos.Count < 1)
        {
            Console.WriteLine("No TODOs have been added yet.");
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todos[i]}");
            }
        }
    }
    if (userInput == "a")
    {
        todoDescription = string.Empty;
        bool isValidDescription = false;

        while (!isValidDescription)
        {
            Console.WriteLine("Enter TODO description:");
            todoDescription = Console.ReadLine();

            var isEmpty = string.IsNullOrEmpty(todoDescription);

            var notUnique = todos.Contains(todoDescription);

            if (isEmpty)
            {
                Console.WriteLine("Description cannot be empty.");
                Console.WriteLine();
            }
            else if (notUnique)
            {
                Console.WriteLine("Description must be unique.");
                Console.WriteLine();
            }
            else
            {
                isValidDescription = true;
            }
        }
        todos.Add(todoDescription);
        Console.WriteLine($"TODO added successfully: {todoDescription}");
        Console.WriteLine();
    }
    if (userInput == "r")
    {
        if (todos.Count != 0)
        {
            Console.WriteLine("Select the index of the TODO you want to remove:");

            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todos[i]}");
            }
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty. Please enter a valid index.");
            }
            else
            {
                bool isValidInput = int.TryParse(input, out int index);

                if (isValidInput && index > 0 && index <= todos.Count)
                {
                    todoDescription = todos[index - 1];
                    todos.RemoveAt(index - 1);

                    Console.WriteLine($"TODO removed: {todoDescription}");
                }
                else
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
            }
        }
        else
        {
            Console.WriteLine("No TODOs have been added yet.");
            Console.WriteLine();
        }
    }
    if (userInput != "e" && userInput != "s" && userInput != "a" && userInput != "r")
    {
        Console.WriteLine();
        Console.WriteLine("Incorrect input");
        Console.WriteLine();
    }
}
while (userInput != "e");
