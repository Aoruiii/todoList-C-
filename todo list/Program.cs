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

    if(!IsTodoValid(todo)){AddTodo();}

    todos.Add(todo);
    Console.WriteLine($"TODO successfully added:{todo}");

}

bool IsTodoValid(string todo) {
    if (todo.Length==0){
        Console.WriteLine("The description cannot be empty.");
        return false;
    } 
    if(todos.Contains(todo)){
        Console.WriteLine("The description must be unique.");
        return false;
    }
    return true;
}

void ReadTodos() {
    if(todos.Count == 0){
        Console.WriteLine("No TODOs have been added yet.");
    } else {
        for(int i=0;i<todos.Count;i++) {
        Console.WriteLine($"{i+1}. {todos[i]}");
    }
    }
}

void RemoveTodo() {
    if(todos.Count == 0) {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    Console.WriteLine("Select the index of the TODO you want to remove:");

    ReadTodos();

    string userRemoveIndex = Console.ReadLine();

   if(ValidateIndex(userRemoveIndex) != 0){
        int index = ValidateIndex(userRemoveIndex);
        Console.WriteLine($"TODO removed: {todos[index-1]}");
        todos.RemoveAt(index-1);
    } else {
        RemoveTodo();
    }

}

int ValidateIndex(string userIndex) {
    
    if(userIndex.Length ==0) {
        Console.WriteLine("Selected index cannot be empty.");
        return 0;
    }

    bool isIndexParsed = int.TryParse(userIndex,out int index);

    if(!isIndexParsed || index > todos.Count || index==0) { //index is not integer or not in the proper range
        Console.WriteLine("The given index is not valid.");
        return 0;
    }
    
    return index;

}