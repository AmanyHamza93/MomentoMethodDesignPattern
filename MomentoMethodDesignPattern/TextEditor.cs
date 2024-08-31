using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentoMethodDesignPattern
{
    public class TextEditor
    {
        private string content;

        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                Console.WriteLine($"Current Content: { content}");
            }
        }

        public EditorMemento Save()
        {
            return new EditorMemento(content);
        }

        public void Restore(EditorMemento memento)
        {
            content = memento.Content;
            Console.WriteLine($"Restored Content: { content}");
        }
    }
}
