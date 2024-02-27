// See https://aka.ms/new-console-template for more information


bool isExit=false;
string userInput;
var todos = new List<string>();

Console.WriteLine("Hello!");

do{
    Console.WriteLine("");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    userInput = Console.ReadLine().ToUpper();

    switch(userInput){
        case "S":
        ReadTodos();
        break;
        case "A":
        AddTodo();
        break;
        case "R":
        RemoveTodo();
        break;
        case "E":
        isExit = true;
        Console.WriteLine("Exit Successfully.");
        break;
        default:
        Console.WriteLine("Invalid Option!");
        break;
    }
} while(!isExit);


void AddTodo(){
    Console.WriteLine("Enter the todo description:");

    string todo = Console.ReadLine();

    if (todo.Length==0){
        Console.WriteLine("The description cannot be empty.");
        AddTodo();
    } else if(todos.Contains(todo)){
        Console.WriteLine("The description must be unique.");
        AddTodo();
    } else {todos.Add(todo);
    Console.WriteLine($"TODO successfully added:{todo}");
    }
}

void ReadTodos() {
    if(todos.Count == 0){
        Console.WriteLine("No TODOs have been added yet.");
    }
    else {
        for(int i=0;i<todos.Count;i++) {
        Console.WriteLine($"{i+1}. {todos[i]}");
    }
    }
}

void RemoveTodo() {
    Console.WriteLine("Select the index of the TODO you want to remove:");
    ReadTodos();
    if(todos.Count != 0) {
        string userRemoveIndex = Console.ReadLine();

        if(userRemoveIndex.Length ==0) {
            Console.WriteLine("Selected index cannot be empty.");
            RemoveTodo();
        }

        bool isIndexParsed = int.TryParse(userRemoveIndex,out int index);

        if(!isIndexParsed || index > todos.Count || index==0) { //index is not integer or not in the proper range
            Console.WriteLine("The given index is not valid.");
            RemoveTodo();
        } else {
            Console.WriteLine($"TODO removed: {todos[index-1]}");
            todos.RemoveAt(index-1);
            return;
        }
    }

}