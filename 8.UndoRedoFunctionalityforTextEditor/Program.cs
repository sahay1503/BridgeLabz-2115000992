using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("Hello");
        editor.AddState("Hello Sid");
        editor.AddState("Hello Siddhant");

        editor.DisplayCurrentState(); // "Hello Siddhant"

        editor.Undo(); // "Hello Sid"
        editor.Undo(); // "Hello"
        editor.Redo(); // "Hello Sid"

        editor.AddState("Hello Siddhant Sahay");
        editor.DisplayCurrentState(); // "Hello Siddhant Sahay"
    }
}
