using MomentoMethodDesignPattern;

TextEditor editor = new TextEditor();
History history = new History();

// Initial content
editor.Content = " Hello, " ;

// Save state
history.SaveState(editor.Save());

// Make changes
editor.Content += " world! " ;

// Save state
history.SaveState(editor.Save());

// Undo
editor.Restore(history.GetLastState());